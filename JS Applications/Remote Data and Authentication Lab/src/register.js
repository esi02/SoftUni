function registerUser() {
    let form = document.querySelector('form');
    let email = form.querySelectorAll('input')[0];
    let password = form.querySelectorAll('input')[1];
    let repeatPassword = form.querySelectorAll('input')[2];
    let submitButton = form.querySelectorAll('input')[3];
    let registerUrl = `http://localhost:3030/users/register`;

    submitButton.addEventListener('click', (e) => {
        e.preventDefault();
        
        if (password.value == repeatPassword.value) {
            fetch(registerUrl, {
                method: 'POST',
                headers: {'content-type':'application/json'},
                body: JSON.stringify({
                    email: email.value,
                    password: password.value
                })
            })
            .then(res => res.json())
            .then(user => {
                sessionStorage.setItem('accessToken', user.accessToken);
                alert('Successfull registration!');
                location.href = 'index.html';
            });
        } else {
            alert('Passwords don\'t match!');
        }
    })

}

registerUser();