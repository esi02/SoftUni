function sort(arr) {
    arr.sort(function (a, b) {
        let result = a.length - b.length;
        if (result != 0) {
            return result;
        } else {
            return a.toLowerCase().localeCompare(b.toLowerCase());
        }
    });
    console.log(arr.join('\n'));
}
sort(['test',
    'Deny',
    'omen',
    'Default']
);