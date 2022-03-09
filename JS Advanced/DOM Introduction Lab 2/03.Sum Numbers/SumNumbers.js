function calc() {
    let firstNumElement = document.getElementById("num1");
    let secondNumElement = document.getElementById("num2");
    let sumElement = document.getElementById("sum");

    let sum = Number(firstNumElement.value) + Number(secondNumElement.value);
    sumElement.value = sum;
}
