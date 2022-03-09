function solution() {
  let ingredients = {
    carbohydrate: 0,
    protein: 0,
    fat: 0,
    flavour: 0,
  };
  return function (input) {
    let commands = input.split(" ");
    let command = commands[0];
    let result = '';
    if (command == "restock") {
      let ingredient = commands[1];
      let quantity = Number(commands[2]);
      result = restock(ingredient, quantity);
    } else if (command == "prepare") {
      let meal = commands[1];
      let quantity = Number(commands[2]);
      result = prepare(meal, quantity);
    } else if (command == "report") {
      result = report();
    }
    return result;
  };
  function restock(ingredient, quantity) {
    ingredients[ingredient] += quantity;
    return "Success";
  }
  function prepare(meal, quantity) {
    for (let i = 0; i < quantity; i++) {
      switch (meal) {
        case "apple":
          if (ingredients.carbohydrate - 1 < 0) {
            return "Error: not enough carbohydrate in stock";
          } else if (ingredients.flavour - 2 < 0) {
            return "Error: not enough flavour in stock";
          } else {
            ingredients.carbohydrate -= 1;
            ingredients.flavour -= 2;
            return "Success";
          }
        case "lemonade":
          if (ingredients.carbohydrate - 10 < 0) {
            return "Error: not enough carbohydrate in stock";
          } else if (ingredients.flavour - 20 < 0) {
            return "Error: not enough flavour in stock";
          } else {
            ingredients.carbohydrate -= 10;
            ingredients.flavour -= 20;
            return "Success";
          }
        case "burger":
          if (ingredients.carbohydrate - 5 < 0) {
            return "Error: not enough carbohydrate in stock";
          } else if (ingredients.fat - 7 < 0) {
            return "Error: not enough fat in stock";
          } else if (ingredients.flavour - 3 < 0) {
            return "Error: not enough flavour in stock";
          } else {
            ingredients.carbohydrate -= 5;
            ingredients.flavour -= 3;
            ingredients.fat -= 7;
            return "Success";
          }
        case "eggs":
          if (ingredients.protein - 5 < 0) {
            return "Error: not enough protein in stock";
          } else if (ingredients.fat - 1 < 0) {
            return "Error: not enough fat in stock";
          } else if (ingredients.flavour - 1 < 0) {
            return "Error: not enough flavour in stock";
          } else {
            ingredients.protein -= 5;
            ingredients.fat -= 1;
            ingredients.flavour -= 1;
            return "Success";
          }
        case "turkey":
          if (ingredients.protein - 10 < 0) {
            return "Error: not enough protein in stock";
          } else if (ingredients.carbohydrate - 10 < 0) {
            return "Error: not enough carbohydrate in stock";
          } else if (ingredients.fat - 10 < 0) {
            return "Error: not enough fat in stock";
          } else if (ingredients.flavour - 10 < 0) {
            return "Error: not enough flavour in stock";
          } else {
            ingredients.protein -= 10;
            ingredients.carbohydrate -= 10;
            ingredients.fat -= 10;
            ingredients.flavour -= 10;
            return "Success";
          }
      }
    }
  }
  
  function report() {
    let str = "";
    str += `protein=${ingredients.protein} `;
    str += `carbohydrate=${ingredients.carbohydrate} `;
    str += `fat=${ingredients.fat} `;
    str += `flavour=${ingredients.flavour}`;
    return str;
  }
}

let manager = solution();
console.log(manager("restock flavour 50")); // Success
console.log(manager("prepare lemonade 4")); // Error: not enough carbohydrate in stock
console.log(manager("restock carbohydrate 10"));
console.log(manager("restock flavour 10"));
console.log(manager("prepare apple 1"));
console.log(manager("restock fat 10"));
console.log(manager("prepare burger 1"));
console.log(manager("report"));
