function solve() {
    let firstNameInputElement = document.getElementById('fname');
    let lastNameInputElement = document.getElementById('lname');
    let emailInputElement = document.getElementById('email');
    let dateBirthInputElement = document.getElementById('birth');
    let positionInputElement = document.getElementById('position');
    let salaryInputElement = document.getElementById('salary');

    let hireButtonElement = document.getElementById('add-worker');
    let workersTableElement = document.getElementById('tbody');

    let budgetSalaryElement = document.getElementById('sum');

    hireButtonElement.addEventListener('click', (e) => {
        e.preventDefault();
        if (firstNameInputElement.value == '' ||
            lastNameInputElement.value == '' ||
            emailInputElement.value == '' ||
            dateBirthInputElement.value == '' ||
            positionInputElement.value == '' ||
            salaryInputElement.value == '') {
            return;
        }
        let rowElement = document.createElement('tr');

        let firstNameElement = document.createElement('td');
        firstNameElement.textContent = firstNameInputElement.value;

        let lastNameElement = document.createElement('td');
        lastNameElement.textContent = lastNameInputElement.value;

        let emailElement = document.createElement('td');
        emailElement.textContent = emailInputElement.value;

        let dateElement = document.createElement('td');
        dateElement.textContent = dateBirthInputElement.value;

        let positionElement = document.createElement('td');
        positionElement.textContent = positionInputElement.value;

        let salaryElement = document.createElement('td');
        salaryElement.textContent = salaryInputElement.value;

        let buttonsElement = document.createElement('td');
        let firedButton = document.createElement('button');
        firedButton.classList.add('fired');
        firedButton.textContent = 'Fired';

        let editButton = document.createElement('button');
        editButton.classList.add('edit');
        editButton.textContent = 'Edit';

        buttonsElement.appendChild(firedButton);
        buttonsElement.appendChild(editButton);

        rowElement.appendChild(firstNameElement);
        rowElement.appendChild(lastNameElement);
        rowElement.appendChild(emailElement);
        rowElement.appendChild(dateElement);
        rowElement.appendChild(positionElement);
        rowElement.appendChild(salaryElement);
        rowElement.appendChild(buttonsElement);

        workersTableElement.appendChild(rowElement);

        firstNameInputElement.value = '';
        lastNameInputElement.value = '';
        emailInputElement.value = '';
        dateBirthInputElement.value = '';
        positionInputElement.value = '';
        salaryInputElement.value = '';

        let newBudget = (Number(budgetSalaryElement.textContent) + Number(salaryElement.textContent)).toFixed(2);
        budgetSalaryElement.textContent = newBudget;

        editButton.addEventListener('click', () => {
            firstNameInputElement.value = firstNameElement.textContent;
            lastNameInputElement.value = lastNameElement.textContent;
            emailInputElement.value = emailElement.textContent;
            dateBirthInputElement.value = dateElement.textContent;
            positionInputElement.value = positionElement.textContent;
            salaryInputElement.value = salaryElement.textContent;

            workersTableElement.removeChild(rowElement);
            newBudget = (Number(budgetSalaryElement.textContent) - Number(salaryElement.textContent)).toFixed(2);
            budgetSalaryElement.textContent = newBudget;
        });

        firedButton.addEventListener('click', () => {
            workersTableElement.removeChild(rowElement);
            newBudget = (Number(budgetSalaryElement.textContent) - Number(salaryElement.textContent)).toFixed(2);
            budgetSalaryElement.textContent = newBudget;
        });
    });
}
solve()