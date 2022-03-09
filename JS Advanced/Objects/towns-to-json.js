function solve(input) {
  let towns = [];

  for (let i = 0; i < input.length; i++) {
      if (i == 0) {
          continue;
      }
    let elements = input[i].split(/[\s\|]{2,}/);
    elements = elements.filter((x) => x !== "");

    elements[1] = Number(elements[1]).toFixed(2);
    elements[2] = Number(elements[2]).toFixed(2);
    
    let obj = {};
    obj.Town = elements[0];
    obj.Latitude = Number(elements[1]);
    obj.Longitude = Number(elements[2]);

    towns.push(obj);
  }
  return JSON.stringify(towns);
}

console.log(solve(['| Town | Latitude | Longitude |',
'| Veliko Turnovo | 43.0757 | 25.6172 |',
'| Monatevideo | 34.50 | 56.11 |']
));
