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
            Name.WriteLine( txtbxFirstname.Text + "," + txtlast.Text + "," + txtcontact.Text + "," + txtemail.Text + "," + txtcity.Text + "," + date.Text);
            Name.Close();
            

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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}