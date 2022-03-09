function extract(content) {
        let textElement = document.getElementById(content);
        let extractedText = Array.from(textElement.textContent.matchAll(/\([A-Za-z\s]+\)/gm));

        let textAsArr = [];
        extractedText.forEach(x => {
            let stringElement = x[0].replace('(', '').replace(')', '');
            textAsArr.push(stringElement);
        });
        
        return textAsArr.join('; ');
}