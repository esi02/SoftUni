function solve() {
  let input = document.getElementById("text").value;
  let currentCase = document.getElementById("naming-convention").value;
  let resultElement = document.getElementById("result");

  if (currentCase == "Camel Case") {
    input = input.toLowerCase();
    String.prototype.toCamelCase = function(str) {
      return str
          .replace(/\s(.)/g, function($1) { return $1.toUpperCase(); })
          .replace(/\s/g, '')
          .replace(/^(.)/, function($1) { return $1.toLowerCase(); });
    }
    input = input.toCamelCase(input);
    input = input.replace(' ', '');
    resultElement.textContent = input;
  } else if(currentCase == "Pascal Case") {
    input = input.toLowerCase();
    input = input.replace(/(\w)(\w*)/g,
    function (x0, x1, x2) { return x1.toUpperCase() + x2.toLowerCase();});
    input = input.replace(' ', '');
    resultElement.textContent = input;
  } else {
    resultElement.textContent = "Error!";
  }

}
