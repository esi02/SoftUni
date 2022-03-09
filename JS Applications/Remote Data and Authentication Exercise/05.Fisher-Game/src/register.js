function register() {
  let logoutButton = document.getElementById("logout");
  logoutButton.style.display = "none";
  let form = document.querySelector("form");
  let emailElement = form.querySelector("input");
  let passwordElement = form.querySelectorAll("input")[1];
  let repeatElement = form.querySelectorAll("input")[2];
  let registerButton = form.querySelector("button");

  registerButton.addEventListener("click", (e) => {
    e.preventDefault();
    if (passwordElement.value != repeatElement.value) {
      alert("Passwords are not the same!");
    }

    fetch(`http://localhost:3030/users/register`, {
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
          alert("Invalid email or password!");
        } else {
          sessionStorage.setItem("userId", response._id);
          sessionStorage.setItem("accessToken", response.accessToken);
          location.href = "index.html";
        }
      });
  });
}

register();
