using Hardware_Shop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Shop
{
    public partial class Shop : Form
    {

        private List<Computer> computers = new List<Computer>();
        private List<Computer> computersCart = new List<Computer>();
        private List<Entities.Component> componentsList = new List<Entities.Component>();
        private List<Entities.Component> componentsListCart = new List<Entities.Component>();
        private string ConnectionString = "Data Source=database1.db";
        public Shop()
        {
            InitializeComponent();
            LoadComputers();
            displayComputers();
            LoadComponents();
            displayComponents();
            this.KeyPreview = true;
        }

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminOrCustomer adminOrCustomer = new AdminOrCustomer();
            adminOrCustomer.Show();
        }

        public void displayComputers()
        {
            lvComputers.Items.Clear();

            foreach (var computer in computers)
            {
                var listViewItem = new ListViewItem(computer.Brand);
                listViewItem.SubItems.Add(computer.Processor);
                listViewItem.SubItems.Add(computer.RAM.ToString());
                listViewItem.SubItems.Add(computer.Storage.ToString());
                listViewItem.SubItems.Add(computer.GraphicsCard);
                listViewItem.SubItems.Add(computer.Price.ToString());

                listViewItem.Tag = computer;

                lvComputers.Items.Add(listViewItem);

            }
        }

        public void displayComputersCart()
        {
            lvComputersCart.Items.Clear();

            foreach (var computer in computersCart)
            {
                var listViewItem = new ListViewItem(computer.Brand);
                listViewItem.SubItems.Add(computer.Processor);
                listViewItem.SubItems.Add(computer.RAM.ToString());
                listViewItem.SubItems.Add(computer.Storage.ToString());
                listViewItem.SubItems.Add(computer.GraphicsCard);
                listViewItem.SubItems.Add(computer.Price.ToString());

                listViewItem.Tag = computer;

                lvComputersCart.Items.Add(listViewItem);

            }
        }
        private void LoadComputers()
        {
            const string query = "SELECT * FROM Computers";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string brand = (string)reader["Brand"];
                        string processor = (string)reader["Processor"];
                        long ram = (long)reader["RAM"];
                        long storage = (long)reader["Storage"];
                        string graphicsCard = (string)reader["GraphicsCard"];
                        long price = (long)reader["Price"];



                        Computer computer = new Computer(id, brand, processor, ram, storage, graphicsCard, price);
                        computers.Add(computer);

                    }
                }
            }
        }

        private void LoadComponents()
        {
            const string query = "SELECT * FROM Components";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int componentId = Convert.ToInt32(reader["Id"]);
                        string name = reader["Name"].ToString();
                        string type = reader["Type"].ToString();
                        string manufacturer = reader["Manufacturer"].ToString();
                        string model = reader["Model"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);

                        Entities.Component component = new Entities.Component(componentId, name, type, manufacturer, model, price);
                        componentsList.Add(component);
                    }
                }
            }
        }

        public void displayComponents()
        {
            lvComp.Items.Clear();

            foreach (var comp in componentsList)
            {
                var listViewItem = new ListViewItem(comp.Name);
                listViewItem.SubItems.Add(comp.Type);
                listViewItem.SubItems.Add(comp.Manufacturer.ToString());
                listViewItem.SubItems.Add(comp.Model.ToString());
                listViewItem.SubItems.Add(comp.Price.ToString());


                listViewItem.Tag = comp;

                lvComp.Items.Add(listViewItem);

            }
        }
        public void displayComponentsCart()
        {
            lvCompCart.Items.Clear();

            foreach (var comp in componentsListCart)
            {
                var listViewItem = new ListViewItem(comp.Name);
                listViewItem.SubItems.Add(comp.Type);
                listViewItem.SubItems.Add(comp.Manufacturer.ToString());
                listViewItem.SubItems.Add(comp.Model.ToString());
                listViewItem.SubItems.Add(comp.Price.ToString());


                listViewItem.Tag = comp;

                lvCompCart.Items.Add(listViewItem);

            }
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            if (lvComputers.SelectedItems.Count > 0)
            {
                ListViewItem selectedComputerItem = lvComputers.SelectedItems[0];
                Computer selectedComputer = (Computer)selectedComputerItem.Tag;


                var computer = new Computer();
                computer.RAM = selectedComputer.RAM;
                computer.computerId = selectedComputer.computerId;
                computer.Price = selectedComputer.Price;
                computer.Brand = selectedComputer.Brand;
                computer.Processor = selectedComputer.Processor;
                computer.Storage = selectedComputer.Storage;

                


                lvComputers.Items.Remove(selectedComputerItem);
                DeleteComputer(selectedComputer);

                computersCart.Add(computer);
                displayComputersCart();
            }
            if (lvComp.SelectedItems.Count > 0)
            {
                ListViewItem selectedCompItem = lvComp.SelectedItems[0];
                Entities.Component selectedComp = (Entities.Component)selectedCompItem.Tag;

                var comp = new Entities.Component();
                comp.Name = selectedComp.Name;
                comp.Type = selectedComp.Type;
                comp.Manufacturer = selectedComp.Manufacturer;
                comp.Model = selectedComp.Model;
                comp.Price = selectedComp.Price;



                
                lvComp.Items.Remove(selectedCompItem);
                DeleteComponent(selectedComp);


                componentsListCart.Add(comp);
                displayComponentsCart();
            }
        }

        private void DeleteComputer(Computer computer)
        {
            const string query = "DELETE FROM Computers WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", computer.computerId);

                command.ExecuteNonQuery();

                
                computers.Remove(computer);
            }
        }

        private void DeleteComponent(Entities.Component component)
        {
            const string query = "DELETE FROM Components WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", component.componentId);

                command.ExecuteNonQuery();

                
                componentsList.Remove(component);
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            lvCompCart.Items.Clear();
            lvComputersCart.Items.Clear();
        }

        private void Shop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        
    }
}
