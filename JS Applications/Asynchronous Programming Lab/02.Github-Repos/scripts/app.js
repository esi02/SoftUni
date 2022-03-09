function loadRepos() {
	let listOfRepos = document.getElementById('repos');
	let inputUsername = document.getElementById('username');
	let button = document.querySelector('button');
	
	button.addEventListener('click', () => {
		fetch(`https://api.github.com/users/${inputUsername.value}/repos`)
		.then(response => response.json())
		.then(result => {
			listOfRepos.innerHTML = '';
			
			Object.values(result).forEach(repo => {
				let {full_name, html_url} = repo;
				let a = document.createElement('a');
				let li = document.createElement('li');

				a.href = html_url;
				a.textContent = full_name;

				li.appendChild(a);
				listOfRepos.appendChild(li);

			})
		})
		.catch(err => console.log(err));
	});

}