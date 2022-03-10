import {monthCalendarView} from './montlyView.js';
let allMonthsList = document.querySelectorAll('.monthCalendar');
let allDaysInMonths = document.querySelectorAll('.daysCalendar');


export function renderYears() {
    let allYears = document.getElementById('years');
    let yearButtons = allYears.querySelectorAll('.day');

    //Hiding everything expect years' list
    allMonthsList.forEach(month => month.style.display = 'none');
    allDaysInMonths.forEach(day => day.style.display = 'none');
    allYears.style.display = 'block';

    //Render months in year if clicked
    yearButtons.forEach(year => year.addEventListener('click', () => {
        monthCalendarView(year.children[0].textContent);
        allYears.style.display = 'none';
    }));
}

export function renderYear(year) {
    //Show requested year if caption is clicked
    let yearToShow = document.getElementById(`year-${year}`);
    yearToShow.style.display = 'block';
}

renderYears();