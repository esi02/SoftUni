function sorting(input) {
  let products = [];

  for (const product of input) {
    let object = product.split(" : ");
    let obj = {
      name: object[0],
      price: Number(object[1]),
    };
    products.push(obj);
  }

  products.sort(function (a, b) {
    var nameA = a.name.toUpperCase();
    var nameB = b.name.toUpperCase();
    if (nameA < nameB) {
      return -1;
    }
    if (nameA > nameB) {
      return 1;
    }
    return 0;
  });
  for (let i = 0; i < products.length; i == 0) {
    let firstInitial = products[i].name[0];
    console.log(firstInitial);

    let filtered = products.filter((x) => x.name[0] == firstInitial);
    filtered.forEach((x) => {
      console.log(`  ${x.name}: ${x.price}`);
    });

    products.splice(i, filtered.length);
  }
}
sorting([
  "Appricot : 20.4",
  "Fridge : 1500",
  "TV : 1499",
  "Deodorant : 10",
  "Boiler : 300",
  "Apple : 1.25",
  "Anti-Bug Spray : 15",
  "T-Shirt : 10",
]);
