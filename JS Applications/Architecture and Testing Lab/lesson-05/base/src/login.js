import{login} from './requests.js';

let main;
let section;
let setActiveNav;

export function setupLogin(targetMain, targetSection, onActiveNav) {
    main = targetMain;
    section = targetSection;
    setActiveNav = onActiveNav;

    const form = targetSection.querySelector('form');

    form.addEventListener('submit', (ev => {
        ev.preventDefault();
        const formData = new FormData(ev.target);
        onSubmit([...formData.entries()].reduce((p, [k, v]) => Object.assign(p, { [k]: v }), {}));
    }));

    async function onSubmit(data) {
        const body = JSON.stringify({
            email: data.email,
            password: data.password,
        });

        try {
           login(body);
        } catch (err) {
            console.error(err.message);
        }
    }
}

export function showLogin() {
    setActiveNav('loginLink');
    main.innerHTML = '';
    main.appendChild(section);
}