function createRecipe() {
    let form = document.querySelector('form');
    let recipeName = form.querySelector('input');
    let recipeImg = form.querySelectorAll('input')[1];
    let ingredients = form.querySelectorAll('textarea')[0];
    let preparation = form.querySelectorAll('textarea')[1];
    let createButton = form.querySelectorAll('input')[2];
    let createUrl = `http://localhost:3030/data/recipes`;

    createButton.addEventListener('click', (e) => {
        e.preventDefault();

        fetch(createUrl, {
            method: 'POST',
            headers:
            {
                'content-type': 'application/json',
                'X-Authorization': `${sessionStorage.getItem('accessToken')}`
            },
            body: JSON.stringify({
                name: recipeName.value,
                img: recipeImg.value,
                ingredients: ingredients.value.split('\n'),
                steps: preparation.value.split('\n')
            })
        })
            .then(res => res.json())
            .then(recipe => {
                alert(`Recipe successfuly created!`);
                location.href = "index.html";
            });
    });
}
createRecipe();