function sumRange(numsArray, startIndex, endIndex) {
    if (!Array.isArray(numsArray)) {
        return NaN; 
    }

    startIndex = Math.max(startIndex, 0);
    endIndex = Math.min(endIndex, numsArray.length - 1);

    let sum = 0;
    if (numsArray.length > 0) {
        sum = Number(numsArray.slice(startIndex, endIndex + 1)
                                .reduce((a, b) => a + b));
        
    }
    return sum;
}

console.log(sumRange([], 1, 2));