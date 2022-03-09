function validate() {
    let emailElement = document.getElementById('email');
    
    emailElement.addEventListener('change', () => {
        let emailContent = emailElement.value;
        if (emailContent.match(/[a-z]+@[a-z]+\.[a-z]+/g) === null) {
            emailElement.classList.add('error');
        } else {
            emailElement.classList.remove('error');
        }
    });
}