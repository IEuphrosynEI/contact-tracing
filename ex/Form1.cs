using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex
{
    public partial class COCOA : Form
    {
        public COCOA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Name = new StreamWriter(@"C:\Users\PC16\source\repos\ex\ex\name\Information.txt",true);
            Name.WriteLine("--------------------------------------------");
            Name.WriteLine("First Name: " + txtbxFirstname.Text );
            Name.WriteLine("Last Name: " + txtlast.Text);
            Name.WriteLine("Contact Number: " + txtcontact.Text);
            Name.WriteLine("E-mail Adress: " + txtemail.Text);
            Name.WriteLine("Town/ City of Residence: " + txtcity.Text);
            Name.Close();

            StreamReader reader = new StreamReader(@"C:\Users\PC16\source\repos\ex\ex\name\Information.txt");
            string all = reader.ReadToEnd();
            MessageBox.Show(all);
            this.Hide();
            Form2 f2 = new Form2();
             f2.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxFirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}