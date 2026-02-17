using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WindowsFormTry : Form
    {
        public WindowsFormTry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string user = helloInput.Text;
        
            string select = comboBox1.SelectedItem.ToString();
            if (select == "ALL OF THE ABOVE")
            {
                MessageBox.Show("Hello " + user + " you are a major faggot. ");
            }
            else
            {
                MessageBox.Show("Hello " + user + " " + select);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
