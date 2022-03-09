function toggle() {
    let buttonText = document.getElementsByClassName('button')[0];
    let contentElement = document.getElementById('extra');
    
    if (contentElement.style.display == 'none') {
        buttonText.textContent = 'Less';
        contentElement.style.display = 'block';
    } else {
        buttonText.textContent = 'More';
        contentElement.style.display = 'none';
    }
}