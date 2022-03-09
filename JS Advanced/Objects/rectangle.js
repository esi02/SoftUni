function create(widthInput, heightInput, colorInput) {
    colorInput = colorInput.replace(colorInput[0], colorInput[0].toUpperCase());

    let rectangle = {
        width: widthInput,
        height: heightInput,
        color: colorInput,
        calcArea: function () {
            return this.width * this.height;
        }
    };
    return rectangle;
}
let rect = create(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
