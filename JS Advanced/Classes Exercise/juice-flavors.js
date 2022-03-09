function juiceFactory(juicesAsArr) {
    let juiceBottles = new Map();
    let arrOfObjects = new Map();

    for (const juice of juicesAsArr) {
        let juiceFlavor = juice.split(' => ')[0];
        let juiceQuantity = Number(juice.split(' => ')[1]);

        if (arrOfObjects.has(juiceFlavor)) {
            let newQuantity = arrOfObjects.get(juiceFlavor) + juiceQuantity;
           arrOfObjects.set(juiceFlavor, newQuantity);
        } else {
            arrOfObjects.set(juiceFlavor, juiceQuantity);
        }
        
        if (arrOfObjects.get(juiceFlavor) >= 1000) {
            while (arrOfObjects.get(juiceFlavor) >= 1000) {
                let newQuantity = arrOfObjects.get(juiceFlavor) - 1000;
                arrOfObjects.set(juiceFlavor, newQuantity);
                if (juiceBottles.has(juiceFlavor)) {
                    let newBottleQuantity = juiceBottles.get(juiceFlavor) + 1;
                    juiceBottles.set(juiceFlavor, newBottleQuantity);
                } else {
                    juiceBottles.set(juiceFlavor, 1);
                }
            }
        }
    }
    let result = '';

    for (const [key, value] of juiceBottles) {
        result += `${key} => ${value}` + '\n';
    }
    return console.log(result);
}

juiceFactory(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789']

);