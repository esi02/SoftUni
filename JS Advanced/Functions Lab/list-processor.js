function solve(input) {
  let result = [];
  for (const element of input) {
    let command = element.split(" ")[0];
    let string = element.split(" ")[1];

    if (command == "add") {
      add(string);
    } else if (command == "remove") {
      remove(string);
    } else {
      print();
    }
  }

  function add(str) {
    result.push(str);
  }

  function remove(str) {
    for (const el of result) {
      if (el == str) {
        let index = result.indexOf(el);
        result.splice(index, 1);
      }
    }
  }

  function print() {
    console.log(result.join(","));
  }
}

solve(["add hello", "add again", "remove hello", "add again", "print"]);
