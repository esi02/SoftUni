class Restaurant {
    menu = [];
    stockProducts = [];
    history = [];
    constructor(budgetMoney) {
        this.budgetMoney = budgetMoney;
    }

    loadProducts(products) {
        for (const product of products) {
            let splitted = product.split(' ');
            let productName = splitted[0];
            let quantity = Number(splitted[1]);
            let totalPrice = Number(splitted[2]);

            if (totalPrice <= budgetMoney) {
                this.budgetMoney -= totalPrice;
                let element = this.stockProducts.find(x => x.productName == productName);
                if (element != undefined) {
                    element.quantity += quantity;
                } else {
                    this.stockProducts.push({
                        productName,
                        quantity
                    });

                }
                this.history.push(`Successfully loaded ${quantity} ${productName}`);
            } else {
                this.history.push(`There was not enough money to load ${quantity} ${productName}`);
            }
        }
        return this.history.join('\n');
    }
    addToMenu(meal, neededProducts, price) {
        let mealElement = this.menu.find(x => x.meal == meal);
        if (mealElement != undefined) {

        } else {
            this.menu.push({
                meal,
                products: neededProducts,
                price
            });
        }
    }
}