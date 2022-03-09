function lockedProfile() {
  let unlockedValuesElements = document.querySelectorAll(
    'input[value="unlock"]'
  );
  let lockedValuesElements = document.querySelectorAll('input[value="lock"]');

  let user1hiddenElements = document.getElementById("user1HiddenFields");
  let user2hiddenElements = document.getElementById("user2HiddenFields");
  let user3hiddenElements = document.getElementById("user3HiddenFields");

  let user1Button = document.getElementsByTagName("button")[0];
  let user2Button = document.getElementsByTagName("button")[1];
  let user3Button = document.getElementsByTagName("button")[2];

  for (const unlockCheck of unlockedValuesElements) {
    unlockCheck.addEventListener("click", () => {
            unlockCheck.setAttribute('checked', true);
  });
}

  user1Button.addEventListener("click", () => {
    let user1UnlockedElement = document.querySelectorAll('input[value="unlock"]')[0];
    let user1LockedElement = document.querySelectorAll('input[value="lock"]')[0];

    if (user1UnlockedElement.checked == true) {
      if (user1Button.textContent == "Show more") {
        user1hiddenElements.style.display = "block";
        user1Button.textContent = "Hide it";
      } else if (user1Button.textContent == "Hide it") {
        user1hiddenElements.style.display = "none";
        user1Button.textContent = "Show more";
      }
    }
  });

  user2Button.addEventListener("click", () => {
    let user2UnlockedElement = document.querySelectorAll('input[value="unlock"]')[1];
    let user2LockedElement = document.querySelectorAll('input[value="lock"]')[1];

    if (user2UnlockedElement.checked == true) {
      if (user2Button.textContent == "Show more") {
        user2hiddenElements.style.display = "block";
        user2Button.textContent = "Hide it";
      } else if (user2Button.textContent == "Hide it") {
        user2hiddenElements.style.display = "none";
        user2Button.textContent = "Show more";
      }
    }
  });

  user3Button.addEventListener("click", () => {
    let user3UnlockedElement = document.querySelectorAll('input[value="unlock"]')[2];
    let user3LockedElement = document.querySelectorAll('input[value="lock"]')[2];

    if (user3UnlockedElement.checked == true) {
      if (user3Button.textContent == "Show more") {
        user3hiddenElements.style.display = "block";
        user3Button.textContent = "Hide it";
      } else if (user3Button.textContent == "Hide it") {
        user3hiddenElements.style.display = "none";
        user3Button.textContent = "Show more";
      }
    }
  });
}
