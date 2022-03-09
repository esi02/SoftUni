function carCompany(arrOfStrings) {
    let carBrands = new Map();

    for (const element of arrOfStrings) {
        let carBrand = element.split(' | ')[0];
        let carModel = element.split(' | ')[1];
        let producedCars = Number(element.split(' | ')[2]);

        if (carBrands.has(carBrand)) {
            let brandValue = carBrands.get(carBrand);
            if (brandValue.has(carModel)) {
                let newQuantity = brandValue.get(carModel) + producedCars;
                brandValue.set(carModel, newQuantity);
            } else {
                brandValue.set(carModel, producedCars);
            }
        } else {
            //the value is map
            carBrands.set(carBrand, new Map().set(carModel, producedCars));
        }
    }
    let result = '';

    for (const [key, value] of carBrands) {
        result += `${key}` + '\n';
        for (const [key1, value1] of value) {
            result += `###${key1} -> ${value1}` + '\n';
        }
    }
    console.log(result);
}

carCompany(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']
);