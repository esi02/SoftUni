let topic = localStorage.getItem('topic');
let parsedTopic = JSON.parse(topic);
let commentsUrl = 'http://localhost:3030/jsonstore/collections/myboard/comments';

let themeContainer = document.querySelector('.container');
let themeContent = themeContainer.querySelector('h2');
let divPost = document.querySelector('.comment');

function renderCommentsForTopic() {
    themeContent.textContent = parsedTopic.title;

    divPost.innerHTML = `<div class="header">
<img src="./static/profile.png" alt="avatar">
<p><span>${parsedTopic.username}</span> posted on <time>${parsedTopic.time}</time></p>

<p class="post-content">${parsedTopic.content}</p>
</div>`;

    fetch(commentsUrl)
        .then(res => res.json())
        .then(comments => {
            Object.values(comments).forEach(comment => {
                let commentDiv = document.createElement('div');
                commentDiv.id = 'user-comment';
                commentDiv.innerHTML = `<div class="topic-name-wrapper">
        <div class="topic-name">
            <p><strong>${comment.username}</strong> commented on <time>${comment.time}</time></p>
            <div class="post-content">
                <p>${comment.content}</p>
            </div>
        </div>
    </div>`;
                divPost.appendChild(commentDiv);
            });
        });
}

renderCommentsForTopic();

let postButton = document.querySelector('button');
let commentContent = document.getElementById('comment');
let commentUsername = document.getElementById('username');

postButton.addEventListener('click', (e) => {
    e.preventDefault();

    fetch(commentsUrl, {
        method: 'POST',
        headers: { 'content-type': 'application/json' },
        body: JSON.stringify({
            content: commentContent.value,
            username: commentUsername.value,
            time: `${new Date().toLocaleString()}`
        })
    });

    renderCommentsForTopic();
});


