import {addMovieSection, hideAllSections, renderUserHomePage} from './renderViews.js';
import {currentToken, userEmail} from './homePage.js';

export function renderAddMoviePage() {
    hideAllSections();
    addMovieSection.style.display = 'block';
    
    let submitMovieButton = addMovieSection.querySelector('button');
    let titleInput = addMovieSection.querySelector('#title');
    let descriptionInput = addMovieSection.querySelector('#description');
    let imgInput = addMovieSection.querySelector('#imageUrl');

    submitMovieButton.addEventListener('click', () => {
        if (titleInput.value == '' ||
            descriptionInput.value == '' ||
            imgInput.value == '') {
            alert('Please fill all fields!')
        } else {
            fetch('http://localhost:3030/data/movies', {
                method: 'POST',
                headers: {'X-Authorization': currentToken},
                body: JSON.stringify({
                    title: titleInput.value,
                    description: descriptionInput.value,
                    img: imgInput.value
                })
            });
            renderUserHomePage(currentToken, userEmail);
        }
    });
}