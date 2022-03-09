function addAndRemove(commandArr) {
    let numArray = [];
    let currentNum = 1;
    for (let i = 0; i < commandArr.length; i++) {
        if(commandArr[i] == 'add') {
            numArray.push(currentNum);
        } else {
            numArray.pop(currentNum);
        }
        currentNum++;
    }
    if (numArray.length == 0) {
        console.log('Empty');
    } else {
        console.log(numArray.join('\n'));
    }
}
addAndRemove(['remove', 
'remove', 
'remove']

);