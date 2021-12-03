using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;
        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books, new BookComparator());
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;
            public LibraryIterator(IEnumerable<Book> Books)
            {
                this.Reset();
                this.books = new List<Book>(Books);
            }
            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;
            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < this.books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
