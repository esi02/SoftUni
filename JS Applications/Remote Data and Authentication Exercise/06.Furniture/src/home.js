let furnitureList = document.querySelector('tbody');
let furnitureListUrl = 'http://localhost:3030/data/furniture';

function homePage() {
  fillFurnitureList();
}

async function fillFurnitureList() {
  let res = await fetch(furnitureListUrl);
  let data = await res.json();

  Object.values(data).forEach(furniture => {
    let row = document.createElement('tr');
    let imageData = document.createElement('td');
    let imgElement = document.createElement('img');

    imgElement.src = `${furniture.img}`;
    imageData.appendChild(imgElement);

    let nameData = document.createElement('td');
    let nameParagraph = document.createElement('p');

    nameParagraph.textContent = furniture.name;
    nameData.appendChild(nameParagraph);

    let priceData = document.createElement('td');
    let priceParagraph = document.createElement('p');

    priceParagraph.textContent = furniture.price;
    priceData.appendChild(priceParagraph);

    let decorationData = document.createElement('td');
    let decorationParagraph = document.createElement('p');

    decorationParagraph.textContent = furniture.decFactor;
    decorationData.appendChild(decorationParagraph);

    let checkboxData = document.createElement('td');
    let checkboxElement = document.createElement('input');

    checkboxElement.type = 'checkbox';
    checkboxElement.disabled = true;
    checkboxData.appendChild(checkboxElement);

    row.appendChild(imageData);
    row.appendChild(nameData);
    row.appendChild(priceData);
    row.appendChild(decorationData);
    row.appendChild(checkboxData);

    furnitureList.appendChild(row);
  })
}

homePage();

