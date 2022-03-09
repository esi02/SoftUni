let table = document.getElementById("results");
let tableBody = table.querySelector("tbody");
let url = `http://localhost:3030/jsonstore/collections/students`;

function createStudents() {
  let submitButton = document.getElementById("submit");

  let firstName = document.querySelector("input");
  let lastName = document.querySelectorAll("input")[1];
  let facultyNum = document.querySelectorAll("input")[2];
  let grade = document.querySelectorAll("input")[3];

  submitButton.addEventListener("click", (e) => {
    e.preventDefault();
    
    if (
      firstName.value != "" &&
      lastName.value != "" &&
      facultyNum.value != "" &&
      grade.value != ""
      ) {
          fetch(url, {
              method: "POST",
              headers: { "content-type": "application/json" },
              body: JSON.stringify({
                  firstName: firstName.value,
                  lastName: lastName.value,
                  facultyNumber: facultyNum.value,
                  grade: Number(grade.value),
                }),
            });
            
            firstName.value = "" ;
            lastName.value = "";
            facultyNum.value = "";
            grade.value = "";
            
            tableBody.innerHTML = "";
            dispatchEvent(new Event("load"));
    } else {
      alert("Please fill all fields!");
    }
  });
}

createStudents();

window.addEventListener("load", () => {
  fetch(url)
    .then((res) => res.json())
    .then((students) => {
      Object.values(students).forEach((student) => {
        let row = document.createElement("tr");
        let firstNameTd = document.createElement("td");
        let lastNameTd = document.createElement("td");
        let facultyNumTd = document.createElement("td");
        let gradeTd = document.createElement("td");

        firstNameTd.textContent = student.firstName;
        lastNameTd.textContent = student.lastName;
        facultyNumTd.textContent = student.facultyNumber;
        gradeTd.textContent = student.grade;

        row.appendChild(firstNameTd);
        row.appendChild(lastNameTd);
        row.appendChild(facultyNumTd);
        row.appendChild(gradeTd);

        tableBody.appendChild(row);
      });
    });
});
