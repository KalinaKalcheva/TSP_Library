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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        private void новЧитателToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void новаКнигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBookForm newBookForm = new NewBookForm();
            newBookForm.Show();
        }

        private void всичкиКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBooksForm allBooksForm = new AllBooksForm();
            allBooksForm.Show();
        }

        private void всичкиЧитателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllReadersForm allReadersForm = new AllReadersForm();
            allReadersForm.Show();
        }

        private void търсенеНаКнигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void търсенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchReadersForm searchReadersForm = new SearchReadersForm();
            searchReadersForm.Show();
        }

       
    }
}
