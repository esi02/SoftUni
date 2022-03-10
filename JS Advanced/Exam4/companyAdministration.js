const companyAdministration = {

    hiringEmployee(name, position, yearsExperience) {
        if (position == "Programmer") {
            if (yearsExperience >= 3) {
                return `${name} was successfully hired for the position ${position}.`;
            } else {
                return `${name} is not approved for this position.`;
            }
        }
        throw new Error(`We are not looking for workers for this position.`);
    },
    calculateSalary(hours) {

        let payPerHour = 15;
        let totalAmount = payPerHour * hours;

        if (typeof hours !== "number" || hours < 0) {
            throw new Error("Invalid hours");
        } else if (hours > 160) {
            totalAmount += 1000;
        }
        return totalAmount;
    },
    firedEmployee(employees, index) {

        let result = [];

        if (!Array.isArray(employees) || !Number.isInteger(index) || index < 0 || index >= employees.length) {
            throw new Error("Invalid input");
        }
        for (let i = 0; i < employees.length; i++) {
            if (i !== index) {
                result.push(employees[i]);
            }
        }
        return result.join(", ");
    }

}

let assert = require('chai').assert;
let expect = require('chai').expect;

describe("Company administration tests", function () {
    it("hiringEmployee tests", function () {
        assert.equal(companyAdministration.hiringEmployee('someName', 'Programmer', 1), `someName is not approved for this position.`);
        assert.equal(companyAdministration.hiringEmployee('someName', 'Programmer', 0), `someName is not approved for this position.`);
        assert.equal(companyAdministration.hiringEmployee('someName', 'Programmer', -2), `someName is not approved for this position.`);
        assert.equal(companyAdministration.hiringEmployee('someName', 'Programmer', 3), `someName was successfully hired for the position Programmer.`);
        assert.equal(companyAdministration.hiringEmployee('someName', 'Programmer', 6), `someName was successfully hired for the position Programmer.`);
        expect(() => companyAdministration.hiringEmployee('someName', 'someotherprofession', 1)).to.throw(Error, `We are not looking for workers for this position.`);
    });
    it('calculateSalary tests', function () {
        expect(() => companyAdministration.calculateSalary('hours')).to.throw(Error, 'Invalid hours');
        expect(() => companyAdministration.calculateSalary(-1)).to.throw(Error, 'Invalid hours');
        assert.equal(companyAdministration.calculateSalary(0), 0);
        assert.equal(companyAdministration.calculateSalary(50), 750);
        assert.equal(companyAdministration.calculateSalary(166), 3490);
    });
    it('firedEmployee tests', function () {
        expect(() => companyAdministration.firedEmployee('notAnArray', 0)).to.throw(Error, 'Invalid input');
        expect(() => companyAdministration.firedEmployee(['firstEmployee', 'secondEmployee'], '0')).to.throw(Error, 'Invalid input');
        expect(() => companyAdministration.firedEmployee(['firstEmployee', 'secondEmployee'], 3)).to.throw(Error, 'Invalid input');
        expect(() => companyAdministration.firedEmployee(['firstEmployee', 'secondEmployee'], 2)).to.throw(Error, 'Invalid input');
        expect(() => companyAdministration.firedEmployee(['firstEmployee', 'secondEmployee'], -2)).to.throw(Error, 'Invalid input');
        assert.equal(companyAdministration.firedEmployee(['firstEmployee', 'secondEmployee'], 0), 'secondEmployee');
        assert.equal(companyAdministration.firedEmployee(['Ivan', 'Dragan', 'Petkan'], 1), 'Ivan, Petkan');
    });
});
