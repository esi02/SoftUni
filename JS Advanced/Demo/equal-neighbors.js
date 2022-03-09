function neighbour(matrix) {
    let num = 0;
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            if(matrix[i][j] === matrix[i++][j]) {
                num = matrix[i][j];
            }
        }
    }
    return num;
}
console.log(neighbour([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]
));