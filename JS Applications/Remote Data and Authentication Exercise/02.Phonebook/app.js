function attachEvents() {
    let loadButton = document.getElementById('btnLoad');
    let phonebook = document.getElementById('phonebook');
    let person = document.getElementById('person');
    let phone = document.getElementById('phone');
    let createButton = document.getElementById('btnCreate');

    let url = `http://localhost:3030/jsonstore/phonebook`;

    loadButton.addEventListener('click', () => {
        phonebook.innerHTML = '';

        fetch(url)
        .then(res => res.json())
        .then(phones => {
            Object.values(phones).forEach(phone => {
                let li = document.createElement('li');
                let deleteButton = document.createElement('button');
                deleteButton.textContent = 'Delete';
                
                li.textContent = `${phone.person}: ${phone.phone}`;
                li.appendChild(deleteButton);
                phonebook.appendChild(li);

                deleteButton.addEventListener('click', () => {
                    fetch(`${url}/${phone._id}`, {
                        method: 'DELETE'
                    });
                    phonebook.removeChild(li);
                });
            });
        });
    });

    createButton.addEventListener('click', () => {
        fetch(url, {
            method: 'POST',
            headers: {'content-type': 'application/json'},
            body: JSON.stringify({
                person: person.value,
                phone: phone.value
            })
        });

        person.value = '';
        phone.value = '';
        loadButton.click();
    });

}

attachEvents();