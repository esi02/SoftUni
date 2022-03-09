function solve() {
      let textAreaElement = document.querySelector('textarea');
      let generateButton = document.querySelector('button');
     
      function handler() {
        //Parse from JSON
        let results = JSON.parse(textAreaElement.value);

        for (const result of results) {
          let rowElement = document.querySelector('tbody');
          let newTrElement = document.createElement('tr');

          let imageElement = document.createElement('td');
          imageElement.innerHTML = `<img src="${result.img}">`;
          newTrElement.appendChild(imageElement);
          
          let nameTable = document.createElement('td');
          let paragraph = document.createElement('p');
          paragraph.textContent = result.name;
          nameTable.appendChild(paragraph);
          newTrElement.appendChild(nameTable);

          let priceTable = document.createElement('td');
          let p = document.createElement('p');
          p.textContent = Number(result.price);
          priceTable.appendChild(p);
          newTrElement.appendChild(priceTable);

          let decorationTable = document.createElement('td');
          let p1 = document.createElement('p');
          p1.textContent = Number(result.decFactor);
          decorationTable.appendChild(p1);
          newTrElement.appendChild(decorationTable);

          let markTable = document.createElement('td');
          let inputElement = document.createElement('input');
          inputElement.setAttribute('type', 'checkbox');
          markTable.appendChild(inputElement);
          newTrElement.appendChild(markTable);

          rowElement.appendChild(newTrElement);
        }
      };

      generateButton.addEventListener('click', handler);

      let buyButton = document.querySelectorAll('button')[1];
      let checkedFurniture = [];
      let totalPrice = 0;
      let decorationFactor = 0;
      let count = 0;

      function buyHandler() {
        
      }
      
}