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
    public partial class AllBooksForm : Form
    {
        public AllBooksForm()
        {
            InitializeComponent();
        }

        Func f = new Func();
        private void AllBooksForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Title");
            listView1.Columns.Add("Author");
            listView1.Columns.Add("Genre");
 

            List<Book> allBooks = new List<Book>();
            allBooks= f.ListAllBooks();

            foreach (Book b in allBooks)
            {
                listView1.Items.Add(new ListViewItem(new String[] { b.ID1.ToString(), b.Title1, b.Author1, b.Genre1}));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}

