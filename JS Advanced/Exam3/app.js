function solve(){
   let authorInputElement = document.getElementById('creator');
   let titleInputElement = document.getElementById('title');
   let categoryInputElement = document.getElementById('category');
   let contentInputElement = document.getElementById('content');
   
   let createButtonElement = document.querySelector('button');
   let articlesSectionElement = document.querySelectorAll('section')[1];
   
   createButtonElement.addEventListener('click', (e) => {
      e.preventDefault();
      let articleElement = document.createElement('article');
      let titleElement = document.createElement('h1');
      titleElement.textContent = titleInputElement.value;

      let categoryElement = document.createElement('p');
      categoryElement.textContent = 'Category: ';

      let strongCategoryElement = document.createElement('strong');
      strongCategoryElement.textContent = categoryInputElement.value;
      categoryElement.appendChild(strongCategoryElement);

      let creatorElement = document.createElement('p');
      creatorElement.textContent = 'Creator: ';

      let strongCreatorElement = document.createElement('strong');
      strongCreatorElement.textContent = authorInputElement.value;
      creatorElement.appendChild(strongCreatorElement);

      let contentElement = document.createElement('p');
      contentElement.textContent = contentInputElement.value;

      let divElement = document.createElement('div');
      divElement.classList.add('buttons');

      let deleteButton = document.createElement('button');
      deleteButton.textContent = 'Delete';
      deleteButton.classList.add('btn');
      deleteButton.classList.add('delete');

      let archiveButton = document.createElement('button');
      archiveButton.textContent = 'Archive';
      archiveButton.classList.add('btn');
      archiveButton.classList.add('archive');

      divElement.appendChild(deleteButton);
      divElement.appendChild(archiveButton);

      articleElement.appendChild(titleElement);
      articleElement.appendChild(categoryElement);
      articleElement.appendChild(creatorElement);
      articleElement.appendChild(contentElement);
      articleElement.appendChild(divElement);

      articlesSectionElement.appendChild(articleElement);

      archiveButton.addEventListener('click', () => {
         let listElement = document.querySelector('ol');
         let listItem = document.createElement('li');
         listItem.textContent = titleElement.textContent;
         listElement.appendChild(listItem);

         function sortList() {
            var list, i, sortFlag, LiEle, sorted;
            list = listElement;
            sortFlag = true;
            while (sortFlag) {
               sortFlag = false;
               LiEle = list.getElementsByTagName("li");
               for (i = 0; i < LiEle.length - 1; i++) {
                  sorted = false;
                  if ( LiEle[i].innerHTML.toLowerCase() > LiEle[i + 1].innerHTML.toLowerCase() ) {
                     sorted = true;
                     break;
                  }
               }
               if (sorted) {
                  LiEle[i].parentNode.insertBefore(LiEle[i + 1], LiEle[i]);
                  sortFlag = true;
               }
            }
         }

         sortList();
      });

      deleteButton.addEventListener('click', () => {
         articlesSectionElement.removeChild(articleElement);
      })
   });
  }
