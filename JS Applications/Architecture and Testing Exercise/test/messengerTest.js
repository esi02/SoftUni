const {chromium} = require('playwright-chromium');
const {expect} = require('chai');
let url = 'http://127.0.0.1:5500/01.Messenger/index.html';

let browser, page;

describe('Messenger tests', () => {
    before(async() => {
        browser = await chromium.launch();
        page = await browser.newPage();
        await page.goto(url);
    });

    after(async() => {
        await browser.close();
    });

    it('All messages should load', async() => {
        await page.click('#refresh');

        let textAreaContent = page.locator('#messages').textContent;

        expect(textAreaContent).to.not.equal('');
    });

    it('Send button should send message', async() => {
        await page.locator('#author').fill('Pencho');
        await page.locator('#content').fill('Hello there!');
        await page.click('#submit');

        let inputContent = page.locator('#author').value;

        expect(inputContent).to.be.undefined;
    });
})