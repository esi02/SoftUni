window.addEventListener('load', solve);

function solve() {
    let modelInputElement = document.getElementById('model');
    let yearInputElement = document.getElementById('year');
    let descriptionInputElement = document.getElementById('description');
    let priceInputElement = document.getElementById('price');
    let addButtonElement = document.getElementById('add');

    addButtonElement.addEventListener('click', (e) => {
        e.preventDefault();

        let furnitureListElement = document.getElementById('furniture-list');
        let rowElement = document.createElement('tr');
        rowElement.classList.add('info');

        let modelElement = document.createElement('td');
        modelElement.textContent = modelInputElement.value;
        let priceElement = document.createElement('td');
        priceElement.textContent = Number(priceInputElement.value).toFixed(2);
        let buttonsElement = document.createElement('td');
        let moreInfoButtonElement = document.createElement('button');
        moreInfoButtonElement.classList.add('moreBtn');
        moreInfoButtonElement.textContent = 'More Info';
        let buyButtonElement = document.createElement('button');
        buyButtonElement.textContent = 'Buy it';
        buyButtonElement.classList.add('buyBtn');
        buttonsElement.appendChild(moreInfoButtonElement);
        buttonsElement.appendChild(buyButtonElement);

        rowElement.appendChild(modelElement);
        rowElement.appendChild(priceElement);
        rowElement.appendChild(buttonsElement);

        furnitureListElement.appendChild(rowElement);

        let hiddenRowElement = document.createElement('tr');
        hiddenRowElement.classList.add('hide');
        let yearElement = document.createElement('td');
        yearElement.textContent = `Year: ${yearInputElement.value}`;
        let descriptionElement = document.createElement('td');
        descriptionElement.setAttribute('colspan', 3);
        descriptionElement.textContent = `Description: ${descriptionInputElement.value}`;

        hiddenRowElement.appendChild(yearElement);
        hiddenRowElement.appendChild(descriptionElement);
        furnitureListElement.appendChild(hiddenRowElement);

        moreInfoButtonElement.addEventListener('click', () => {
            if (moreInfoButtonElement.textContent == 'More Info') {
                moreInfoButtonElement.textContent = 'Less Info';
                hiddenRowElement.style.display = 'contents';
            } else {
                moreInfoButtonElement.textContent = 'More Info';
                hiddenRowElement.style.display = 'none';
            }
        });

        buyButtonElement.addEventListener('click', () => {
            furnitureListElement.removeChild(rowElement);
            furnitureListElement.removeChild(hiddenRowElement);
            let totalPriceElement = document.querySelector('.total-price');
            let totalPrice = (Number(totalPriceElement.textContent) + Number(priceElement.textContent)).toFixed(2);
            totalPriceElement.textContent = totalPrice;
        });

        modelInputElement.value = '';
        yearInputElement.value = '';
        descriptionInputElement.value = '';
        priceInputElement.value = '';
    });
}
