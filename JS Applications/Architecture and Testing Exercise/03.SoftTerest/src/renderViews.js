import { validateRegister } from './register.js';
import { getCreatedIdeas, logoutRequest, getIdeaDetails, deleteIdea } from './requests.js';
import { attachAllIdeas } from './dashboard.js';
import { validateLogin } from './login.js';
import{validateIdea} from './create.js';

export let token = sessionStorage.getItem('accessToken');
let userId = sessionStorage.getItem('userId');
let logoutButton = document.getElementById('logoutBtn');
let createButton = document.getElementById('createBtn');
let loginButton = document.getElementById('loginBtn');
let registerButton = document.getElementById('registerBtn');

let loginForm = document.getElementById('loginForm');
let registerForm = document.getElementById('registerForm');
export let ideasHolder = document.getElementById('dashboard-holder');
let detailsForm = document.getElementById('details');
let shareIdeaForm = document.getElementById('shareIdea');
let getStartedForm = document.getElementById('getStartedForm');

export async function renderHomePage() {
    setUserNavigation();
    await setUserHomePage();
}

function setUserNavigation() {
    if (token == null) {
        logoutButton.style.display = 'none';
        createButton.style.display = 'none';

        loginButton.style.display = 'block';
        registerButton.style.display = 'block';
    } else {
        logoutButton.style.display = 'block';
        createButton.style.display = 'block';

        loginButton.style.display = 'none';
        registerButton.style.display = 'none';
    }
}

async function setUserHomePage() {
    if (token == null) {
        loginForm.style.display = 'none';
        registerForm.style.display = 'none';
        ideasHolder.style.display = 'none';
        detailsForm.style.display = 'none';
        shareIdeaForm.style.display = 'none';
        getStartedForm.style.display = 'block';
    } else {
        loginForm.style.display = 'none';
        registerForm.style.display = 'none';

        let ideas = await getCreatedIdeas();
        let children = ideasHolder.children;

        if (ideas.length == 0) {
            Array.from(children).forEach(child => {
                if (child.textContent == 'No ideas yet! Be the first one :)') {
                    child.style.display = 'block';
                } else {
                    ideasHolder.removeChild(child);
                }
            })
        } else {
            attachAllIdeas(ideas);
            Array.from(children).forEach(child => {
                child.style.display = 'block';
            })
        }
        detailsForm.style.display = 'none';
        shareIdeaForm.style.display = 'none';
        getStartedForm.style.display = 'none';
    }
}

export async function renderIdeaDetails(id) {
    detailsForm.style.display = 'block';
    ideasHolder.style.display = 'none';
    const details = await getIdeaDetails(id);

    detailsForm.querySelector('img').src=details.img;
    detailsForm.querySelector('.display-5').textContent = details.title;
    detailsForm.querySelector('.idea-description').textContent = details.description;

    if (userId == details._ownerId) {
        detailsForm.querySelector('.btn').style.display = 'inline-block';
        detailsForm.querySelector('.btn').addEventListener('click', () => {
            deleteIdea(id, token);
            renderHomePage();
        });
    } else {
        detailsForm.querySelector('.btn').style.display = 'none';
    }
}

registerButton.addEventListener('click', (e) => {
    e.preventDefault();
    loginForm.style.display = 'none';
    ideasHolder.style.display = 'none';
    detailsForm.style.display = 'none';
    getStartedForm.style.display = 'none';

    shareIdeaForm.style.display = 'none';
    registerForm.style.display = 'block';
    registerForm.querySelector('a').addEventListener('click', (e) => {
        e.preventDefault();

        loginButton.click();
    });

    validateRegister();
})

loginButton.addEventListener('click', (e) => {
    e.preventDefault();

    ideasHolder.style.display = 'none';
    detailsForm.style.display = 'none';
    getStartedForm.style.display = 'none';
    shareIdeaForm.style.display = 'none';
    registerForm.style.display = 'none';

    loginForm.style.display = 'block';
    loginForm.querySelector('a').addEventListener('click', (e) => {
        e.preventDefault();

        registerButton.click();
    });
    validateLogin();
})

logoutButton.addEventListener('click', () => {

    logoutRequest(token);
    renderHomePage();
});

createButton.addEventListener('click', (e) => {
    e.preventDefault();

    ideasHolder.style.display = 'none';
    detailsForm.style.display = 'none';
    getStartedForm.style.display = 'none';
    loginForm.style.display = 'none';
    registerForm.style.display = 'none';

    shareIdeaForm.style.display = 'block';
    validateIdea();
})

getStartedForm.querySelector('a').addEventListener('click', (e) => {e.preventDefault(); loginButton.click()});