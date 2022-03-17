import { ideasHolder, renderIdeaDetails } from "./renderViews.js";

export function attachAllIdeas(ideas) {
    ideasHolder.innerHTML = '';
    Object.values(ideas).forEach(idea => {
        let div = document.createElement('div');
        div.classList.add('card', 'overflow-hidden', 'current-card', 'details');
        div.style.cssText = "width: 20rem; height: 18rem";

        div.innerHTML = `<div class="card-body">
        <p class="card-text">${idea.title}</p>
    </div>
    <img class="card-image" src="${idea.img}" alt="Card image cap">
    <a class="btn" href="">Details</a>`;

    div.querySelector('.btn').addEventListener('click', (e) => {
        e.preventDefault();
        renderIdeaDetails(idea._id);
    })
        ideasHolder.appendChild(div);
    });
}