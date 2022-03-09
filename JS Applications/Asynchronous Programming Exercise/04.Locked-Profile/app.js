function lockedProfile() {
    let firstProfile = document.getElementsByClassName("profile")[0];
    let main = document.getElementById("main");
    let url = `http://localhost:3030/jsonstore/advanced/profiles`;
   
    main.innerHTML = "";
    let count = 0;
   
    fetch(url)
      .then((res) => res.json())
      .then((data) => {
        let users = Object.values(data);
   
        users.forEach((user) => {
            count++;
          let username = user.username;
          let email = user.email;
          let age = user.age;
          let profile = firstProfile.cloneNode(true);
   
          let profileButton = profile.querySelector("button");
          let profileUsername = profile.querySelectorAll("input")[2];
          profileUsername.setAttribute('name', `user${count}Username`);
   
          let profileEmail = profile.querySelectorAll("input")[3];
          profileEmail.setAttribute('name', `user${count}Email`);
   
          let profileAge = profile.querySelectorAll("input")[4];
          profileAge.setAttribute('name', `user${count}Age`);
   
          let unlockCheck = profile.querySelectorAll("input")[1];
          let lockCheck = profile.querySelectorAll("input")[0];
          let hiddenInfo = profile.querySelector("div");
   
          unlockCheck.setAttribute('name', `user${count}Locked`);
          lockCheck.setAttribute('name', `user${count}Locked`);
          hiddenInfo.setAttribute("id", `user${count}HiddenFields`);
   
          profileUsername.value = username;
          profileEmail.value = email;
          profileAge.value = age;
   
          profileButton.addEventListener("click", (e) => {
            if (
              unlockCheck.checked == true &&
              profileButton.textContent == "Show more"
            ) {
              hiddenInfo.style.display = "inline-block";
              hiddenInfo.classList.remove("hiddenInfo");
              profileButton.textContent = "Hide it";
            } else if (
              unlockCheck.checked == false &&
              lockCheck.checked == true &&
              profileButton.textContent == "Hide it"
            ) {
              e.stopPropagation();
            } else if (
              unlockCheck.checked == true &&
              profileButton.textContent == "Hide it"
            ) {
              hiddenInfo.style.display = "none";
              hiddenInfo.classList.add("hiddenInfo");
              profileButton.textContent = "Show more";
            }
          });
   
          main.appendChild(profile);
      });
      })
      .catch((err) => console.log("Error"));
  }