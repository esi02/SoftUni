function extractText() {
    let getListElements = document.getElementById('items');
    let listContent = getListElements.textContent;
    let getTextElement = document.getElementById('result');
    getTextElement.textContent = listContent;
}