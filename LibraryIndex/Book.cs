using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibraryIndex
{
    public class Book
    {
        public int reference;
        public string title;
        public Book(int _reference,string _title)
        {
            reference = _reference;
            title = _title; 
        }
    }
}
