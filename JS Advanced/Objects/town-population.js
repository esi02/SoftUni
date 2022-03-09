function registry(input) {
    let towns = [];
    for (const town of input) {
        let splitted = town.split(' <-> ');
        let townName = splitted[0];
        let townPopulation = Number(splitted[1]);

        if(towns[townName] == undefined) {
            towns[townName] = 0;
        }

        towns[townName] += townPopulation;
    }

    for (const key in towns) {
        console.log(`${key} : ${towns[key]}`);
    }
}
registry(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
);