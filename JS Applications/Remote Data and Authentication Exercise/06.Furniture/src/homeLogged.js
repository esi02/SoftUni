let logoutUrl = 'http://localhost:3030/users/logout';
let furnitureListUrl = 'http://localhost:3030/data/furniture';
let furnitureList = document.querySelector('tbody');
let catalogButton = document.querySelector('.active');

function homeLogged() {
    let allOrders = document.querySelector('.orders');
    let createForm = document.querySelector('form');

    let createButton = createForm.querySelector('button');
    let logoutButton = document.getElementById('logoutBtn');
    let buyButton = document.querySelectorAll('button')[1];

    let currentToken = sessionStorage.getItem('accessToken');
    let currentId = sessionStorage.getItem('userId');

    logoutButton.addEventListener('click', () => {
        fetch(logoutUrl, {
            method: 'GET',
            headers: { 'X-Authorization': `${currentToken}` }
        });

        sessionStorage.clear();
        location.href = 'home.html';
    });

    catalogButton.style.display = 'none';

    createButton.addEventListener('click', () => {
        let nameInput = createForm.querySelector('input');
        let priceInput = createForm.querySelectorAll('input')[1];
        let factorInput = createForm.querySelectorAll('input')[2];
        let imgInput = createForm.querySelectorAll('input')[3];

        fetch(furnitureListUrl, {
            method: 'POST',
            headers: {
                'X-Authorization': `${currentToken}`,
                'content-type': 'application/json'
            },
            body: JSON.stringify({
                img: imgInput.value,
                name: nameInput.value,
                price: priceInput.value,
                decFactor: factorInput.value
            })
        });

    });

    buyButton.addEventListener('click', () => {
        Array.from(furnitureList.querySelectorAll('input')).forEach(box => {
            if (box.checked == true) {
                let order = box.parentNode.parentNode;
                fetch('http://localhost:3030/data/orders', {
                    method: 'POST',
                    headers: { 'X-Authorization': currentToken },
                    body: JSON.stringify({
                        img: order.querySelector('img').src,
                        name: order.querySelector('p').textContent,
                        price: order.querySelectorAll('p')[1].textContent,
                        decFactor: order.querySelectorAll('p')[2].textContent
                    })
                });
            }
        })
    });

    allOrders.querySelector('button').addEventListener('click', () => {
        let boughtFurniture = allOrders.querySelector('span');
        let priceElement = allOrders.querySelectorAll('span')[1];

        fetch(`http://localhost:3030/data/orders?where=_ownerId%3D"${currentId}"`)
            .then(res => res.json())
            .then(orders => {
                let furniture = [];
                let price = 0;
                Object.values(orders).forEach(order => {
                    furniture.push(order.name);
                    price += Number(order.price);
                });
                boughtFurniture.textContent = furniture.join(', ');
                priceElement.textContent = `${price} $`;
            });
    });

    //Always refresh list
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
        checkboxData.appendChild(checkboxElement);

        row.appendChild(imageData);
        row.appendChild(nameData);
        row.appendChild(priceData);
        row.appendChild(decorationData);
        row.appendChild(checkboxData);

        furnitureList.appendChild(row);
    })
}

homeLogged();