function solve() {
  document.querySelector("#searchBtn").addEventListener("click", onClick);

  function onClick() {
    //Extract students' only
    let students = document.querySelectorAll("tbody tr");
    let studentsAsArr = Array.from(students);

    //Clear previous search
    studentsAsArr.forEach(x => x.className = '');
    
    //Extract text to match
    let textToMatch = document.getElementById('searchField').value;

    studentsAsArr.filter((x) => {
      let studentName = x.querySelector("td:first-of-type");
      let studentEmail = x.querySelector("td:nth-of-type(2)");
      let studentCourse = x.querySelector("td:nth-of-type(3)");

      if (textToMatch == '') {
      } else if (
        studentName.textContent.includes(textToMatch) ||
        studentEmail.textContent.includes(textToMatch) ||
        studentCourse.textContent.includes(textToMatch)
      ) {
         x.className = 'select';
      }
    });
    //Clear input field
    document.getElementById('searchField').value = '';
  }
}
