import {renderYear, renderYears} from './app.js';

export function monthCalendarView(year) {
    let allMonthsForTheYear = document.getElementById(`year-${year}`);
    let allDaysForTheMonth = allMonthsForTheYear.querySelectorAll('.day');
    allMonthsForTheYear.style.display = 'block';

    allMonthsForTheYear.querySelectorAll('caption').forEach(caption => caption.addEventListener('click', () => {
        //Hide months and show years if clicked
        renderYears();
    }));

    allDaysForTheMonth.forEach(days => days.addEventListener('click', () => {
        //Show days in clicked month and hide other months
        renderDays(days.children[0].textContent, year);
        allMonthsForTheYear.style.display = 'none';
    }));
}

function renderDays(monthName, year) {
    const months = {
        'Jan': 1,
        'Feb': 2,
        'Mar': 3,
        'Apr': 4,
        'May': 5,
        'Jun': 6,
        'Jul': 7,
        'Aug': 8,
        'Sept': 9,
        'Oct': 10,
        'Nov': 11,
        'Dec': 12
    }
    let days = document.getElementById(`month-${year}-${months[monthName]}`);
    days.style.display = 'block';
    
    //If clicked go back to month and hide days
    days.querySelector('caption').addEventListener('click', () => {
        days.style.display = 'none';
        renderYear(year);
    })
}
