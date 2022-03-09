function sort(input) {
    let arr = [];
    for (let i = 0; i < input.length; i++) {
        if(input[i] < 0) {
            arr.unshift(input[i]);
        } else {
            arr.push(input[i]);
        }
    }
    console.log(arr.join('\n'));
}
sort([3, -2, 0, -1]);