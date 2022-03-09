function colorize() {
    let tableElements = document.getElementsByTagName('tr');
    let tableArr = Array.from(tableElements);
    tableArr.forEach((x, i) => {
        if (i % 2 != 0) {
            x.style.backgroundColor = "teal";
        }
    });
}