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
    public partial class AllReadersForm : Form
    {
        public AllReadersForm()
        {
            InitializeComponent();
        }
        Func f = new Func();

        private void AllReadersForm_Load(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
            
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("FirstName");
            listView1.Columns.Add("Surname");
            listView1.Columns.Add("EMail");
            listView1.Columns.Add("PhoneNumber");
            listView1.Columns.Add("Book");

            List<Reader> allReaders = new List<Reader>();
            allReaders = f.ListAllReaders();

            foreach (Reader r in allReaders)
            {
                listView1.Items.Add(new ListViewItem(new String[] { r.ID1.ToString(), r.FirstName1, r.Surname1, r.EMail1, r.PhoneNumber1, r.Book1 }));
            }
    
        }
        
    }
}
