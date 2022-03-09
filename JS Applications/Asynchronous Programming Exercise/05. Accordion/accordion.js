function solution() {
    let acc = document.querySelector(".accordion");
    let main = document.getElementById("main");
    let url = `http://localhost:3030/jsonstore/advanced/articles/list`;
    main.innerHTML = "";
   
    fetch(url)
      .then((res) => res.json())
      .then((data) => Object.values(data).forEach(article => {
          let item = acc.cloneNode(true);
          let button = item.querySelector("button");
          let title = item.querySelector('span');
          let paragraph = item.querySelector('p');
          let hiddenDiv = item.querySelector('.extra');
      
          fetch(`http://localhost:3030/jsonstore/advanced/articles/details/${article._id}`)
          .then(res => res.json())
          .then(contentDetails => {
              paragraph.textContent = contentDetails.content;
              title.textContent = contentDetails.title;
          });
      
          button.addEventListener("click", () => {
            if (button.textContent == "Less") {
              button.textContent = "More";
              hiddenDiv.style.display = "none";
            } else {
              button.textContent = "Less";
              hiddenDiv.style.display = "block";
            }
          });
          
          main.appendChild(item);
      }))
      .catch((err) => console.log("Error"));
  }
   
  solution();