using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library1
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        public ListViewItem item;
        Func f = new Func();

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            Book b = new Book();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Book ID");
            listView1.Columns.Add("Book Title");
            listView1.Columns.Add("Book Author");
            listView1.Columns.Add("Book Genre");

            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();

            if (radioButton1.Checked) //търсене по заглавие
            {
                b.Title1 = textBox1.Text;

                List<Book> matches = new List<Book>();
                matches = f.SearchtBookTitle(b);

                foreach (Book bo in matches)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { bo.ID1.ToString(), bo.Title1, bo.Author1, bo.Genre1 }));
                }

            }

            else if (radioButton2.Checked) ///търсене по автор
            {
                b.Author1 = textBox1.Text;

                List<Book> matches = new List<Book>();
                matches = f.SearchtBookAuthor(b);

                foreach (Book bo in matches)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { bo.ID1.ToString(), bo.Title1, bo.Author1, bo.Genre1 }));
                }
            }

            else if (radioButton3.Checked) //търсене по жанр
            {
                b.Genre1 = textBox1.Text;

                List<Book> matches = new List<Book>();
                matches = f.SearchtBookGenre(b);

                foreach (Book bo in matches)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { bo.ID1.ToString(), bo.Title1, bo.Author1, bo.Genre1 }));
                }
            }

            else if (radioButton4.Checked)
            {
                List<Book> allBooks = new List<Book>();
                allBooks = f.ListAllBooks();

                foreach (Book bo in allBooks)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { bo.ID1.ToString(), bo.Title1, bo.Author1, bo.Genre1 }));
                }
            }
            else
            {
                MessageBox.Show("Please choose search type");
            }
        }

        public void заеманеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book rBook = new Book();
           
            ListViewItem item = listView1.SelectedItems[0];
            rBook.Title1 = item.SubItems[1].Text;
            rBook.Author1 = item.SubItems[2].Text;
            rBook.Genre1 = item.SubItems[3].Text;
            RentBook rentBook = new RentBook(rBook); 

            rentBook.Show();
        }

    }
}


