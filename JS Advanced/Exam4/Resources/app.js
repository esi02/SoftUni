window.addEventListener('load', solve);

function solve() {
    let dropDownMenuElement = document.getElementById('type-product');
    let descriptionInputElement = document.getElementById('description');
    let clientInputElement = document.getElementById('client-name');
    let clientNumberInputElement = document.getElementById('client-phone');
    let sendFormButtonElement = document.querySelector('button');

    let receivedOrdersElement = document.getElementById('received-orders');
    let completedOrdersElement = document.getElementById('completed-orders');
    let clearButtonElement = document.querySelector('.clear-btn');


    sendFormButtonElement.addEventListener('click', (e) => {
        e.preventDefault();

        if (descriptionInputElement.value == '' ||
            clientInputElement.value == '' ||
            clientNumberInputElement.value == '') {
            return;
        }
        let divElement = document.createElement('div');
        divElement.classList.add('container');

        let productForRepairElement = document.createElement('h2');
        productForRepairElement.textContent = `Product type for repair: ${dropDownMenuElement.value}`;

        let clientInformationElement = document.createElement('h3');
        clientInformationElement.textContent = `Client information: ${clientInputElement.value}, ${clientNumberInputElement.value}`;

        let descriptionElement = document.createElement('h4');
        descriptionElement.textContent = `Description of the problem: ${descriptionInputElement.value}`;

        let startRepairButtonElement = document.createElement('button');
        startRepairButtonElement.textContent = 'Start repair';
        startRepairButtonElement.classList.add('start-btn');

        let finishRepairButtonElement = document.createElement('button');
        finishRepairButtonElement.textContent = 'Finish repair';
        finishRepairButtonElement.classList.add('finish-btn');
        finishRepairButtonElement.disabled = true;

        divElement.appendChild(productForRepairElement);
        divElement.appendChild(clientInformationElement);
        divElement.appendChild(descriptionElement);
        divElement.appendChild(startRepairButtonElement);
        divElement.appendChild(finishRepairButtonElement);

        startRepairButtonElement.addEventListener('click', () => {
            startRepairButtonElement.disabled = true;
            finishRepairButtonElement.disabled = false;
        });

        finishRepairButtonElement.addEventListener('click', () => {
            receivedOrdersElement.removeChild(divElement);
            divElement.removeChild(startRepairButtonElement);
            divElement.removeChild(finishRepairButtonElement);
            completedOrdersElement.appendChild(divElement);
        });

        receivedOrdersElement.appendChild(divElement);

        descriptionInputElement.value = '';
        clientInputElement.value = '';
        clientNumberInputElement.value = '';
    });

    clearButtonElement.addEventListener('click', () => {
        let allDivElements = completedOrdersElement.querySelectorAll('.container');
        for (const element of allDivElements) {
            completedOrdersElement.removeChild(element);
        }
    });
}