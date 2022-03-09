class Stringer {
    #initialState;
  constructor(initialString, initialLength) {
    this.innerString = initialString;
    this.#initialState = initialString;
    this.innerLength = initialLength;
  }

  increase(length) {
    this.innerLength += length;
  }

  decrease(length) {
    if (this.innerLength - length < 0) {
      this.innerLength = 0;
    } else {
      this.innerLength -= length;
    }
  }

  toString() {
    if (this.innerString.length > this.innerLength) {
        this.innerString = this.innerString.substring(0, this.innerLength);
      this.innerString += "...";
    }else if(this.innerString.length < this.innerLength) {
        this.innerString = this.#initialState.substring(0, this.innerLength++);
    } else if (this.innerLength == 0) {
      return "...";
    }
    return this.innerString;
  }
}

let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4);
console.log(test.toString()); // Test
