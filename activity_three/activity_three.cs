using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string raw = " ";
            
            //CheckBox1 = Japan
            if (checkBox1.Checked == true)
            {
                raw = raw + checkBox1.Text;
                raw += " ";
            }
            //CheckBox2 = South Korea
            if (checkBox2.Checked == true)
            {
                raw = raw + checkBox2.Text;
                raw += " ";
            }
            //CheckBox3 = America
            if (checkBox3.Checked == true)
            {
                raw = raw + checkBox3.Text;
                raw += " ";
            }
            //CheckBox4 = Thailand
            if (checkBox4.Checked == true)
            {
                raw = raw + checkBox4.Text;
                raw += " ";
            }
            //othersBox = Others
            if (othersBox.Checked == true)
            {
                raw = raw + textBox1.Text;
                raw += " ";
            }

            if (raw != null)
            {
                MessageBox.Show("You Selected : \n" + raw + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit");
            this.Close();
        }

        private void othersBox_CheckedChanged(object sender, EventArgs e)
        {
            if (othersBox.Checked == true)
            {
                label3.Visible = false;
                textBox1.Visible = false;
            }
            else {
                label3.Visible = true;
                textBox1.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
