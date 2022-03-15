import { hideAllSections, registerFormSection, renderUserHomePage } from './renderViews.js';

export function renderRegisterPage() {
    hideAllSections();
    registerFormSection.style.display = 'block';

    registerFormSection.querySelector('button').addEventListener('click', (e) => {
        e.preventDefault();

        if (registerFormSection.querySelector('#email').value == '') {
            alert('Email should not be empty!');
        } else if (registerFormSection.querySelector('#password').value.length < 6) {
            alert('Password should be at least 6 characters long!');
        } else if (registerFormSection.querySelector('#password').value != registerFormSection.querySelector('#repeatPassword').value) {
            alert('Passwords should match!');
        } else {
            fetch('http://localhost:3030/users/register', {
                method: 'POST',
                headers: { 'content-type': 'application/json' },
                body: JSON.stringify({
                    email: registerFormSection.querySelector('#email').value,
                    password: registerFormSection.querySelector('#password').value
                })
            })
                .then(res => {
                    if (!res.ok) {
                        alert('User already exists!');
                    } else {
                        return res.json();
                    }
                })
                .then(user => {
                    sessionStorage.setItem('accessToken', user.accessToken);
                    sessionStorage.setItem('userId', user._id);
                    renderUserHomePage(user.accessToken, user.email);
                });
        }
    });
}