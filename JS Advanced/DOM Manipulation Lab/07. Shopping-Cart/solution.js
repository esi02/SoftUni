function solve() {
   let breadElement = document.getElementsByClassName('product')[0];
   let milkElement = document.getElementsByClassName('product')[1];
   let tomatoesElement = document.getElementsByClassName('product')[2];
   let checkoutElement = document.getElementsByClassName('checkout')[0];

   let textArea = document.getElementsByTagName('textarea')[0];
   let breadAddButton = breadElement.querySelector('.add-product');
   let milkAddButton = milkElement.querySelector('.add-product');
   let tomatoesAddButton = tomatoesElement.querySelector('.add-product');

   let totalMoney = 0;
   let listOfProductNames = [];

   breadAddButton.addEventListener('click', (e) => {
      let breadTitle = breadElement.querySelector('.product-title').textContent;
      let breadPrice = Number(breadElement.querySelector('.product-line-price').textContent);
      textArea.value += `Added ${breadTitle} for ${breadPrice.toFixed(2)} to the cart.\n`;
      console.log(breadPrice);
      if (listOfProductNames.find(x => x == breadTitle) === undefined) {
         listOfProductNames.push(breadTitle);
      }
      totalMoney += breadPrice;
   });

   milkAddButton.addEventListener('click', (e) => {
      let milkTitle = milkElement.querySelector('.product-title').textContent;
      let milkPrice = Number(milkElement.querySelector('.product-line-price').textContent);
      textArea.value += `Added ${milkTitle} for ${milkPrice.toFixed(2)} to the cart.\n`;

      if (listOfProductNames.find(x => x == milkTitle) === undefined) {
         listOfProductNames.push(milkTitle);
      }
      totalMoney += milkTitle;
   });
   tomatoesAddButton.addEventListener('click', (e) => {

      let tomatoesTitle = tomatoesElement.querySelector('.product-title').textContent;
      let tomatoesPrice = Number(tomatoesElement.querySelector('.product-line-price').textContent);
      textArea.value += `Added ${tomatoesTitle} for ${tomatoesPrice.toFixed(2)} to the cart.\n`;

      if (listOfProductNames.find(x => x == tomatoesTitle) === undefined) {
         listOfProductNames.push(tomatoesTitle);
      }
      totalMoney += tomatoesPrice;
   });

   checkoutElement.addEventListener('click', (e) => {
      textArea.value += `You bought ${listOfProductNames.join(', ')} for ${Math.round(totalMoney)}.`
      e.stopImmediatePropagation();
   });
}