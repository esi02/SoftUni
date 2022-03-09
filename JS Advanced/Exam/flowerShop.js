const flowerShop = {
    calcPriceOfFlowers(flower, price, quantity) {
        if (typeof flower != 'string' || !Number.isInteger(price) || !Number.isInteger(quantity)) {
            throw new Error('Invalid input!');
        } else {
            let result = price * quantity;
            return `You need $${result.toFixed(2)} to buy ${flower}!`;
        }
    },
    checkFlowersAvailable(flower, gardenArr) {
        if (gardenArr.indexOf(flower) >= 0) {
            return `The ${flower} are available!`;
        } else {
            return `The ${flower} are sold! You need to purchase more!`;
        }
    },
    sellFlowers(gardenArr, space) {
        let shop = [];
        let i = 0;
        if (!Array.isArray(gardenArr) || !Number.isInteger(space) || space < 0 || space >= gardenArr.length) {
            throw new Error('Invalid input!');
        } else {
            while (gardenArr.length > i) {
                if (i != space) {
                    shop.push(gardenArr[i]);
                }
                i++
            }
        }
        return shop.join(' / ');
    }
}

let assert = require('chai').assert;
let expect = require('chai').expect;

describe("flowerShop tests", function() {
    describe("calcPriceOfFlowers", function() {
        it("testing flower input", function() {
            expect(() => flowerShop.calcPriceOfFlowers(5, 2, 2)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers({}, 2, 2)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers(7.00, 2, 2)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers(['flower'], 2, 2)).to.throw(Error, 'Invalid input!');

            assert.equal(flowerShop.calcPriceOfFlowers('tulip', 2, 2), `You need $4.00 to buy tulip!`);
            assert.equal(flowerShop.calcPriceOfFlowers('Rose', 2, 2), `You need $4.00 to buy Rose!`);
        });
        it("testing price input", function() {
            expect(() => flowerShop.calcPriceOfFlowers('tulip', '2', 2)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('tulip', {}, 2)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('tulip', [], 2)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('tulip', 2.56, 2)).to.throw(Error, 'Invalid input!');

            assert.equal(flowerShop.calcPriceOfFlowers('tulip', -2, 2), `You need $-4.00 to buy tulip!`);
            assert.equal(flowerShop.calcPriceOfFlowers('Rose', 0, 2), `You need $0.00 to buy Rose!`);
            assert.equal(flowerShop.calcPriceOfFlowers('Rose', 5, 2), `You need $10.00 to buy Rose!`);
        });
        it("testing quantity input", function() {
            expect(() => flowerShop.calcPriceOfFlowers('tulip', 2, '2')).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('tulip', 2, {})).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('tulip', 2, [])).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('tulip', 2, 2.56)).to.throw(Error, 'Invalid input!');

            assert.equal(flowerShop.calcPriceOfFlowers('tulip', 2, -2), `You need $-4.00 to buy tulip!`);
            assert.equal(flowerShop.calcPriceOfFlowers('Rose', 2, 0), `You need $0.00 to buy Rose!`);
            assert.equal(flowerShop.calcPriceOfFlowers('Rose', 2, 5), `You need $10.00 to buy Rose!`);
        });
     });
     describe('checkFlowersAvailable tests', function () {
        it('testing flower input', function () {
            assert.equal(flowerShop.checkFlowersAvailable('Tulip', ['Rose', 'Rosemary']), `The Tulip are sold! You need to purchase more!`);
            assert.equal(flowerShop.checkFlowersAvailable('Rose', ['Tulip', 'Rosemary']), `The Rose are sold! You need to purchase more!`);
            assert.equal(flowerShop.checkFlowersAvailable('Rosemary', ['Rose']), `The Rosemary are sold! You need to purchase more!`);
            assert.equal(flowerShop.checkFlowersAvailable('Tulip', []), `The Tulip are sold! You need to purchase more!`);

            assert.equal(flowerShop.checkFlowersAvailable('Tulip', ['Tulip', 'Rosemary']), `The Tulip are available!`);
            assert.equal(flowerShop.checkFlowersAvailable('Rose', ['Rose', 'Rosemary']), `The Rose are available!`);
            assert.equal(flowerShop.checkFlowersAvailable('Rosemary', ['Rosemary']), `The Rosemary are available!`);
        });
     });
     describe('sellFlowers tests', function () {
        it('array input tests', function () {
            expect(() => flowerShop.sellFlowers({}, 1)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(1, 1)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers('1', 1)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(5.00, 1)).to.throw(Error, 'Invalid input!');

            assert.equal(flowerShop.sellFlowers(['Tulip', 'Rose'], 1), 'Tulip');
            assert.equal(flowerShop.sellFlowers(['Tulip', 'Rose', 'Rosemary'], 1), 'Tulip / Rosemary');
            assert.equal(flowerShop.sellFlowers(['Tulip', 'Rose'], 0), 'Rose');
            assert.equal(flowerShop.sellFlowers(['Tulip', 'Rose', 'Lily'], 2), 'Tulip / Rose');
        });
        it('space input tests', function () {
            expect(() => flowerShop.sellFlowers(['Tulip'], 1)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(['Tulip'], '1')).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(['Tulip'], {})).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(['Tulip'], [])).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(['Tulip'], -2)).to.throw(Error, 'Invalid input!');

            assert.equal(flowerShop.sellFlowers(['Tulip', 'Rose'], 0), 'Rose');
            assert.equal(flowerShop.sellFlowers(['Tulip', 'Rose', 'Rosemary'], 1), 'Tulip / Rosemary');
            assert.equal(flowerShop.sellFlowers(['Tulip', 'Rose'], 0), 'Rose');
            assert.equal(flowerShop.sellFlowers(['Tulip', 'Rose', 'Lily'], 1), 'Tulip / Lily');
        });
     });
});
