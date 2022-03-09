function game(moves) {
    let initialState = [[false, false, false],
    [false, false, false],
    [false, false, false]];

    let firstPlayerSymbol = 'X';
    let secondPlayerSymbol = 'O';

    let hasWinner = false;

    for (let i = 0; i < moves.length; i++) {

        let coordinates = moves[i].split(' ').map(Number);
        let row = coordinates[0];
        let col = coordinates[1];

        if (initialState[row][col] !== false) {
            console.log("This place is already taken. Please choose another!");
            let newCoordinates = moves[i + 1].split(' ').map(Number);
            row = newCoordinates[0];
            col = newCoordinates[1];
            if(i % 2 == 0) {
                initialState[row][col] = firstPlayerSymbol;
            } else {
                initialState[row][col] = secondPlayerSymbol;
            }
            continue;
        } else if (i % 2 == 0) {
            initialState[row][col] = firstPlayerSymbol;
        } else if (i % 2 != 0) {
            initialState[row][col] = secondPlayerSymbol;
        }

        if (initialState[row].every(x => x === 'X')) {
            console.log("Player X wins!");
            hasWinner = true;
            break;
        } else if (initialState[row].every(x => x === 'O')) {
            console.log("Player O wins!");
            hasWinner = true;
            break;
        }


        let primaryDiagonal = '';
        let secondaryDiagonal = '';

        for (let j = 0; j < initialState.length; j++) {
            primaryDiagonal += initialState[j][j];
            secondaryDiagonal += initialState[j][initialState.length - 1 - j];
        }

        if (primaryDiagonal === 'OOO' || secondaryDiagonal === 'OOO') {
            console.log("Player O wins!");
            hasWinner = true;
            break;
        } else if (primaryDiagonal === 'XXX' || secondaryDiagonal === 'XXX') {
            console.log("Player X wins!");
            hasWinner = true;
            break;
        }
    }
    if (hasWinner == false) {
        console.log("The game ended! Nobody wins :(");
    }
    for (let k = 0; k < initialState.length; k++) {
        console.log(initialState[k].join('\t'));
    }
}
game(["0 0",
    "0 0",
    "1 1",
    "0 1",
    "1 2",
    "0 2",
    "2 2",
    "1 2",
    "2 2",
    "2 1"]

);