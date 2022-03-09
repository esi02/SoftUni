function attachEvents() {
    let author = document.querySelector('input');
    let content = document.querySelectorAll('input')[1];
    let submitButton = document.getElementById('submit');
    let refreshButton = document.getElementById('refresh');
    let textArea = document.querySelector('textarea');

    let url =  `http://localhost:3030/jsonstore/messenger`;

    submitButton.addEventListener('click', () => {
        fetch(url, {
            method: 'POST',
            headers: {'Content-Type': 'application/json'},
            body: JSON.stringify({
                author: author.value,
                content: content.value
            })
        });
        author.value = '';
        content.value = '';
    });

    refreshButton.addEventListener('click', () => {
        fetch(url)
        .then(res => res.json())
        .then(messages => {
            let arr = [];
            Object.values(messages).forEach(message => {
                if (message.author && message.content) {
                    arr.push(`${message.author}: ${message.content}`);
                }
            });
            textArea.textContent = arr.join('\n');
        });

        author.value = '';
        content.value = '';
    });
}

attachEvents();