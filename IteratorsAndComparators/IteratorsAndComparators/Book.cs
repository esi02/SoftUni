using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        private List<string> Authors;
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public int CompareTo(Book other)
        {
            if (this.Year.CompareTo(other.Year) > 0)
            {
                return 1;
            }
            else if (this.Year.CompareTo(other.Year) < 0)
            {
                return -1;
            }
            else
            {
                return this.Title.CompareTo(other.Title);
            }
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Year}"; 
        }
    }
}
