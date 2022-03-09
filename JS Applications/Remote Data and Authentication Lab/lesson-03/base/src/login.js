function userLogin(){
    
    let form = document.querySelector('form');
    let email = form.querySelector('input');
    let password = form.querySelectorAll('input')[1];
    let loginButton = form.querySelectorAll('input')[2];
    let loginUrl = `http://localhost:3030/users/login`;

    loginButton.addEventListener('click', (e) => {
        e.preventDefault();

        fetch(loginUrl, {
            method: 'POST',
            headers: {'content-type': 'application/json'},
            body: JSON.stringify({
                email: email.value,
                password: password.value
            })
        })
        .then(res => res.json())
        .then(data => {
            if (data.accessToken != undefined) {
                sessionStorage.setItem('accessToken', data.accessToken);
                location.href = "index.html";
                
            } else {
                alert('Username or password is wrong.')
            }
        });
    });
}

userLogin();