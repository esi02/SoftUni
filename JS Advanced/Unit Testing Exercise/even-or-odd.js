function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }

    return "odd";
}

let assert = require('chai').assert;
let expect = require('chai').expect;

describe('When input is not string', () => {
    it('should return undefined if input is number', () => {
        assert.equal(isOddOrEven(5), undefined);
    });
    it('should return undefined if input is object', () => {
        assert.equal(isOddOrEven({}), undefined);
    });
});
describe('When input is string', () => {
    it('should return even with even length', () => {
        assert.equal(isOddOrEven('four'), 'even');
    });
    it('should return odd with odd length', () => {
        assert.equal(isOddOrEven('eigth'), 'odd');
    });
    it('should return even', () => {
        assert.equal(isOddOrEven('edit'), 'even');
    });
    it('should return odd', () => {
        assert.equal(isOddOrEven('edito'), 'odd');
    });
});