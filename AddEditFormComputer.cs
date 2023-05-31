using Hardware_Shop.Entities;
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
    public partial class AddEditFormComputer : Form
    {
        private Computer _computer;
        public AddEditFormComputer()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        public AddEditFormComputer(Computer computer):this()
        {
            _computer = computer;  
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _computer.GraphicsCard = tbGraphicsCard.Text;
            _computer.Price = upDPrice.Value;
            _computer.Brand = tbBrand.Text;
            _computer.Storage = (int)upDStorage.Value;
            _computer.Processor = tbProcessor.Text;
            _computer.RAM = (int)upDRam.Value;
        }

        private void AddEditFormComputer_Load(object sender, EventArgs e)
        {
            tbGraphicsCard.Text = _computer.GraphicsCard;
            upDPrice.Value = _computer.Price;
            tbBrand.Text  = _computer.Brand;
            upDStorage.Value =  _computer.Storage;
            tbProcessor.Text = _computer.Processor;
            upDRam.Value = _computer.RAM;
        }

        private void tbBrand_Validating(object sender, CancelEventArgs e)
        {
            string name = tbBrand.Text.ToString();
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("The name cannot be empty!");
                }

                if (name.Length < 3)
                {
                    throw new ArgumentException("The name must be longer!");
                }

                
                errorProvider.SetError(tbBrand, ""); 
            }

            catch (ArgumentException ex)
            {
                
                errorProvider.SetError(tbBrand, ex.Message);
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void tbProcessor_Validating(object sender, CancelEventArgs e)
        {
            string name = tbProcessor.Text.ToString();
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("The name cannot be empty!");
                }

                if (name.Length < 3)
                {
                    throw new ArgumentException("The name must be longer!");
                }


                errorProvider.SetError(tbProcessor, "");
            }

            catch (ArgumentException ex)
            {

                errorProvider.SetError(tbProcessor, ex.Message);
                e.Cancel = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void tbGraphicsCard_Validating(object sender, CancelEventArgs e)
        {
            string name = tbGraphicsCard.Text.ToString();
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("The name cannot be empty!");
                }

                if (name.Length < 3)
                {
                    throw new ArgumentException("The name must be longer!");
                }


                errorProvider.SetError(tbGraphicsCard, "");
            }

            catch (ArgumentException ex)
            {

                errorProvider.SetError(tbGraphicsCard, ex.Message);
                e.Cancel = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void AddEditFormComputer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
