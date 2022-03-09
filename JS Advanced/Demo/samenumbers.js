function isSame(input) {
    let num = input.toString();
    let result = true;
    for (let i = 0; i < num.length - 1; i++) {
        for (let j = i++; j < num.length; j++) {
            if (num[i] !== num[j]) {
                result = false;
            }
        }
    }
    let sum = 0;
    for (let index = 0; index < num.length; index++) {
        let currentNum = Number(num[index]);
        sum += currentNum;
    }
    console.log(result);
    console.log(sum);
}