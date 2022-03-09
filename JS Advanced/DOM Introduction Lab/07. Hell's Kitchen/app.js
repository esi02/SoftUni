function solve() {
  document.querySelector("#btnSend").addEventListener("click", onClick);

  function onClick() {
    //Get the array
    let inputArray = document
      .querySelector("textarea")
      .value.replace(/\]|\[/gi, "")
      .split('", "');
    inputArray = inputArray.map((x) => x.replace('"', ""));
    let restaurants = [];

    //Extract restaurants and workers
    for (let i = 0; i < inputArray.length; i++) {
      let element = inputArray[i];
      let splittedElement = element.split(" - ");

      let workers = splittedElement[1].split(", ");
      let workerName = "";
      let workerSalary = 0;
      let workersAsObj = [];

      for (const worker of workers) {
        let splittedWorker = worker.split(" ");
        workerName = splittedWorker[0];
        workerSalary = Number(splittedWorker[1]);
        let obj = {
          name: workerName,
          salary: workerSalary,
        };
        workersAsObj.push(obj);
      }

      let restorAsObj = {
        name: splittedElement[0],
        workers: workersAsObj,
      };

      if (!restaurants.includes(restorAsObj.name)) {
        restaurants.push(restorAsObj);
      } else {
        let existingElement = restaurants.find(
          (x) => x.name == restorAsObj.name
        );
        existingElement.workers.push(restorAsObj.workers);
      }
    }


    //Average and best salary
    let averageSalaries = [];
    for (const restaurant of restaurants) {
       let salaries = restaurant.workers.map(x => x.salary);
       let averageSalary = salaries.reduce((a, b) => a + b) / salaries.length;
       averageSalaries.push(
          {
             restorauntName: restaurant.name,
             itsAverageSalary: Number(averageSalary.toFixed(2))
          }
       );
    }
    let bestAverageSalary = Math.max.apply(Math, averageSalaries.map(function (x) {return x.itsAverageSalary; }));
    let bestRestorauntName = averageSalaries.find(x => x.itsAverageSalary == bestAverageSalary).restorauntName;

    //Appending the result
    let bestRestorauntElement = restaurants.find(x => x.name == bestRestorauntName);
    let bestWorkers = bestRestorauntElement.workers.sort((a, b) => b.salary - a.salary);
    let biggestSalaryWorker = bestWorkers[0];

    let outputElement = document.getElementById('outputs');
    outputElement.querySelector('p').textContent = `Name: ${bestRestorauntName} Average Salary: ${bestAverageSalary} Best Salary: ${biggestSalaryWorker.salary.toFixed(2)}`;

    let workersElement = document.getElementById('workers');
    let textToAppend = '';
    
    bestWorkers.forEach(x => textToAppend += `Name: ${x.name} With Salary: ${x.salary} `);
    workersElement.querySelector('p').textContent = textToAppend;
  }
}
//["PizzaHut - Peter 500, George 300, Mark 800", "TheLake - Bob 1300, Joe 780, Jane 660"]
