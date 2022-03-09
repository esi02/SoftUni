function pie(arr, startFlavor, endFlavor) {
    let start = arr.indexOf(startFlavor);
    let end = arr.indexOf(endFlavor);

    let modifiedArr = arr.slice(start, end + 1);
    return modifiedArr;
}
console.log(pie(['Apple Crisp',
'Mississippi Mud Pie',
'Pot Pie',
'Steak and Cheese Pie',
'Butter Chicken Pie',
'Smoked Fish Pie'],
'Pot Pie',
'Smoked Fish Pie'
));