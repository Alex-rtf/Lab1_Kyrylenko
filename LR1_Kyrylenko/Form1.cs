using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Kyrylenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "Alex" && textBox_Password.Text == "123")
            {
                label_Correct.BackColor = Color.Green;
                Form2 s = new Form2();
                s.Show();
            }
            else
            {
                label_Correct.BackColor = Color.Red;
                textBox_Login.Text = "";
                textBox_Password.Text = "";
                MessageBox.Show("Error login or password. Please, try again.");
            }
        }
    }
}
