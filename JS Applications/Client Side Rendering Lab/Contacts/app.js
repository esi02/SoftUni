import { html, render } from '../node_modules/lit-html/lit-html.js';
import { contacts } from './contacts.js';

const template = (id, name, phone, email) => {
    return html`
    <div class="contact card">
        <div>
            <i class="far fa-user-circle gravatar"></i>
        </div>
        <div class="info">
            <h2>Name: ${name}</h2>
            <button class="detailsBtn">Details</button>
            <div class="details" id=${id}>
                <p>Phone number: ${phone}</p>
                <p>Email: ${email}</p>
            </div>
        </div </div>`;
}

let arr = contacts.map(x => template(x.id, x.name, x.phoneNumber, x.email));

render(arr, document.getElementById('contacts'));

let allButtons = document.querySelectorAll('.detailsBtn');
allButtons.forEach(button => button.addEventListener('click', () => {
    if (button.parentElement.querySelector('.details').style.display == 'block') {
        button.parentElement.querySelector('.details').style.display = 'none';
    } else {
        button.parentElement.querySelector('.details').style.display = 'block';
    }
}))