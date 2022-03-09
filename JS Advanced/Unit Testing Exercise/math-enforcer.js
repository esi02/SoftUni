let mathEnforcer = {
  addFive: function (num) {
    if (typeof num !== "number") {
      return undefined;
    }
    return num + 5;
  },
  subtractTen: function (num) {
    if (typeof num !== "number") {
      return undefined;
    }
    return num - 10;
  },
  sum: function (num1, num2) {
    if (typeof num1 !== "number" || typeof num2 !== "number") {
      return undefined;
    }
    return num1 + num2;
  },
};

let assert = require("chai").assert;
let expect = require("chai").expect;

describe("mathEnforcer", () => {
  describe("Test addFive func", () => {
    it("return undefined if input is not a number", () => {
      assert.equal(mathEnforcer.addFive("5"), undefined);
      assert.equal(mathEnforcer.addFive({}), undefined);
      assert.equal(mathEnforcer.addFive(), undefined);
      assert.equal(mathEnforcer.addFive([]), undefined);
    });
    it("return number if input is number", () => {
      assert.equal(mathEnforcer.addFive(5), 10);
    });
    it("return number if input is negative", () => {
      assert.equal(mathEnforcer.addFive(-1), 4);
    });
    it("return number if input is floating number", () => {
      let result = mathEnforcer.addFive(2.5);
      assert.closeTo(result, 7.5, 0.01);
    });
  });

  describe("Test subtractTen func", () => {
    it("return undefined if input is not a number", () => {
      assert.equal(mathEnforcer.subtractTen("5"), undefined);
      assert.equal(mathEnforcer.subtractTen({}), undefined);
      assert.equal(mathEnforcer.subtractTen(), undefined);
      assert.equal(mathEnforcer.subtractTen([]), undefined);
    });
    it("return number if input is number", () => {
      assert.equal(mathEnforcer.subtractTen(10), 0);
    });
    it("return number if input is negative", () => {
      assert.equal(mathEnforcer.subtractTen(-1), -11);
    });
    it("return number if input is floating number", () => {
      let result = mathEnforcer.subtractTen(10.5);
      assert.closeTo(result, 0.5, 0.01);
    });
  });

  describe("Test sum func", () => {
    it("return undefined if first input is not a number", () => {
      assert.equal(mathEnforcer.sum("5"), undefined);
      assert.equal(mathEnforcer.sum({}), undefined);
      assert.equal(mathEnforcer.sum(), undefined);
      assert.equal(mathEnforcer.sum([]), undefined);
    });
    it("return undefined if second input is not a number", () => {
      assert.equal(mathEnforcer.sum(5, "5"), undefined);
    });
    it("return number if both inputs are number", () => {
      assert.equal(mathEnforcer.sum(10, 10), 20);
    });
    it("return number if first input is negative", () => {
      assert.equal(mathEnforcer.sum(-1, 5), 4);
    });
    it("return number if second input is negative", () => {
      assert.equal(mathEnforcer.sum(5, -1), 4);
    });
    it("return negative number if both inputs are negative", () => {
        assert.equal(mathEnforcer.sum(-5, -1), -6);
      });
    it("return number if first input is floating number", () => {
      let result = mathEnforcer.sum(10.5, 5);
      assert.closeTo(result, 15.5, 0.01);
    });
    it("return number if second input is floating number", () => {
      let result = mathEnforcer.sum(10, 5.5);
      assert.closeTo(result, 15.5, 0.01);
    });
    it("return number if both inputs are floating number", () => {
        let result = mathEnforcer.sum(10.5, 5.5);
        assert.closeTo(result, 16, 0.01);
      });
  });
});
