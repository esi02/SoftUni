function rotate(arr, rotationCount) {
    for (let i = 1; i <= rotationCount; i++) {
        let lastElement = arr.pop();
        arr.unshift(lastElement);
    }
    console.log(arr.join(' '));
}
rotate(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
);