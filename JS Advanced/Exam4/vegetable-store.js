class VegetableStore {
    availableProducts = [];
    constructor(owner, location) {
        this.owner = owner;
        this.location = location;
    }
    loadingVegetables(vegetables) {
        let addedTypes = [];
        for (const vegetable of vegetables) {
            let type = vegetable.split(' ')[0];
            let quantity = Number(vegetable.split(' ')[1]);
            let price = Number(vegetable.split(' ')[2]);

            let elementVegetable = this.availableProducts.find(x => x.type == type);

            if (elementVegetable != undefined) {
                elementVegetable.quantity += quantity;
                if (price > elementVegetable.price) {
                    elementVegetable.price = price;
                }
            } else {
                this.availableProducts.push({
                    type,
                    quantity,
                    price
                });
            }
            
            if (!addedTypes.some(x => x == type)) {
                addedTypes.push(type);
            }
        }
        return `Successfully added ${addedTypes.join(', ')}`;
    }
    buyingVegetables(selectedProducts) {
        let totalPrice = 0;
        for (const product of selectedProducts) {
            let type = product.split(' ')[0];
            let quantity = Number(product.split(' ')[1]);

            let availableVegetable = this.availableProducts.find(x => x.type == type);

            if (availableVegetable == undefined) {
                throw new Error(`${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`);
            }

            if (quantity > availableVegetable.quantity) {
                throw new Error(`The quantity ${quantity} for the vegetable ${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`);
            }

            let priceForProduct = availableVegetable.price * quantity;
            availableVegetable.quantity -= quantity;

            totalPrice += priceForProduct;
        }
        return `Great choice! You must pay the following amount $${totalPrice.toFixed(2)}.`;
    }
    rottingVegetable (type, quantity) {
        let vegetable = this.availableProducts.find(x => x.type == type);
        if (vegetable == undefined) {
            throw new Error(`${type} is not available in the store.`);
        }

        if (quantity > vegetable.quantity) {
            vegetable.quantity = 0;
            return `The entire quantity of the ${type} has been removed.`;
        }

        vegetable.quantity -= quantity;

        return `Some quantity of the ${type} has been removed.`;
    }
    revision() {
        let result=[];
        result.push('Available vegetables:');

        this.availableProducts.sort((a, b) => a.price - b.price)
                              .forEach(x => result.push(`${x.type}-${x.quantity}-$${x.price}`));

        result.push(`The owner of the store is ${this.owner}, and the location is ${this.location}.`);

        return result.join('\n');
    }
}

let vegStore = new VegetableStore("Jerrie Munro", "1463 Pette Kyosheta, Sofia");
console.log(vegStore.loadingVegetables(["Okra 2.5 3.5", "Beans 10 2.8", "Celery 5.5 2.2", "Celery 0.5 2.5"]));
console.log(vegStore.rottingVegetable("Okra", 1));
console.log(vegStore.rottingVegetable("Okra", 2.5));
console.log(vegStore.buyingVegetables(["Beans 8", "Celery 1.5"]));
console.log(vegStore.revision());



