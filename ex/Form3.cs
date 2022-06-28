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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Vac = new StreamWriter(@"C:\Users\PC16\source\repos\ex\ex\name\Vaccine.txt",true);
            Vac.WriteLine("Vaccine:" + txtvac.Text);
            Vac.Close();
            if (MessageBox.Show("Thank You For Your Response", "Thank You", MessageBoxButtons.OK)==DialogResult.OK)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }

        private void cb1(object sender, EventArgs e)
        {

        }

        private void cb2(object sender, EventArgs e)
        {
            
        }

        private void cb3(object sender, EventArgs e)

        {

        }
    }
}
