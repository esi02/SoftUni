function solve(arrayLength, elementsToSum) {
    let sequence = [];
    sequence.length = arrayLength;

    sequence[0] = 1;

    for (let i = 1; i < sequence.length; i++) {
        let sum = 0;
        let start = Math.max(0, i - elementsToSum);

        for (let j = start; j < i; j++) {
            sum += sequence[j];
        }
        sequence[i] = sum;
    }
    return sequence;
}
console.log(solve(6, 3));