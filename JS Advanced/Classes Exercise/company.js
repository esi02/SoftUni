class Company {
  constructor() {
    this.departments = {};
  }

  addEmployee(name, salary, position, department) {
    if (name === null || name == "" || name == undefined) {
      throw new Error("Invalid input!");
    }
    if (salary === null || salary == "" || salary == undefined || salary < 0) {
      throw new Error("Invalid input!");
    }
    if (position === null || position == "" || position == undefined) {
      throw new Error("Invalid input!");
    }
    if (department === null || department == "" || department == undefined) {
      throw new Error("Invalid input!");
    }

    if (this.departments[department] === undefined) {
      this.departments[department] = {
        employees: [
          {
            name: name,
            salary: salary,
            position: position,
          },
        ],
      };
    } else {
      this.departments[department].employees.push({
        name: name,
        salary: salary,
        position: position,
      });
    }

    return `New employee is hired. Name: ${name}. Position: ${position}`;
  }

  bestDepartment() {
    let bestAverageSalary = Math.max();
    let bestDepartment = {};

    let arr = Object.entries(this.departments);

    for (const element of arr) {
      let departmentName = element[0];
      let employees = Object.values(element[1]);
      let allSalaries = employees[0].map((x) => x.salary);
      let total = allSalaries.reduce((a, b) => a + b);

      let average = total / allSalaries.length;

      if (average > bestAverageSalary) {
        bestAverageSalary = average;
        bestDepartment = element;
      }
    }

    let bestEmployees = Object.values(bestDepartment[1]);
    Object.values(bestDepartment[1])[0].sort((a, b) => b.salary - a.salary || a.name.localeCompare(b.name));

    let str = `Best Department is: ${bestDepartment[0]}` + '\n' + `Average salary: ${bestAverageSalary.toFixed(2)}` + '\n';

    str +=  Object.values(bestDepartment[1])[0].map(x => `${x.name} ${x.salary} ${x.position}`).join('\n');
    return str;
  }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
