function cardFactory(face, suit) {
    let validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    let validSuits = {
        S: '\u2660',
        H: '\u2665',
        D: '\u2666',
        C: '\u2663'
    };

    if (!validFaces.includes(face) || validSuits[suit] == undefined) {
        throw new Error();
    }

    let result = `${face}${validSuits[suit]}`;
    return result;
}

console.log(cardFactory('1', 'C'));