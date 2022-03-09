function process(input) {
    let oddElements = input.filter((num, i) => i % 2 != 0)
                      .map(x => x * 2)
                      .reverse();

    console.log(oddElements.join(' '));
}
process([3, 0, 10, 4, 7, 3]);