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
   
    public partial class AddEditFormComponent : Form
    {
        private Entities.Component _component;
        public AddEditFormComponent()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public AddEditFormComponent(Entities.Component component):this()
        {
            _component = component;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _component.Manufacturer = tbManu.Text.ToString();
            _component.Price = upDPrice.Value;
            _component.componentId = (int)upDId.Value;
            _component.Model = tbModel.Text.ToString();
            _component.Name = tbName.Text.ToString();
            _component.Type = tbType.Text.ToString();
        }

        private void AddEditFormComponent_Load(object sender, EventArgs e)
        {
             tbManu.Text =  _component.Manufacturer;
            upDPrice.Value = _component.Price;
            upDId.Value = _component.componentId;
            tbModel.Text = _component.Model;
            tbName.Text = _component.Name;
            tbType.Text = _component.Type;
        }

        

        private void tbManu_Validating(object sender, CancelEventArgs e)
        {
            string name = tbManu.Text.ToString();
            if (name.Length < 3)
            {
                errorProvider.SetError(tbManu, "The name must be longer!");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(tbManu, "");
            }
        }

        private void tbModel_Validating(object sender, CancelEventArgs e)
        {
            string name = tbModel.Text.ToString();
            if (name.Length < 3)
            {
                errorProvider.SetError(tbModel, "The name must be longer!");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(tbModel, "");
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            string name = tbName.Text.ToString();
            if (name.Length < 3)
            {
                errorProvider.SetError(tbName, "The name must be longer!");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(tbName, "");
            }
        }

        private void tbType_Validating(object sender, CancelEventArgs e)
        {
            string name = tbType.Text.ToString();
            if (name.Length < 3)
            {
                errorProvider.SetError(tbType, "The name must be longer!");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(tbType, "");
            }
        }

        private void AddEditFormComponent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
