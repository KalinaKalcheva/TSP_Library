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
    public partial class RentBook : Form
    {
         public RentBook()
        {
           
        }
         public RentBook(Book b)
         {
            InitializeComponent();
            label2.Text = b.Title1;
            label3.Text = b.Author1;
            label4.Text = b.Genre1;
        }
       


         Func f = new Func();

        private void RentBook_Load(object sender, EventArgs e)
        {
            
            List<Reader> allReaders = new List<Reader>();
            allReaders = f.ListAllReaders();
            
            foreach (Reader r in allReaders)
            {
                comboBox1.Items.Add(r.ID1.ToString() + " " + r.FirstName1 + " " + r.Surname1 + " "+r.PhoneNumber1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            Reader r = new Reader();

            r.ID1=comboBox1.
        }
    }
}
