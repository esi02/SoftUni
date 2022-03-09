function homeFunctionality() {
    let logoutButton = document.getElementById("logout");
    let loginButton = document.getElementById('login');
    let registerButton = document.getElementById('register');
    let loadButton = document.querySelector('.load');

    let catches = document.getElementById('catches');
    let navigation = document.querySelector('.email').querySelector('span');
    let legend = document.querySelectorAll('legend')[0];

    let currentToken = sessionStorage.getItem('accessToken');
    let currentUserId = sessionStorage.getItem('userId');
    let addForm = document.getElementById('addForm');
    let addButton = addForm.querySelector('button');

    getAllCatches().then(result => catches = result);
    catches.style.display = 'none';
    legend.textContent = 'Click to load catches';

    loadButton.addEventListener('click', () => {
        catches.style.display = 'block';
        legend.textContent = 'Catches';
    });

    if (!currentToken || currentToken == null) {
        logoutButton.style.display = 'none';
    } else {
        logoutButton.addEventListener('click', () => {
            fetch(`http://localhost:3030/users/logout`, {
                method: 'GET',
                headers: { 'X-Authorization': `${currentToken}` }
            });

            navigation.textContent = 'guest';
            sessionStorage.clear();
            location.href = "index.html";
        });

        fetch(`http://localhost:3030/users/me`, {
            method: 'GET',
            headers: { 'X-Authorization': `${currentToken}` }
        })
            .then(res => res.json())
            .then(user => navigation.textContent = user.email);

        loginButton.style.display = 'none';
        registerButton.style.display = 'none';

        addButton.disabled = false;
        addButton.addEventListener('click', (e) => {
            e.preventDefault();
            fetch(`http://localhost:3030/data/catches`, {
                method: "POST",
                headers: { 'X-Authorization': `${currentToken}` },
                body: JSON.stringify({
                    angler: addForm.querySelector('input').value,
                    weight: addForm.querySelectorAll('input')[1].value,
                    species: addForm.querySelectorAll('input')[2].value,
                    location: addForm.querySelectorAll('input')[3].value,
                    bait: addForm.querySelectorAll('input')[4].value,
                    captureTime: addForm.querySelectorAll('input')[5].value
                })
            });

            addForm.querySelector('input').value = '';
            addForm.querySelectorAll('input')[1].value = '';
            addForm.querySelectorAll('input')[2].value = '';
            addForm.querySelectorAll('input')[3].value = '';
            addForm.querySelectorAll('input')[4].value = '';
            addForm.querySelectorAll('input')[5].value = '';
            
            //update list dynamically when adding new catch
            getAllCatches().then(result => catches = result);
        });
    }


    async function getAllCatches() {
        let res = await fetch(`http://localhost:3030/data/catches`);
        let response = await res.json();
        catches.innerHTML = '';

        Object.values(response).forEach(currentCatch => {
            let catchDiv = document.createElement('div');
            catchDiv.classList.add('catch');

            if (!currentToken || currentToken == null) {
                catchDiv.innerHTML = `<label>Angler</label>
                    <input type="text" class="angler" value="${currentCatch.angler}" disabled>
                    <label>Weight</label>
                    <input type="text" class="weight" value="${currentCatch.weight}" disabled>
                    <label>Species</label>
                    <input type="text" class="species" value="${currentCatch.species}" disabled>
                    <label>Location</label>
                    <input type="text" class="location" value="${currentCatch.location}" disabled>
                    <label>Bait</label>
                    <input type="text" class="bait" value="${currentCatch.bait}" disabled>
                    <label>Capture Time</label>
                    <input type="number" class="captureTime" value="${currentCatch.captureTime}" disabled>
                    <button class="update" data-id="${currentCatch._id}" disabled>Update</button>
                    <button class="delete" data-id="${currentCatch._id}" disabled>Delete</button>`;
            } else {
                catchDiv.innerHTML = `<label>Angler</label>
                    <input type="text" class="angler" value="${currentCatch.angler}">
                    <label>Weight</label>
                    <input type="text" class="weight" value="${currentCatch.weight}">
                    <label>Species</label>
                    <input type="text" class="species" value="${currentCatch.species}">
                    <label>Location</label>
                    <input type="text" class="location" value="${currentCatch.location}">
                    <label>Bait</label>
                    <input type="text" class="bait" value="${currentCatch.bait}">
                    <label>Capture Time</label>
                    <input type="number" class="captureTime" value="${currentCatch.captureTime}">
                    <button class="update" data-id="${currentCatch._id}">Update</button>
                    <button class="delete" data-id="${currentCatch._id}">Delete</button>`;
            }

            let updateButton = catchDiv.querySelector('button');
            let deleteButton = catchDiv.querySelectorAll('button')[1];

            if (currentUserId == currentCatch._ownerId) {
                updateButton.addEventListener('click', () => {
                    fetch(`http://localhost:3030/data/catches/${currentCatch._id}`, {
                        method: 'PUT',
                        headers: { 'X-Authorization': `${currentToken}` },
                        body: JSON.stringify({
                            angler: catchDiv.querySelector('input').value,
                            weight: catchDiv.querySelectorAll('input')[1].value,
                            species: catchDiv.querySelectorAll('input')[2].value,
                            location: catchDiv.querySelectorAll('input')[3].value,
                            bait: catchDiv.querySelectorAll('input')[4].value,
                            captureTime: catchDiv.querySelectorAll('input')[5].value
                        })
                    });
                    alert('Successfuly updated!');
                });

                deleteButton.addEventListener('click', () => {
                    fetch(`http://localhost:3030/data/catches/${currentCatch._id}`, {
                        method: 'DELETE',
                        headers: { 'X-Authorization': `${currentToken}` }
                    });
                    catches.removeChild(catchDiv);
                });
            } else {
                updateButton.disabled = true;
                deleteButton.disabled = true;
            }
            catches.appendChild(catchDiv);
        });
        return catches;
    }
}


homeFunctionality();