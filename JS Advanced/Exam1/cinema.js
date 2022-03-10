const cinema = {
    showMovies: function(movieArr) {

        if (movieArr.length == 0) {
            return 'There are currently no movies to show.';
        } else {
            let result = movieArr.join(', ');
            return result;
        }

    },
    ticketPrice: function(projectionType) {

        const schedule = {
            "Premiere": 12.00,
            "Normal": 7.50,
            "Discount": 5.50
        }
        if (schedule.hasOwnProperty(projectionType)) {
            let price = schedule[projectionType];
            return price;
        } else {
            throw new Error('Invalid projection type.')
        }

    },
    swapSeatsInHall: function(firstPlace, secondPlace) {

        if (!Number.isInteger(firstPlace) || firstPlace <= 0 || firstPlace > 20 ||
            !Number.isInteger(secondPlace) || secondPlace <= 0 || secondPlace > 20 || firstPlace === secondPlace) {
            return "Unsuccessful change of seats in the hall.";
        } else {
            return "Successful change of seats in the hall.";
        }

    }
};

let assert = require('chai').assert;
let expect = require('chai').expect;

describe("Cinema tests", function() {
    describe("showMovies tests", function() {
        it("when array length is equal to zero", function() {
            let expected = 'There are currently no movies to show.';
            let actual = cinema.showMovies([]);

            assert.equal(actual, expected);
        });
        it("when array length is normal", function() {
            let expected = 'Movie1, Movie2, Movie3';
            let actual = cinema.showMovies(['Movie1', 'Movie2', 'Movie3']);

            assert.equal(actual, expected);
        });
     });
     describe("ticketPrice tests", function() {
        it("when projection type is invalid", function() {
            expect(() => cinema.ticketPrice('none')).to.throw(Error, 'Invalid projection type.');
        });
        it("when projection type exists", function() {
            let expected = 7.50;
            let actual = cinema.ticketPrice('Normal');

            assert.equal(actual, expected);
        });
     });
     describe("swapSeatsInHall tests", function() {
        it("when firstPlace is not valid", function() {
            let expected = 'Unsuccessful change of seats in the hall.';
            let actual1 = cinema.swapSeatsInHall('5', 5);
            let actual2 = cinema.swapSeatsInHall(0, 5);
            let actual3 = cinema.swapSeatsInHall(-1, 5);
            let actual4 = cinema.swapSeatsInHall(25, 5);

            assert.equal(actual1, expected);
            assert.equal(actual2, expected);
            assert.equal(actual3, expected);
            assert.equal(actual4, expected);
        });
        it("when secondPlace is not valid", function() {
            let expected = 'Unsuccessful change of seats in the hall.';
            let actual1 = cinema.swapSeatsInHall(5, 5);
            let actual2 = cinema.swapSeatsInHall(5, 0);
            let actual3 = cinema.swapSeatsInHall(5, -1);
            let actual4 = cinema.swapSeatsInHall(5, '5');
            let actual5 = cinema.swapSeatsInHall(5, 25);

            assert.equal(actual1, expected);
            assert.equal(actual2, expected);
            assert.equal(actual3, expected);
            assert.equal(actual4, expected);
            assert.equal(actual5, expected);
        });
        it("when both places are valid", function() {
            let expected = 'Successful change of seats in the hall.';
            let actual = cinema.swapSeatsInHall(6, 5);

            assert.equal(actual, expected);
        });
     });
});
