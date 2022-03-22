const {chromium} = require('playwright-chromium');
const {expect} = require('chai');
let url = 'http://127.0.0.1:5500/02.Book-Library/index.html';

let browser, page;

describe('Book library tests', () => {
    before(async () => {
        browser = await chromium.launch();
        page = await browser.newPage();
        await page.goto(url);
    });

    after(async() => {
        await browser.close();
    });

    it('Books should load correctly when clicking the button', async() => {
        await page.click('#loadBooks');
        const tableLength = page.locator('tbody').children;

        expect(tableLength).to.not.equal([]);
    });

    it('Empty book shouldnt be added', async() => {
        let dialogMessage = '';
        page.on('dialog', dialog => {
            dialogMessage = dialog.message();
            dialog.accept();
        });

        await page.click('text=Submit');

        expect(dialogMessage).to.equal('All fields are required!');
    });

    it('Book should be added', async() => {
        await page.locator('#createForm').locator('input[name="title"]').fill('Chain of Gold');
        await page.locator('#createForm').locator('input[name="author"]').fill('Cassandra Clare');
        await page.click('text=Submit');
        await page.click('#loadBooks');
        
        const trContent = await page.innerText('tbody:last-child');
        
        expect(trContent).to.contains('Chain of Gold');
    });

    it('Edit form should be visible and book should be edited', async() => {
        await page.click('.editBtn');
        let editFormIsVisible = await page.isVisible('#editForm');
        let title = await page.locator('#editForm').locator('input[name="title"]').inputValue();
        let author = await page.locator('#editForm').locator('input[name="author"]').inputValue();
        await page.click('text=Save');
        let editFormIsNotVisible = await page.isVisible('#editForm');

        expect(editFormIsVisible).to.be.true;
        expect(editFormIsNotVisible).to.be.false;
        expect(title).to.not.equal('');
        expect(author).to.not.equal('');
    });

    it('Book should be deleted', async() => {
        let dialogMessage = '';
        page.on('dialog', dialog => {
            dialogMessage = dialog.message();
            dialog.accept();
        });

        await page.click('#loadBooks');
        await page.click('text=Delete');

        expect(dialogMessage).to.equal('Are you sure you want to delete this book?');
    })
})