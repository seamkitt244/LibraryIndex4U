using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryIndex
{
    public partial class Form1 : Form
    {
        List<Book> booksList = new List<Book>();
        List<string> readList = new List<String>();
        List<int> referenceBook = new List<int>();
        public Form1()
        {
            InitializeComponent();
            readList = File.ReadAllLines("BooksFile.txt").ToList();

            for (int i = 0; i < readList.Count; i += 2)
            {
                int reference = Convert.ToInt32(readList[i]);
                string title = Convert.ToString(readList[i + 1]);
                Book b = new Book(reference, title);
                booksList.Add(b);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Book hs in booksList)//had to make this list to convert the Book objects to int
            {
                referenceBook.Add(Convert.ToInt32(hs.reference));
            }
            
            int referenceLinear =Convert.ToInt32( referenceInput.Text);
            Boolean findLinear = LinearSearch(referenceBook, referenceLinear);


            int referenceBinary = Convert.ToInt32(referenceInput.Text);
            Boolean findBinary = BinarySearch(referenceBook, referenceBinary);
        }
        public Boolean LinearSearch(List<int> searchList, int searchValue)
        {
            foreach (int s in searchList)
            {
                if (s == searchValue)
                {
                    linearOutput.Text = booksList[referenceBook.IndexOf(s)].title + "";
                    return true;
                }
            }
            linearOutput.Text = "This book isn't in the database";
            return false;
        }
        public Boolean BinarySearch(List<int> searchList, int searchValue)
        {
            int low = 0;
            int high = searchList.Count - 1;

            while (high >= low)
            {
                int middle = (low + high) / 2;

                if (searchList[middle] == searchValue)
                {
                    binaryOutput.Text = booksList[referenceBook.IndexOf(searchValue)].title + "";
                    return true;
                }
                else if (searchList[middle] < searchValue)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            binaryOutput.Text = "This book isn't in the database";
            return false;
        }
    }
}
