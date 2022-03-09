function focused() {
  let sectionsInputElements = document.querySelectorAll("div div input");

  for (const input of sectionsInputElements) {
    input.addEventListener('focus', (e) => {
      input.parentElement.className = 'focused';
    });
    input.addEventListener('blur', (e) => {
        input.parentElement.classList.remove('focused');
    });
  }
}
