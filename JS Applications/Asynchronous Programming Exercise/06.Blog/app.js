function attachEvents() {
    let viewButton = document.getElementById("btnViewPost");
    let loadButton = document.getElementById("btnLoadPosts");

    let posts = document.getElementById("posts");
    let postsUrl = `http://localhost:3030/jsonstore/blog/posts`;
    let commentsUrl = `http://localhost:3030/jsonstore/blog/comments`;

    let postTitle = document.getElementById("post-title");
    let postContent = document.getElementById('post-body');
    let postComments = document.getElementById('post-comments');

    loadButton.addEventListener("click", () => {
        fetch(postsUrl)
            .then((res) => res.json())
            .then((data) => {
                Object.values(data).forEach((post) => {
                    let option = document.createElement("option");
                    option.setAttribute("value", post.id);
                    option.textContent = post.title.toUpperCase();

                    posts.appendChild(option);
                });
            })
            .catch(() => console.log("Error"));
    });

    viewButton.addEventListener("click", () => {
        postComments.innerHTML = '';

        fetch(commentsUrl)
            .then((res) => res.json())
            .then((data) => {
                let postId = posts.options[posts.selectedIndex].value;
                postTitle.textContent = posts.options[posts.selectedIndex].textContent;
                let currentPostComment = Object.values(data).find((x) => x.postId == postId);

                fetch(`http://localhost:3030/jsonstore/blog/posts/${postId}`)
                    .then((res) => res.json())
                    .then((post) => {
                        postContent.textContent = post.body;
                    })
                    .catch(() => console.log("Error"));

                let li = document.createElement('li');
                li.textContent = currentPostComment.text;
                li.setAttribute('id', currentPostComment.id);

                postComments.appendChild(li);
            })
            .catch(() => console.log("Error"));
    });
}

attachEvents();