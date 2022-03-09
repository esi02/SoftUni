function diagonalSums(input) {
    let firstDiagonalSum = 0;
    let secondDiagonalSum = 0;

    let firstIndex = 0;
    let secondIndex = input[0].length - 1;
    
    input.forEach(arr => {
        firstDiagonalSum += arr[firstIndex++]
        secondDiagonalSum += arr[secondIndex--]
    });
    console.log(firstDiagonalSum + ' ' + secondDiagonalSum);
}
diagonalSums([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]
   );