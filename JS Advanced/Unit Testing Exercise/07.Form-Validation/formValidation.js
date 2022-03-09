function validate() {
  let submitElement = document.getElementById("submit");
  let usernameElement = document.getElementById("username");
  let usernameIsValid = true;

  usernameElement.addEventListener("change", () => {
    if (
        usernameElement.value.length < 3 ||
        usernameElement.value.length > 20 ||
        usernameElement.value.matchAll(/[a-zA-Z0-9]+/g) === null
    ) {
      usernameIsValid = false;
    }
  });

  let passwordElement = document.getElementById('password');
  let passwordIsValid = true;
  passwordElement.addEventListener('change', () => {
      if (passwordElement.value.length < 5 ||
        passwordElement.value.length > 15 ||
        passwordElement.value.matchAll(/\w+/g) === null) {
          passwordIsValid = false;
      }
  });

  let confirmPasswordElement = document.getElementById('confirm-password');
  let confirmPasswordIsValid = true;
  confirmPasswordElement.addEventListener('change', () => {
    if (confirmPasswordElement.value.length < 5 ||
        confirmPasswordElement.value.length > 15 ||
        confirmPasswordElement.value.matchAll(/\w+/g) === null) {
            confirmPasswordIsValid = false;
    }

    if (confirmPasswordElement.value !== passwordElement.value) {
        passwordIsValid = false;
        confirmPasswordIsValid = false;
    }
});

let emailElement = document.getElementById('email');
let emailIsValid = true;

emailElement.addEventListener('change', () => {
    if (!emailElement.value.contains('@') ||
       !emailElement.value.contains('.')) {
        emailIsValid = false;
    }
});

let companyCheckElement = document.getElementById('company');
let companyFieldElement = document.getElementById('companyInfo');
let companyNumberElement = document.getElementById('companyNumber');
let companyNumberIsValid = true;

companyCheckElement.addEventListener('change', () => {
    if (companyCheckElement.checked == true) {
        companyFieldElement.style.display = 'block';
           if (companyNumberElement.value < 1000 ||
                companyNumberElement.value > 9999) {
               companyNumberIsValid = false;
           }
    } else {
        companyFieldElement.style.display = 'none';
    }
});

  submitElement.addEventListener("click", (e) => {
      if (!usernameIsValid) {
          usernameElement.style.borderColor = "red";
        } else {
            usernameElement.style.border = 'none';
        }
        
        if (!passwordIsValid) {
            passwordElement.style.borderColor = 'red';
        } else {
            passwordElement.style.border = 'none';
        }

        if(!confirmPasswordIsValid) {
            confirmPasswordElement.style.borderColor = 'red';
        } else {
            confirmPasswordElement.style.border = 'none';
        }

        if (!emailIsValid) {
            emailElement.style.borderColor = 'red';
        } else {
            emailElement.style.border = 'none';
        }

        if (!companyNumberIsValid) {
           companyNumberElement.style.borderColor = 'red';
        } else {
            companyNumberElement.style.border = 'none';
        }

        if (usernameIsValid && passwordIsValid && confirmPasswordIsValid
            && emailIsValid && companyNumberIsValid) {
            let validElement = document.getElementById('valid');
            validElement.style.display = 'block';
        }
        e.preventDefault(); 
  });
}
