function rectangle(num) {
    let rows = num;
    let cols = num;
    let result = "";
    if(num == '') {
        rows = 5;
        cols = 5;
    }
    for(let i = 0; i < rows; i++) {
        for(let j = 0; j < cols; j++) {
                result += "*";
                result += " ";
        }
        result += "\n";
    }
    console.log(result);
}