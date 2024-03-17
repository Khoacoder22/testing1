using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libbuhha
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }
        public void buttonb1_Click(object sender, EventArgs e)
        {
            string username = "1", passuser = "1";
            string name = rjTextBox1.Texts;
            string pass = rjTextBox2.Texts;

            if (name.Equals(username) && pass.Equals(passuser))
            {
                // If username and password match, display a success message
                label4.Show();
                label2.Hide(); 
            }
            else
            {
                // If username and/or password don't match, show an error message
                label2.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //hide 
        private void hide1_Click(object sender, EventArgs e)
        {
            if (rjTextBox2.PasswordChar == true)
            {
                show1.BringToFront();
                rjTextBox2.PasswordChar = false;
            }
        }
        
        private void show1_Click(object sender, EventArgs e)
        {
            if (rjTextBox2.PasswordChar == false)
            {
                hide1.BringToFront();
                rjTextBox2.PasswordChar = true;
            }
        }
    }
}
