function smallest(input) {
    input.sort((a, b) => a - b);
    input.splice(2, input.length);
    console.log(input.join(' '));
}
smallest([3, 0, 10, 4, 7, 3]);