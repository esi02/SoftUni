function biggestElement(matrix) {
        let biggestNum = Math.max();

        for (let i = 0; i < matrix.length; i++) {
            for (let j = 0; j < matrix[i].length; j++) {
                if(matrix[i][j] > biggestNum) {
                    biggestNum = matrix[i][j];
                }
            }
        }
        return biggestNum;
}
console.log(biggestElement([[3, 5, 7, 12],
    [-1, 4, 33, 2],
    [8, 3, 0, 4]]
   ));