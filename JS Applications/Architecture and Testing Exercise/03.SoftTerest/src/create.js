import {createIdea} from './requests.js';
import{ renderHomePage, token} from './renderViews.js';

let form = document.getElementById('createIdeaForm');
let title = form.querySelector('#ideaTitle');
let description = form.querySelector('textarea');
let img = form.querySelector('#inputURL');
let submitButton = form.querySelector('button');

export function validateIdea() {
    submitButton.addEventListener('click', () => {
        if (title.value.length < 6) {
            alert('Title should be at least 6 characters long!');
        } else if(description.value.length < 10) {
            alert('Description should be at least 10 characters long!');
        } else if(img.value.length < 5) {
            alert('The image URL should be at least 5 characters long!');
        } else{
            createIdea(token, title.value, description.value, img.value);
            renderHomePage();
        }
    })
}