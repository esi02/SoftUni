function subtract() {
    let firstNumElement = document.getElementById('firstNumber');
    let secondNumElement = document.getElementById('secondNumber');

    let firstNum = Number(firstNumElement.value);
    let secondNum = Number(secondNumElement.value);

    let result = firstNum - secondNum;

    let sumElement = document.getElementById('result');
    sumElement.textContent = result.toString();
}