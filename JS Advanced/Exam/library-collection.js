class LibraryCollection {
    books = [];
    constructor(capacity) {
        this.capacity = capacity;
    }

    addBook(bookName, bookAuthor) {
        if (this.books.length == this.capacity) {
            throw new Error("Not enough space in the collection.");
        }
        this.books.push({
            bookName,
            bookAuthor,
            payed: false
        });

        return `The ${bookName}, with an author ${bookAuthor}, collect.`;
    }

    payBook(bookName) {
        let book = this.books.find(x => x.bookName == bookName);

        if (book == undefined) {
            throw new Error(`${bookName} is not in the collection.`);
        } else if(book.payed == true) {
            throw new Error(`${bookName} has already been paid.`);
        }

        book.payed = true;
        return `${bookName} has been successfully paid.`;
    }

    removeBook(bookName) {
        let book = this.books.find(x => x.bookName == bookName);

        if (book == undefined) {
            throw new Error("The book, you're looking for, is not found.");
        } else if(book.payed == false) {
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }

        let index = this.books.indexOf(book);
        this.books.splice(index, 1);

        return `${bookName} remove from the collection.`;
    }

    getStatistics(bookAuthor) {
        if (bookAuthor === undefined) {
            let result = [];
            result.push(`The book collection has ${this.capacity - this.books.length} empty spots left.`);
            this.books.sort((a, b) => a.bookName - b.bookName)
                      .forEach(x => {
                          let hasPaid = x.payed == false ? 'Not Paid' : 'Has Paid';
                          result.push(`${x.bookName} == ${x.bookAuthor} - ${hasPaid}.`)
                        });
                        return result.join('\n');
        } else {
            let book = this.books.find(x => x.bookAuthor == bookAuthor);

            if (book == undefined) {
                throw new Error(`${bookAuthor} is not in the collection.`);
            }

            let hasPaid = book.payed == false ? 'Not Paid' : 'Has Paid';
            return `${book.bookName} == ${book.bookAuthor} - ${hasPaid}.`;
        }
    }
}

const library = new LibraryCollection(5)
library.addBook('Don Quixote', 'Miguel de Cervantes');
library.payBook('Don Quixote');
library.addBook('In Search of Lost Time', 'Marcel Proust');
library.addBook('Ulysses', 'James Joyce');
console.log(library.getStatistics());




