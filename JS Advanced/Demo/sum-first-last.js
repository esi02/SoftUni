function sum(input) {
        let firstElement = input.shift();
        let lastElement = input.pop();

        let sum = Number(firstElement) + Number(lastElement);
        return sum;
}
console.log(sum(['5', '10']));