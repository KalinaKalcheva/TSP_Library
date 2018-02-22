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
    public partial class SearchReadersForm : Form
    {
        public SearchReadersForm()
        {
            InitializeComponent();
        }

        Func f = new Func();
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            Reader re = new Reader();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("FirstName");
            listView1.Columns.Add("Surname");
            listView1.Columns.Add("EMail");
            listView1.Columns.Add("PhoneNumber");
            listView1.Columns.Add("Book");

            if (radioButton1.Checked)   //search by first name
            {
                listView1.Items.Clear();

                re.FirstName1 = textBox1.Text;

                List<Reader> matches = new List<Reader>();
                matches = f.SearchReaderName(re);
                foreach (Reader r in matches)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { r.ID1.ToString(), r.FirstName1, r.Surname1, r.EMail1, r.PhoneNumber1, r.Book1 }));
                }
            }

            else if (radioButton2.Checked) //search by surname
            {
                listView1.Items.Clear();

                re.Surname1 = textBox1.Text;

                List<Reader> matches = new List<Reader>();
                matches = f.SearchReaderSurname(re);
                foreach (Reader r in matches)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { r.ID1.ToString(), r.FirstName1, r.Surname1, r.EMail1, r.PhoneNumber1, r.Book1 }));
                }
            }

            else if (radioButton3.Checked) //search by Email
            {
                listView1.Items.Clear();

                re.EMail1 = textBox1.Text;

                List<Reader> matches = new List<Reader>();
                matches = f.SearchReaderEmail(re);
                foreach (Reader r in matches)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { r.ID1.ToString(), r.FirstName1, r.Surname1, r.EMail1, r.PhoneNumber1, r.Book1 }));
                }
            }

            else if (radioButton4.Checked) //search by Phone number
            {
                listView1.Items.Clear();

                re.PhoneNumber1 = textBox1.Text;

                List<Reader> matches = new List<Reader>();
                matches = f.SearchReaderNumber(re);
                foreach (Reader r in matches)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { r.ID1.ToString(), r.FirstName1, r.Surname1, r.EMail1, r.PhoneNumber1, r.Book1 }));
                }
            }

            else if(radioButton5.Checked)
            {
                List<Reader> allReaders = new List<Reader>();
                allReaders = f.ListAllReaders();

                foreach (Reader r in allReaders)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { r.ID1.ToString(), r.FirstName1, r.Surname1, r.EMail1, r.PhoneNumber1, r.Book1 }));
                }
    
            }
        }

        private void SearchReadersForm_Load(object sender, EventArgs e)
        {

        }
   


    }
}
