import{renderGuestHomePage, renderUserHomePage, renderAllMoviesInHomePage} from './renderViews.js';

export let currentToken = sessionStorage.getItem('accessToken');
export let currentUserId = sessionStorage.getItem('userId');
export let userEmail = '';

renderAllMoviesInHomePage();

if (currentToken == null) {
    renderGuestHomePage();
} else {
    fetch('http://localhost:3030/users/me', {
        method: 'GET',
        headers: {'X-Authorization':currentToken}
    })
    .then(res => res.json())
    .then(user => {
        userEmail = user.email;
        renderUserHomePage(currentToken, user.email);
    })
}

