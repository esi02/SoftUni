function login() {
  let logoutButton = document.getElementById("logout");
  logoutButton.style.display = "none";
  let loginForm = document.querySelector("form");
  let emailElement = loginForm.querySelector("input");
  let passwordElement = loginForm.querySelectorAll("input")[1];
  let loginButton = loginForm.querySelector("button");

  loginButton.addEventListener("click", (e) => {
    e.preventDefault();

    fetch(`http://localhost:3030/users/login`, {
      method: "POST",
      headers: { "content-type": "application/json" },
      body: JSON.stringify({
        email: emailElement.value,
        password: passwordElement.value
      }),
    })
      .then((res) => res.json())
      .then((response) => {
        if (response._id == undefined) {
          alert("Wrong email or password!");
        } else {
          sessionStorage.setItem("userId", response._id);
          sessionStorage.setItem("accessToken", response.accessToken);
          location.href = "index.html";
        }
      });

    emailElement.value = "";
    passwordElement.value = "";
  });
}

login();
