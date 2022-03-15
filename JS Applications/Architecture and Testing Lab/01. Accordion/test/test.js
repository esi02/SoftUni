const {chromium} = require('playwright-chromium');
const {expect} = require('chai');
const options = {headless: false, slowMo: 200};

let browser, page;
let url = 'http://127.0.0.1:5500/01.%20Accordion/index.html';

describe('Accordion tests', () => {
    it('Load titles', async() => {
        browser = await chromium.launch(options);
        page = await browser.newPage();
        await page.goto(url);
        const firstTitle = await page.textContent('.accordion .head span');
        const secondTitle = await page.textContent('.accordion:nth-of-type(2) .head span');
        const thirdTitle = await page.textContent('.accordion:nth-of-type(3) .head span');
        const fourthTitle = await page.textContent('.accordion:nth-of-type(4) .head span');
        
        expect(firstTitle).to.contains('Scalable Vector Graphics');
        expect(secondTitle).to.contains('Open standard');
        expect(thirdTitle).to.contains('Unix');
        expect(fourthTitle).to.contains('ALGOL');
        browser.close();
    });
    it('If button text is Less after click and if div is visible', async() => {
        browser = await chromium.launch(options);
        page = await browser.newPage();
        await page.goto(url);

        await page.click('button');
        const buttonText = await page.textContent('button');
        const divExtra = await page.isVisible('.extra');

        expect(buttonText).to.equal('Less');
        expect(divExtra).to.be.true;

        browser.close();
    });
    it('If button text is Less after click and if div is visible', async() => {
        browser = await chromium.launch(options);
        page = await browser.newPage();
        await page.goto(url);

        await page.click('button');
        const buttonText = await page.textContent('button');
        const divExtra = await page.isVisible('.extra');

        expect(buttonText).to.equal('Less');
        expect(divExtra).to.be.true;

        browser.close();
    });
    it('If button text is More after double click and if div is hidden', async() => {
        browser = await chromium.launch(options);
        page = await browser.newPage();
        await page.goto(url);

        await page.dblclick('button');
        const buttonText = await page.textContent('button');
        const divExtra = await page.isHidden('.extra');

        expect(buttonText).to.equal('More');
        expect(divExtra).to.be.true;

        browser.close();
    });
})