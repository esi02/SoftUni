function bookCreation() {
    let tableBody = document.querySelector("tbody");
    let form = document.querySelector("form");
    let loadButton = document.getElementById("loadBooks");
    let url = `http://localhost:3030/jsonstore/collections/books`;

    //I need the elements later when i edit the book
    let currentId = "";
    let currentAuthor = document.createElement("td");
    let currentTitle = document.createElement("td");

    let heading = form.children[0];
    let titleElement = form.children[2];
    let authorElement = form.children[4];
    let submitButton = form.children[5];

    loadButton.addEventListener("click", () => {
        //clear invalid data
        tableBody.innerHTML = "";
        fetch(url)
            .then((res) => res.json())
            .then((books) => {
                Object.entries(books).forEach((book) => {
                    let id = book[0];
                    let { author, title } = book[1];

                    //create rows and td for every book
                    let row = document.createElement("tr");
                    let titleTd = document.createElement("td");
                    let authorTd = document.createElement("td");
                    let actionTd = document.createElement("td");
                    let editButton = document.createElement("button");
                    let deleteButton = document.createElement("button");

                    //set text content
                    editButton.textContent = "Edit";
                    deleteButton.textContent = "Delete";
                    titleTd.textContent = title;
                    authorTd.textContent = author;

                    editButton.addEventListener("click", () => {
                        heading.textContent = "Edit FORM";
                        titleElement.value = titleTd.textContent;
                        authorElement.value = authorTd.textContent;
                        submitButton.textContent = "Save";

                        //if edit event is triggered take its book
                        currentId = id;
                        currentAuthor = authorTd;
                        currentTitle = titleTd;
                    });

                    actionTd.appendChild(editButton);
                    actionTd.appendChild(deleteButton);
                    row.appendChild(titleTd);
                    row.appendChild(authorTd);
                    row.appendChild(actionTd);
                    tableBody.appendChild(row);

                    deleteButton.addEventListener("click", () => {
                        fetch(`${url}/${id}`, {
                            method: "DELETE",
                        });
                        tableBody.removeChild(row);
                    });
                });
            });
    });

    submitButton.addEventListener("click", (e) => {
        e.preventDefault();

        if (titleElement.value != "" && authorElement.value != "") {
            if (submitButton.textContent == "Save") {
                fetch(`${url}/${currentId}`, {
                    method: "PUT",
                    headers: { "Content-Type": "application/json" },
                    body: JSON.stringify({
                        author: authorElement.value,
                        title: titleElement.value,
                    }),
                })
                    .then((res) => res.json())
                    .then((data) => {
                        heading.textContent = "FORM";
                        titleElement.value = "";
                        authorElement.value = "";
                        submitButton.textContent = "Submit";

                        currentTitle.textContent = data.title;
                        currentAuthor.textContent = data.author;
                    });
            } else {
                fetch(url, {
                    method: "POST",
                    headers: { "content-type": "application/json" },
                    body: JSON.stringify({
                        author: authorElement.value,
                        title: titleElement.value,
                    }),
                });
                titleElement.value = "";
                authorElement.value = "";

                //update with new books
                loadButton.click();
            }
        } else {
            alert("Please fill all fields!");
        }
    });
}

bookCreation();
