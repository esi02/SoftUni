function sort(names) {
    names.sort((a, b) => a.localeCompare(b));
    let count = 1;
    for (let i = 0; i < names.length; i++) {
        console.log(`${count}.${names[i]}`);
        count++;
    }
}
sort(["John", "Bob", "Christina", "Ema"]);