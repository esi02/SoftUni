window.addEventListener('load', solution);

function solution() {
  let fullNameInputElement = document.getElementById('fname');
  let emailInputElement = document.getElementById('email');
  let phoneInputElement = document.getElementById('phone');
  let addressInputElement = document.getElementById('address');
  let postalCodeInputElement = document.getElementById('code');

  let submitButtonElement = document.getElementById('submitBTN');
  let previewListElement = document.getElementById('infoPreview');
  let editButtonElement = document.getElementById('editBTN');
  let continueButtonElement = document.getElementById('continueBTN');

  submitButtonElement.addEventListener('click', (e) => {
    if (fullNameInputElement.value == '' || emailInputElement.value == '') {
      return;
    }

    let fullNameElement = document.createElement('li');
    fullNameElement.textContent = `Full Name: ${fullNameInputElement.value}`;
    let emailElement = document.createElement('li');
    emailElement.textContent = `Email: ${emailInputElement.value}`;
    let phoneElement = document.createElement('li');
    phoneElement.textContent = `Phone Number: ${phoneInputElement.value}`;
    let addressElement = document.createElement('li');
    addressElement.textContent = `Address: ${addressInputElement.value}`;
    let postalCodeElement = document.createElement('li');
    postalCodeElement.textContent = `Postal Code: ${postalCodeInputElement.value}`;

    previewListElement.appendChild(fullNameElement);
    previewListElement.appendChild(emailElement);
    previewListElement.appendChild(phoneElement);
    previewListElement.appendChild(addressElement);
    previewListElement.appendChild(postalCodeElement);

    fullNameInputElement.value = '';
    emailInputElement.value = '';
    phoneInputElement.value = '';
    addressInputElement.value = '';
    postalCodeInputElement.value = '';

    submitButtonElement.disabled = true;
    editButtonElement.disabled = false;
    continueButtonElement.disabled = false;

    editButtonElement.addEventListener('click', () => {
      fullNameInputElement.value = fullNameElement.textContent.replace('Full Name: ', '');
      emailInputElement.value = emailElement.textContent.replace('Email: ', '');
      phoneInputElement.value = phoneElement.textContent.replace('Phone Number: ', '');
      addressInputElement.value = addressElement.textContent.replace('Address: ', '');
      postalCodeInputElement.value = postalCodeElement.textContent.replace('Postal Code: ', '');

      previewListElement.removeChild(fullNameElement);
      previewListElement.removeChild(emailElement);
      previewListElement.removeChild(phoneElement);
      previewListElement.removeChild(addressElement);
      previewListElement.removeChild(postalCodeElement);

      editButtonElement.disabled = true;
      continueButtonElement.disabled = true;

      submitButtonElement.disabled = false;
    });

    continueButtonElement.addEventListener('click', () => {
      let divElement = document.getElementById('block');
      divElement.querySelectorAll('*').forEach(n => n.remove());
      let headingElement = document.createElement('h3');
      headingElement.textContent = 'Thank you for your reservation!';

      divElement.appendChild(headingElement);
    });
  });

}
