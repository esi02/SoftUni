function solve(first, second, third) {

     let firstArgumentLength = first.length;
     let secondArgumentLength = second.length;
     let thirdArgumentLentgh = third.length;

     let sumLength;
     let averageLength;
     sumLength = firstArgumentLength + secondArgumentLength + thirdArgumentLentgh;
     averageLength = Math.floor(sumLength / 3);
     
     console.log(sumLength);
     console.log(averageLength);
}

solve('pasta', '5', '22.3');