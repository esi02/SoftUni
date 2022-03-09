function sort(nums) {
    let originalLength = nums.length;
    nums.sort((a, b) => a - b);
    let smallNums = nums.splice(0, nums.length / 2);
    let bigNums = nums;

    bigNums.sort((a, b) => b - a);
    smallNums.sort((a, b) => a - b);

    let arr = [];
    let count = 0;
    for (let i = 0; i < originalLength; i++) {
        if(i < smallNums.length) {
            arr.push(smallNums[i]);
        }
        if(i < bigNums.length) {
            arr.push(bigNums[i]);
        }
    }
    return arr;
}
console.log(sort([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));