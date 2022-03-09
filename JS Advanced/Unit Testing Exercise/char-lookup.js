function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }
    if (string.length <= index || index < 0) {
        return "Incorrect index";
    }

    return string.charAt(index);
}

let assert = require('chai').assert;
let expect = require('chai').expect;

describe('Incorrect input types', () => {
    it('return undefined if string is not string', () => {
        assert.equal(lookupChar(5, 5), undefined);
    });
    it('return undefined if index is not a number', () => {
        assert.equal(lookupChar('someText', '5'), undefined);
    });
    it('return undefined if index is decimal', () => {
        assert.equal(lookupChar('someText', 5.6), undefined);
    });
});

it('return message if index is outside the range', () => {
    assert.equal(lookupChar('text', 5), "Incorrect index");
});
it('return message if index is negative', () => {
    assert.equal(lookupChar('text', -1), "Incorrect index");
});
it('return correct char at index', () => {
    assert.equal(lookupChar('text', 1), 'e');
});