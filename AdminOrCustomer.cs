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
    public partial class AdminOrCustomer : Form
    {
        

        public AdminOrCustomer()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AdminOrCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(); 
            shop.Show();
            this.Hide();
        }

        private void AdminOrCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
