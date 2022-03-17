export function registerRequest(email, password) {
    fetch('http://localhost:3030/users/register', {
        method: 'POST',
        headers: {'content-type': 'application/json'},
        body: JSON.stringify({
            email,
            password,
        })
    })
    .then(res => {
        if (!res.ok) {
            throw new Error();
        } else {
            return res.json();
        }
    })
    .then(user => {
        sessionStorage.setItem('userId', user._id);
        sessionStorage.setItem('accessToken', user.accessToken);
    })
    .catch(err => alert('Invalid data!'));
}

export async function getCreatedIdeas() {
    const res = await fetch('http://localhost:3030/data/ideas?select=_id%2Ctitle%2Cimg&sortBy=_createdOn%20desc');
    const data = await res.json();
    return data;
}

export function loginRequest(email, password) {
    fetch('http://localhost:3030/users/login', {
        method: 'POST',
        headers: {'content-type':'application/json'},
        body: JSON.stringify({
            email,
            password,
        })
    })
    .then(res => {
        if (!res.ok) {
            throw new Error();
        } else {
            return res.json();
        }
    })
    .then(user => {
        sessionStorage.setItem('userId', user._id);
        sessionStorage.setItem('accessToken', user.accessToken);
    })
    .catch(err => alert('Wrong name or password!'));
}

export function logoutRequest(token) {
    fetch('http://localhost:3030/users/logout', {
        method: 'GET',
        headers: {'X-Authorization': token}
    });
    sessionStorage.clear();
}

export function createIdea(token, title, description, img) {
    fetch('http://localhost:3030/data/ideas', {
        method: 'POST',
        headers: {'X-Authorization': token},
        body: JSON.stringify({
            title,
            description,
            img,
        })
    });
}

export async function getIdeaDetails(id) {
    const res = await fetch(`http://localhost:3030/data/ideas/${id}`);
    const details = await res.json();
    
    return details;
}

export function deleteIdea(id, token) {
    fetch(`http://localhost:3030/data/ideas/${id}`, {
        method: 'DELETE',
        headers: {'X-Authorization': token}
    })
}