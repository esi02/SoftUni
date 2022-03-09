const numberOperations = {
    powNumber: function (num) {
        return num * num;
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input < 100) {
            return 'The number is lower than 100!';
        } else {
            return 'The number is greater or equal to 100!';
        }
    },
    sumArrays: function (array1, array2) {

        const longerArr = array1.length > array2.length ? array1 : array2;
        const rounds = array1.length < array2.length ? array1.length : array2.length;

        const resultArr = [];

        for (let i = 0; i < rounds; i++) {
            resultArr.push(array1[i] + array2[i]);
        }

        resultArr.push(...longerArr.slice(rounds));

        return resultArr
    }
};

let assert = require('chai').assert;
let expect = require('chai').expect;

describe("Number operations tests", function() {
    describe("powNumber tests", function() {
        it("should return number multiplyed with itself", function() {
            let expected = 25;
            let actual = numberOperations.powNumber(5);

            assert.equal(actual, expected);
        });
        it("negative multiplication", function() {
            let expected = 25;
            let actual = numberOperations.powNumber(-5);

            assert.equal(actual, expected);
        });
        it("multiplication with zero", function() {
            let expected = 0;
            let actual = numberOperations.powNumber(0);

            assert.equal(actual, expected);
        });
     });
     describe("numberChecker tests", function() {
        it("when input is not a number", function() {
            expect(() => numberOperations.numberChecker('string')).to.throw(Error, "The input is not a number!");
        });
        it("when input is less than 100", function() {
            let expected = 'The number is lower than 100!';
            let actual = numberOperations.numberChecker(90);

            assert.equal(actual, expected);
        });
        it("when input is negative", function() {
            let expected = 'The number is lower than 100!';
            let actual = numberOperations.numberChecker(-20);

            assert.equal(actual, expected);
        });
        it("when input is greater than 100", function() {
            let expected = 'The number is greater or equal to 100!';
            let actual = numberOperations.numberChecker(200);

            assert.equal(actual, expected);
        });
        it("when input is equal to 100", function() {
            let expected = 'The number is greater or equal to 100!';
            let actual = numberOperations.numberChecker(100);

            assert.equal(actual, expected);
        });
     });
     describe("sumArrays tests", function() {
        it("returns correct output", function() {
            expect(numberOperations.sumArrays([1, 2], [1,2])).to.deep.equals([2,4]);
            expect(numberOperations.sumArrays([0, 0], [0,0])).to.deep.equals([0, 0]);
            expect(numberOperations.sumArrays([1], [1])).to.deep.equals([2]);
            expect(numberOperations.sumArrays([-1], [1])).to.deep.equals([0]);
            expect(numberOperations.sumArrays([-1], [-1])).to.deep.equals([-2]);
            expect(numberOperations.sumArrays([-1], [-1])).to.deep.equals([-2]);
            expect(numberOperations.sumArrays([-1, 2], [-1])).to.deep.equals([-2, 2]);
            expect(numberOperations.sumArrays([-1], [-1, 2])).to.deep.equals([-2, 2]);
        });
     });
});
