function sumTable() {
    let pricesTableElements = document.querySelectorAll('tr td:nth-of-type(2)');

    let pricesAsArr = [];
    for (const price of pricesTableElements) {
        if (price.textContent != '') {
            pricesAsArr.push(Number(price.textContent));
        }
    }
    let sum = pricesAsArr.reduce((a, b) => a + b);
    
    let sumElement = document.getElementById('sum');
    sumElement.textContent = sum.toString();
}