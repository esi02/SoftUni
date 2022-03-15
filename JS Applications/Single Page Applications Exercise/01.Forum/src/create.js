let topicContainer = document.querySelector('.topic-container');
let postsUrl = 'http://localhost:3030/jsonstore/collections/myboard/posts';

let topicNameInput = document.getElementById('topicName');
let usernameInput = document.getElementById('username');
let topicContentInput = document.getElementById('postText');

let cancelButton = document.querySelector('.cancel');
let postButton = document.querySelector('.public');

//Get elements once and add event listeners once
cancelButton.addEventListener('click', (e) => {
    e.preventDefault();

    topicNameInput.value = '';
    usernameInput.value = '';
    topicContentInput.value = '';
});

postButton.addEventListener('click', (e) => {
    e.preventDefault();

    if (topicNameInput.value == '' ||
        usernameInput.value == '' &&
        topicContentInput.value == '') {
        alert('Please fill all fields!');
    } else {
        fetch(postsUrl, {
            method: 'POST',
            headers: { 'content-type': 'application/json' },
            body: JSON.stringify({
                title: topicNameInput.value,
                content: topicContentInput.value,
                username: usernameInput.value,
                time: `${new Date().toLocaleString()}`
            })
        });

        topicNameInput.value = '';
        usernameInput.value = '';
        topicContentInput.value = '';
    }
    //Refresh list of topics after adding
    renderTopics();
});


function renderTopics() {
    topicContainer.innerHTML = '';
    fetch(postsUrl)
        .then(res => res.json())
        .then(topics => {
            Object.values(topics).forEach(topic => {
                let topicNameWrapper = document.createElement('div');
                topicNameWrapper.classList.add('topic-name-wrapper');
                topicNameWrapper.setAttribute('id', `${topic.title}`);

                topicNameWrapper.innerHTML = `<div class="topic-name">
            <a href="theme-content.html" class="normal">
                <h2>${topic.title}</h2>
            </a>
            <div class="columns">
                <div>
                    <p>Date: <time>${new Date().toLocaleString()}</time></p>
                    <div class="nick-name">
                        <p>Username: <span>${topic.username}</span></p>
                    </div>
                </div>
            </div>
        </div>`;

                topicNameWrapper.querySelector('a').addEventListener('click', () => {
                    localStorage.setItem('topic', JSON.stringify(topic));
                })
                topicContainer.appendChild(topicNameWrapper);
            });

        })
}

renderTopics();