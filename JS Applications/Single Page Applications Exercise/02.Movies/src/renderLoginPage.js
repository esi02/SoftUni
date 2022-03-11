import {hideAllSections, renderUserHomePage, loginFormSection} from './renderViews.js';

export function renderLoginPage() {
    hideAllSections();
    loginFormSection.style.display = 'block';

    loginFormSection.querySelector('button').addEventListener('click', (e) => {
        e.preventDefault();

        fetch('http://localhost:3030/users/login', {
            method: 'POST',
            headers: { 'content-type': 'application/json' },
            body: JSON.stringify({
                email: loginFormSection.querySelector('#email').value,
                password: loginFormSection.querySelector('#password').value
            })
        })
            .then(res => {
                if (!res.ok) {
                    alert('Wrong name or password!');
                } else {
                    return res.json();
                }
            })
            .then(user => {
                    sessionStorage.setItem('accessToken', user.accessToken);
                    sessionStorage.setItem('userId', user._id);
                    renderUserHomePage(user.accessToken, user.email);
            });
    });
}