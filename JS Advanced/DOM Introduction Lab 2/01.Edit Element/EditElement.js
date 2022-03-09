function editElement(reference, match, replacer) {
  while (reference.textContent.includes(match)) {
      let result = reference.textContent.replace(match, replacer);
      reference.textContent = result;
  }
}
