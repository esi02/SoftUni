function solve() {
  //Extract text and sentences
  let input = document.getElementById("input").value.split(".");

  //Append paragraphs
  let content = "";

  while (input[0]) {
    content = document.createTextNode('');
    for (let i = 0; i < 3; i++) {
      if (input[0]) {
        content.appendData(input[0] + ".");
        input.shift();
      }
    }
    let paragraph = document.createElement("p");
    paragraph.appendChild(content);
    document.getElementById("output").appendChild(paragraph);
  }
}
