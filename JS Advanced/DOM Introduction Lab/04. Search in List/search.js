function search() {
   //First clear previous searches
   let townsAsNodeList = document.querySelectorAll("#towns li");
   for (const town of townsAsNodeList) {
      town.style.fontWeight = '';
      town.style.textDecoration = '';
   }

  let matchesResult = document.getElementById("result");
  matchesResult.textContent = "";

  //Extract towns and convert to array to modify
  let towns = document.querySelectorAll("li");
  let townsArr = Array.from(towns);
  let townsText = townsArr.map((x) => x.textContent);

  //Extract search text
  let searchText = document.getElementById("searchText").value;
  let matchesCount = 0;

  //Validation if searchText is empty or whitespace
  if (searchText != "" && searchText != " ") {
     //Set style if condition is met
    townsText.forEach((x, i) => {
      if (x.includes(searchText)) {
        towns[i].style.fontWeight = "bold";
        towns[i].style.textDecoration = "underline";
        matchesCount++;
      }
    });
    matchesResult.textContent = `${matchesCount} matches found`;
  }
}
