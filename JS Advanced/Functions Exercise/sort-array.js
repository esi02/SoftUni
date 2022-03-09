function sort(values, criteria) {
   return values.sort((a, b) => {
        if (criteria == 'asc') {
            return a - b;
        } else if(criteria == 'desc') {
            return b - a;
        }
    });
}

console.log(sort([14, 7, 17, 6, 8], 'desc'));