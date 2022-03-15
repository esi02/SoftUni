import { showCatalog } from './catalog.js';
import {showDetails} from './details.js';

export async function register(body) {
    const response = await fetch('http://localhost:3030/users/register', {
        method: 'post',
        headers: {
            'Content-Type': 'application/json'
        },
        body
    });

    const data = await response.json();

    if (response.status == 200) {
        sessionStorage.setItem('authToken', data.accessToken);
        sessionStorage.setItem('userId', data._id);
        document.getElementById('user').style.display = 'inline-block';
        document.getElementById('guest').style.display = 'none';

        showCatalog();
    } else {
        alert(data.message);
        throw new Error(data.message);
    }
}

export async function login(body) {
    const response = await fetch('http://localhost:3030/users/login', {
        method: 'post',
        headers: {
            'Content-Type': 'application/json'
        },
        body
    });

    const data = await response.json();
    if (response.status == 200) {
        sessionStorage.setItem('authToken', data.accessToken);
        sessionStorage.setItem('userId', data._id);
        document.getElementById('user').style.display = 'inline-block';
        document.getElementById('guest').style.display = 'none';

        showCatalog();
    } else {
        alert(data.message);
        throw new Error(data.message);
    }
}

export async function getRecipe(id) {
    const response = await fetch('http://localhost:3030/data/recipes/' + id);
    const recipe = await response.json();

    return recipe;
};

export async function updateRecipe(id, token, body) {
    const response = await fetch('http://localhost:3030/data/recipes/' + id, {
        method: 'put',
        headers: {
            'Content-Type': 'application/json',
            'X-Authorization': token
        },
        body
    });

    if (response.status == 200) {
        showDetails(id);
    } else {
        const error = await response.json();
        throw new Error(error.message);
    }
}

export async function deleteRecipe(id, token) {
    const response =  await fetch('http://localhost:3030/data/recipes/' + id, {
        method: 'delete',
        headers: {
            'X-Authorization': token
        }
    });
    
    if (response.status != 200) {
        const error = await response.json();
        throw new Error(error.message);
    } 
}

export async function createRecipe(token, body) {
    const response = await fetch('http://localhost:3030/data/recipes', {
        method: 'post',
        headers: {
            'Content-Type': 'application/json',
            'X-Authorization': token
        },
        body
    });

    if (response.status == 200) {
        showDetails((await response.json())._id);
    } else {
        const error = await response.json();
        throw new Error(error.message);
    }
}

export async function getRecipes() {
    const response = await fetch('http://localhost:3030/data/recipes?select=' + encodeURIComponent('_id,name,img'));
    const data = await response.json();

    return data;
}