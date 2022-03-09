function findPrice(input) {
  let towns = [];

  for (const town of input) {
    let splitted = town.split(" | ");
    let obj = {
      city: splitted[0],
      product: splitted[1],
      price: Number(splitted[2]),
    };
    towns.push(obj);
  }

  for (const product of towns) {
    let sameProducts = towns.filter((x) => x.product == product.product);

    if (sameProducts.length == 1) {
      continue;
    }
    let firstProduct = sameProducts[0];
    let secondProduct = sameProducts[1];

    if (firstProduct.price < secondProduct.price) {
      let index = towns.indexOf(secondProduct);
      towns.splice(index, 1);
    } else if (firstProduct.price > secondProduct.price) {
      let index = towns.indexOf(firstProduct);
      towns.splice(index, 1);
    } else if(firstProduct.price == secondProduct.price) {
        let firstIndex = towns.indexOf(firstProduct);
        let secondIndex = towns.indexOf(secondProduct);

        if (firstIndex < secondIndex) {
            towns.splice(secondIndex, 1);
        } else {
            towns.splice(firstIndex, 1);
        }
    }
  }

  for (const town of towns) {
    console.log(`${town.product} -> ${town.price} (${town.city})`);
  }
}
findPrice([
  "Sample Town | Sample Product | 1000",
  "Sample Town | Orange | 2",
  "Sample Town | Peach | 1",
  "Sofia | Orange | 3",
  "Sofia | Peach | 2",
  "New York | Sample Product | 1000.1",
  "New York | Burger | 10",
]);
