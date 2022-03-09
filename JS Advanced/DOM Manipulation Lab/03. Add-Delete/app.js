function addItem() {
  //Locate elements
  let itemsElement = document.getElementById("items");
  let textToAddElement = document.getElementById("newItemText");

  if (textToAddElement.value.length === 0) {
      return;
  }
  //Create and add new elements
  let newLiElement = document.createElement("li");
  let newLinkElement = document.createElement("a");

  newLinkElement.href = "#";
  let textNode = document.createTextNode("[Delete]");
  newLinkElement.appendChild(textNode);

  //Create link and nest it
  newLiElement.textContent = textToAddElement.value;
  newLiElement.appendChild(newLinkElement);

  //Attach event to the link and remove from the li element
  newLinkElement.addEventListener("click", () => {
    newLiElement.remove();
  });

  itemsElement.appendChild(newLiElement);
}
