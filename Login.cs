using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Shop
{
    public partial class Login : Form
    {
        private string username = "admin";
        private string password = "admin";
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

       

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.ToString() == password && tbUsername.Text.ToString() == username)
            {
                AddComponentOrPc addComponentOrPc = new AddComponentOrPc();
                addComponentOrPc.Show();
                this.Hide();
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
