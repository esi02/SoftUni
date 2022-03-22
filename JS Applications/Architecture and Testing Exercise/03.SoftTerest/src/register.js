import { renderHomePage } from './renderViews.js';
import { registerRequest } from './requests.js';

let email = document.getElementById('email');
let password = document.getElementById('password');
let repeatPassword = document.getElementById('inputRepeatPassword');
let signUpButton = document.querySelector('button[type="submit"]');

export function validateRegister() {
    signUpButton.addEventListener('click', () => {
        if (email.value.length < 3) {
            alert('Email should be at least 3 characters long!');
        } else if (email.value.match(/[0-9]+\W+/gm) == null) {
            alert('Email should contain digits and special characters!');
        } else if (password.value.length < 3) {
            alert('Password should be at least 3 characters long!');
        } else if (password.value != repeatPassword.value) {
            alert('Passwords don\'t match!');
        } else {
            registerRequest(email.value, password.value);
            renderHomePage();
        }
    });
}

