function day(year, month, day) {
     let date = new Date(`${year}-${month}-${day}`);
     //Previous day conversion
     const timeStamp = date.getTime();
     const previousDay = timeStamp - 24*60*1000;
     let rightDate = new Date(previousDay);
     //Removing zero from month
     year = rightDate.getFullYear();
     month = rightDate.getMonth() + 1;
     day = rightDate.getDate();

     if(month.length < 2) {
         month = month.slice(0, 1);
     }
     //Printing
     console.log(`${year}-${month}-${day}`);
}
day(2016, 10, 1);