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
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
        }

        Func f = new Func();

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book();

            b.Title1 = textBox1.Text;
            b.Author1 = textBox2.Text;
            b.Genre1 = textBox3.Text;
           

            f.InsertBook(b);
            //b.GetID(p, label7);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            

        }
    }
}
