function attachEventsListeners() {
  let buttonsElements = document.querySelectorAll("input[type=button]");
 

  for (const button of buttonsElements) {
    if (button.id == "daysBtn") {
      button.addEventListener("click", () => {
        let daysInput = Number(document.getElementById('days').value);

        document.getElementById('hours').value = daysInput * 24;
        document.getElementById('minutes').value = daysInput * 1440;
        document.getElementById('seconds').value = daysInput * 86400;
      });
    } else if (button.id == "hoursBtn") {
      button.addEventListener("click", () => {
        let hoursInput = Number(document.getElementById('hours').value);

        document.getElementById('days').value = hoursInput / 24;
        document.getElementById('minutes').value = hoursInput * 60;
        document.getElementById('seconds').value = hoursInput * 60 * 60;
      });
    } else if (button.id == "minutesBtn") {
      button.addEventListener("click", () => {
        let minutesInput = Number(document.getElementById('minutes').value);

        document.getElementById('hours').value = minutesInput / 60;
        document.getElementById('days').value = minutesInput / 60 / 24;
        document.getElementById('seconds').value = minutesInput * 60;
      });
    } else {
      button.addEventListener("click", () => {
        let secondsInput = Number(document.getElementById('seconds').value);

        document.getElementById('minutes').value = secondsInput / 60;
        document.getElementById('hours').value = secondsInput / 60 / 60;
        document.getElementById('days').value = secondsInput / 60 / 60 / 24;
      });
    }
  }


}
