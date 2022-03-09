function validate() {
    let emailElement = document.getElementById('email');

    emailElement.addEventListener('change', (e) => {
        if (/[a-z]+@[a-z]+\.[a-z]+/g.test(emailElement.value)) {
            emailElement.classList.remove('error');
        } else {
            emailElement.className = 'error';
        }
    });
}