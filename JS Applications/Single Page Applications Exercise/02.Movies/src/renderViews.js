import { renderLoginPage } from './renderLoginPage.js';
import { renderRegisterPage } from './renderRegisterPage.js';
import { renderAddMoviePage } from './renderAddMovie.js';
import { currentToken, currentUserId } from './homePage.js';

let logoutButton = document.getElementById('logoutBtn');
let loginButton = document.getElementById('loginBtn');
let registerButton = document.getElementById('registerBtn');
let welcomeEmail = document.getElementById('welcomeEmail');
export let addMovieButton = document.getElementById('add-movie-button');
let allSections = document.querySelectorAll('section');

let homePageSection = allSections.item(0);
export let movieSection = allSections.item(2);
export let addMovieSection = allSections.item(3);
export let movieExampleSection = allSections.item(4);
let editMovieSection = allSections.item(5);
export let loginFormSection = allSections.item(6);
export let registerFormSection = allSections.item(7);


export function hideAllSections() {
    allSections.forEach(section => section.style.display = 'none');
    addMovieButton.style.display = 'none';
}

export function renderGuestHomePage() {
    hideAllSections();
    welcomeEmail.style.display = 'none';
    addMovieButton.style.display = 'none';
    logoutButton.style.display = 'none';

    loginButton.style.display = 'block';
    registerButton.style.display = 'block';
    homePageSection.style.display = 'block';
    movieSection.style.display = 'block';

    loginButton.addEventListener('click', renderLoginPage);
    registerButton.addEventListener('click', renderRegisterPage);
}


export function renderUserHomePage(accessToken, email) {
    hideAllSections();
    welcomeEmail.style.display = 'block';
    welcomeEmail.textContent = `Welcome, ${email}`;
    addMovieButton.style.display = 'block';
    logoutButton.style.display = 'block';
    homePageSection.style.display = 'block';
    movieSection.style.display = 'block';

    loginButton.style.display = 'none';
    registerButton.style.display = 'none';

    logoutButton.addEventListener('click', () => {
        fetch('http://localhost:3030/users/logout', {
            method: 'GET',
            headers: { 'X-Authorization': { accessToken } }
        });
        sessionStorage.clear();
        renderGuestHomePage();
        renderLoginPage();
    });
    
    addMovieButton.addEventListener('click', (e) => {
        e.preventDefault();
        renderAddMoviePage();
    });
}

export function renderAllMoviesInHomePage() {
    let cards = movieSection.querySelector('.card-deck');
    let movieCard = movieSection.querySelector('.card').cloneNode(true);
    cards.innerHTML = '';

    fetch('http://localhost:3030/data/movies')
        .then(res => res.json())
        .then(movies => {
            Object.values(movies).forEach(movie => {
                let newCard = movieCard.cloneNode(true);
                newCard.querySelector('img').src = movie.img;
                newCard.querySelector('.card-title').textContent = movie.title;

                if (currentToken != null) {
                    newCard.querySelector('.btn-info').addEventListener('click', () => {
                        renderMovieDetails(movie);
                    });
                }

                cards.appendChild(newCard);
            })
        })
}

function renderMovieDetails(movie) {
    hideAllSections();
    movieExampleSection.style.display = 'block';
    movieExampleSection.innerHTML = ''

    let divContainer = document.createElement('div');
    divContainer.classList.add('container');
    divContainer.innerHTML = `<div class="row bg-light text-dark">
    <h1>Movie title: ${movie.title}</h1>
    <div class="col-md-8">
        <img class="img-thumbnail" src="${movie.img}"
            alt="Movie">
    </div>
    <div class="col-md-4 text-center">
        <h3 class="my-3 ">Movie Description</h3>
        <p>${movie.description}</p>
        <a class="btn btn-danger">Delete</a>
        <a class="btn btn-warning">Edit</a>
        <a class="btn btn-primary">Like</a>
        <span class="enrolled-span">Liked</span>
    </div>
</div>`;

    let deleteButton = divContainer.querySelector('.btn-danger');
    let editButton = divContainer.querySelector('.btn-warning');
    let likesCount = divContainer.querySelector('.enrolled-span');
    let likeButton = divContainer.querySelector('.btn-primary');

    likesCount.style.display = 'none';

    if (currentUserId != movie._ownerId) {
        deleteButton.style.display = 'none';
        editButton.style.display = 'none';

        fetch(`http://localhost:3030/data/likes`, {
            method: 'GET',
            headers: { 'X-Authorization': currentToken }
        })
            .then(res => res.json())
            .then(likes => {
                Object.values(likes).forEach(like => {
                    if (like._ownerId == currentUserId && like.movieId == movie._id) {
                        likeButton.style.display = 'none';
                        likesCount.style.display = 'block';
                        fetch(`http://localhost:3030/data/likes?where=movieId%3D%22${movie._id}%22&distinct=_ownerId&count`)
                        .then(res => res.json())
                        .then(likes => {
                            likesCount.textContent = `Liked ${likes}`;
                        });
                    }
                })
            });

        likeButton.addEventListener('click', () => {
            fetch('http://localhost:3030/data/likes', {
                method: 'POST',
                headers: { 'X-Authorization': currentToken },
                body: JSON.stringify({
                    movieId: movie._id
                })
            });
            likeButton.style.display = 'none';
            likesCount.style.display = 'block';
            fetch(`http://localhost:3030/data/likes?where=movieId%3D%22${movie._id}%22&distinct=_ownerId&count`)
                .then(res => res.json())
                .then(likes => {
                    likesCount.textContent = `Liked ${likes}`;
                });
        });

    } else {
        editButton.addEventListener('click', () => {
            hideAllSections();
            editMovieSection.style.display = 'block';
            editCurrentMovie(movie);
        });

        likeButton.style.display = 'none';
        deleteButton.addEventListener('click', () => {
            fetch(`http://localhost:3030/data/movies/${movie._id}`, {
                method: 'DELETE',
                headers: { 'X-Authorization': currentToken }
            });

            location.href = 'index.html';
        })
    }

    movieExampleSection.appendChild(divContainer);
}

function editCurrentMovie(movie) {
    let titleInput = document.getElementById('editTitle');
    let descriptionInput = document.getElementById('editDescription');
    let imageUrlInput = document.getElementById('editImageUrl');
    let submitButton = document.getElementById('sendEditted');

    titleInput.value = `${movie.title}`;
    descriptionInput.value = `${movie.description}`;
    imageUrlInput.value = `${movie.img}`;

    submitButton.addEventListener('click', () => {
        fetch(`http://localhost:3030/data/movies/${movie._id}`, {
            method: 'PUT',
            headers: { 'X-Authorization': currentToken },
            body: JSON.stringify({
                title: titleInput.value,
                description: descriptionInput.value,
                img: imageUrlInput.value
            })
        });
        renderMovieDetails(movie);
    })
}