//@ts-check
const { chromium } = require('playwright-chromium');
const { expect } = require('chai');
let url = 'http://127.0.0.1:5500/lesson-05/base/index.html';
let testRecipeImg = 'https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/0A475B34-4E78-40D8-9F30-46223B7D77E7/Derivates/E55C7EA4-0E60-403F-B5DC-75EA358197BD.jpg';
let testRecipeIngredients = `200g Dark chocolate\n100g Red berries\n 1 cup of Milk...`;
let testRecipeSteps = `1.Prepare ingredients\n2.Mix\n3.Bake 30 minutes\n4.Eat and enjoy`;

let browser, page;

describe('E2E tests', function () {
    this.timeout(10000);

    before(async () => {
        browser = await chromium.launch({ headless: false, slowMo: 500 });
    });

    after(async () => {
        await browser.close();
    });

    beforeEach(async () => {
        page = await browser.newPage();
    });

    afterEach(async () => {
        await page.close();
    });
    
    describe('Catalog tests', () => {
        it('Navigation bar', async() => {
            await page.goto(url);
            const navBar = await page.textContent('header');
    
            expect(navBar).to.contains('My Cookbook');
            expect(navBar).to.contains('Catalog');
            expect(navBar).to.contains('Login');
            expect(navBar).to.contains('Register');
        });
        it('Render catalog data', async() => {
            await page.goto(url);
            const recipes = await page.textContent('#catalog');
            
            expect(recipes).to.contains('Easy Lasagna');
            expect(recipes).to.contains('Grilled Duck Fillet');
            expect(recipes).to.contains('Roast Trout');
        });
        it('Render recipe details', async() => {
            await page.goto(url);
            await page.click('.preview');
            
            const detailsAreVisible = await page.isVisible('#details');
            expect(detailsAreVisible).to.be.true;
        });
    });

    describe('Authentication tests', () => {
        it('Login makes correct request', async() => {
            await page.goto(url);
            await page.click('#loginLink');
            await page.locator('input[name="email"]').fill('peter@abv.bg');
            await page.locator('input[name="password"]').fill('123456');
            await page.click('input[value="Login"]');

            const navBar = await page.textContent('header');
    
            expect(navBar).to.contains('My Cookbook');
            expect(navBar).to.contains('Catalog');
            expect(navBar).to.contains('Create Recipe');
            expect(navBar).to.contains('Logout');
        });
        it('Register makes correct request', async() => {
            await page.goto(url);
            await page.click('#registerLink');
            await page.locator('input[name="email"]').fill('random@email.bg');
            await page.locator('input[name="password"]').fill('123456');
            await page.locator('input[name="rePass"]').fill('123456');

            await page.on('dialog', dialog => dialog.accept());
            await page.click('input[value="Register"]');
            const navBar = await page.textContent('header');
    
            expect(navBar).to.contains('My Cookbook');
            expect(navBar).to.contains('Catalog');
            expect(navBar).to.contains('Create Recipe');
            expect(navBar).to.contains('Logout');
        });
    });

    describe('CRUD operations tests', () => {
        it('Logged in user creating recipes tests', async() => {
            await page.goto(url);
            await page.click('#loginLink');
            await page.locator('input[name="email"]').fill('peter@abv.bg');
            await page.locator('input[name="password"]').fill('123456');
            await page.click('input[value="Login"]');

            await page.click('#createLink');
            await page.locator('input[name="name"]').fill('Chocolate cake');
            await page.locator('input[name="img"]').fill(testRecipeImg);
            await page.locator('textarea[name="ingredients"]').fill(testRecipeIngredients);
            await page.locator('textarea[name="steps"]').fill(testRecipeSteps);
            await page.click('input[value="Create Recipe"]');

            const recipeTitles = await page.textContent('article h2');
            const buttonsAreVisible = await page.isVisible('.controls');

            expect(recipeTitles).to.contains('Chocolate cake');
            expect(buttonsAreVisible).to.be.true;
        });
        it('Owner of recipe editing recipe tests', async() => {
            await page.goto(url);
            await page.click('#loginLink');
            await page.locator('input[name="email"]').fill('peter@abv.bg');
            await page.locator('input[name="password"]').fill('123456');
            await page.click('input[value="Login"]');

            await page.click('article:nth-of-type(4)');
            await page.click('.controls button');
            let editISVisible = await page.isVisible('#edit');
            await page.click('input[value="Update Recipe"]');
            let detailsAreVisible = await page.isVisible('#details');

            expect(editISVisible).to.be.true;
            expect(detailsAreVisible).to.be.true;
        });
        it('Owner of recipe deleting recipe tests', async() => {
            await page.goto(url);
            await page.click('#loginLink');
            await page.locator('input[name="email"]').fill('peter@abv.bg');
            await page.locator('input[name="password"]').fill('123456');
            await page.click('input[value="Login"]');

            await page.click('article:nth-of-type(4)');
            await page.on('dialog', dialog => dialog.accept());
            await page.click('.controls button:nth-of-type(2)');
            let deletedRecipeText = await page.textContent('article h2')

            expect(deletedRecipeText).to.equal('Recipe deleted');
        });
    })
})

