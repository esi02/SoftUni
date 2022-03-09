function encodeAndDecodeMessages() {
    let encodeButtonElement = document.querySelector('button');
    let decodeButtonElement = document.querySelectorAll('button')[1];
    
    let firstTextArea = document.querySelectorAll('textarea')[0];
    let secondTextArea = document.querySelectorAll('textarea')[1];

    function encodeButtonHandler() {
        let arr = firstTextArea.value;
        let result = '';
        for (let i = 0; i < arr.length; i++) {
            result += String.fromCharCode(arr.charCodeAt(i) + 1);
        }
        firstTextArea.value = '';
        secondTextArea.value = result;
    }; 

    function decodeButtonHandler() {
        let arr = secondTextArea.value;
        let result = '';
        for (let i = 0; i < arr.length; i++) {
            result += String.fromCodePoint(arr.charCodeAt(i) - 1);
        }
        secondTextArea.value = result;
    }

    encodeButtonElement.addEventListener('click', encodeButtonHandler);
    decodeButtonElement.addEventListener('click', decodeButtonHandler);
}