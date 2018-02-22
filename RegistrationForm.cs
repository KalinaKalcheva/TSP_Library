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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {

        }

        Func f = new Func();

        private void button1_Click(object sender, EventArgs e)
        {
            Reader r = new Reader();

            r.FirstName1 = textBox1.Text;
            r.Surname1 = textBox2.Text;
            r.EMail1 = textBox3.Text;
            r.PhoneNumber1 = textBox4.Text;

            f.InsertReader(r);
            //b.GetID(p, label7);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";



        }
    }
}
