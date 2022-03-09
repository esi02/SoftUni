function loginPage() {
    let registerUrl = 'http://localhost:3030/users/register';
    let loginUrl = 'http://localhost:3030/users/login';

    let registerForm = document.querySelector('form');
    let loginForm = document.querySelectorAll('form')[1];
    let registerButton = registerForm.children[3];
    let loginButton = loginForm.children[2];

    registerButton.addEventListener('click', () => {
        let emailInput = registerForm.querySelector('input');
        let passwordInput = registerForm.querySelectorAll('input')[1];
        let repeatInput = registerForm.querySelectorAll('input')[2];

        if (passwordInput.value != repeatInput.value) {
            alert('Passwords don\'t match!');
        } else {
            fetch(registerUrl, {
                method: 'POST',
                headers: { 'content-type': 'application/json' },
                body: JSON.stringify({
                    email: emailInput.value,
                    password: passwordInput.value
                })
            })
                .then(res => res.json())
                .then(user => {
                    if (user.accessToken == undefined) {
                        alert('Invalid email or password!');
                    } else {
                        sessionStorage.setItem('accessToken', `${user.accessToken}`);
                        sessionStorage.setItem('userId', `${user._id}`);
                        location.href = 'homeLogged.html';
                    }
                });
        }

    });

    loginButton.addEventListener('click', () => {
        let emailInput = loginForm.querySelector('input');
        let passwordInput = loginForm.querySelectorAll('input')[1];

        fetch(loginUrl, {
            method: 'POST',
            headers: { 'content-type': 'application/json' },
            body: JSON.stringify({
                email: emailInput.value,
                password: passwordInput.value
            })
        })
            .then(res => res.json())
            .then(user => {
                if (user.accessToken == undefined) {
                    alert('Wrong name or password!');
                } else {
                    sessionStorage.setItem('accessToken', `${user.accessToken}`);
                    sessionStorage.setItem('userId', `${user._id}`);
                    location.href = 'homeLogged.html';
                }
            });
    })

}

loginPage();