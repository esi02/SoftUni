function extract(arr) {
    let biggestNumber = Math.max();
    let newArr = [];
    for (let i = 0; i < arr.length; i++) {
        if(arr[i] >= biggestNumber) {
            biggestNumber = arr[i];
            newArr.push(arr[i]);
        } else {
            continue;
        }
    }
    return newArr;
}
console.log(extract([20, 
    3, 
    2, 
    15,
    6, 
    1]
       
    ));