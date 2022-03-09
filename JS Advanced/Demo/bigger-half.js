function sort(input) {
    input.sort((a, b) => a - b);
    let middleIndex = input.length / 2;
    let biggerHalf = input.slice(middleIndex);

    return biggerHalf;
}
sort([3, 19, 14, 7, 2, 19, 6]);