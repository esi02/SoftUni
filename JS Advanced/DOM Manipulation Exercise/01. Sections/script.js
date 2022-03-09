function create(words) {
   let contentElement = document.getElementById('content');
   for (const word of words) {
      let divElement = document.createElement('div');
      let paragraphElement = document.createElement('p');
      paragraphElement.textContent = word;
      paragraphElement.style.display = 'none';
      divElement.appendChild(paragraphElement);
      
      divElement.addEventListener('click', () => {
         paragraphElement.style.display = 'block';
      });
      contentElement.appendChild(divElement);
   }
}