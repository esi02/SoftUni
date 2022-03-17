import { renderHomePage } from './renderViews.js';
import { loginRequest } from './requests.js';

let email = document.getElementById('inputEmail');
let password = document.getElementById('inputPassword');
let signInButton = document.querySelectorAll('button[type="submit"]')[1];

export function validateLogin() {
    signInButton.addEventListener('click', () => {
        
        loginRequest(email.value, password.value);
        renderHomePage();
    })
}