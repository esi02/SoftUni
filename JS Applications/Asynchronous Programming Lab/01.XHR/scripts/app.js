function loadRepos() {

   let buttonElement = document.querySelector('button');

   buttonElement.addEventListener('click', () => {
      let httpRequest = new XMLHttpRequest();
      let url = 'https://api.github.com/users/testnakov/repos';

      httpRequest.addEventListener('readystatechange', () => {
         if (httpRequest.readyState == 4 && httpRequest.status == 200) {
            document.getElementById('res').textContent = httpRequest.responseText;
         }
      });

      httpRequest.open("GET", url);
      httpRequest.send();
   });

}