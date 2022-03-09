function aggregate(array) {
    let numArray = array.map(Number);
    let sum = numArray.reduce((a, b) => a + b);
    let inverseSum = numArray.reduce((a, b) => a + b / b);
    let stringConcat = numArray.join('');

    console.log(sum);
    console.log(inverseSum);
    console.log(stringConcat);
}
aggregate([1, 2, 3]);