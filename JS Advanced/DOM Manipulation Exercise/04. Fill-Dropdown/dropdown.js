function addItem() {
    let textInputElement = document.getElementById('newItemText');
    let valueInputElement = document.getElementById('newItemValue');

    let optionElement = document.createElement('option');
    optionElement.textContent = textInputElement.value;
    optionElement.value = valueInputElement.value;

    let menuElement = document.getElementById('menu');
    menuElement.appendChild(optionElement);

    textInputElement.value = '';
    valueInputElement.value = '';
}