function findEven(input) {
    let arr = [];
    for (let i = 0; i < input.length; i++) {
        if(i % 2 == 0) {
            arr.push(input[i]);
        }
    }
    console.log(arr.join(' '));
}
findEven(['5', '10']);