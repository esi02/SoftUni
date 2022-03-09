function magical(matrix) {
    let rowSum = matrix[0].reduce((a, b) => a + b);
    let colSum = 0;

    matrix.forEach(row => {
        colSum += row[0];
    });

    let result = true;

    for (let i = 0; i < matrix.length; i++) {
        let currentRow = matrix[i].reduce((a, b) => a + b);
        let currentCol = 0;

        for (let j = 0; j < matrix.length; j++) {
            let num = matrix[j][i];
            currentCol += num;
        }

        if (currentRow !== rowSum || currentCol !== colSum) {
            result = false;
            break;
        }
    }
    return result;
}
console.log(magical([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]   
));