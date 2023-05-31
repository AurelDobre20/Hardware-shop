using Hardware_Shop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hardware_Shop
{
    public partial class AddComponentOrPc : Form
    {
        private   List<Computer> computers = new List<Computer>();
        private List<Entities.Component> componentsList = new List<Entities.Component>();
        private string ConnectionString = "Data Source=database1.db";
        
        public AddComponentOrPc()
        {
            InitializeComponent();
            LoadComputers();
            displayComputers();
            LoadComponents();
            displayComponents();
            this.KeyPreview = true;
        }

        private void AddComponentOrPc_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminOrCustomer admin = new AdminOrCustomer();
            admin.Show();
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



        private void addComputerBtn_Click(object sender, EventArgs e)
        {
            var computer = new Computer();
            AddEditFormComputer form = new AddEditFormComputer(computer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //computers.Add(computer);
                
                AddComputer(computer);
                displayComputers();

            }
        }


        private void deleteBtnComputer_Click(object sender, EventArgs e)
        {
            if (lvComputers.SelectedItems.Count > 0)
            {
                ListViewItem selectedComputerItem = lvComputers.SelectedItems[0];
                Computer selectedComputer = (Computer)selectedComputerItem.Tag;


                //computers.Remove(selectedComputer);


                lvComputers.Items.Remove(selectedComputerItem);
                DeleteComputer(selectedComputer);
            }
        }

        private void editBtnComputer_Click(object sender, EventArgs e)
        {
            var selectedItem = lvComputers.SelectedItems.Count > 0 ? lvComputers.SelectedItems[0] : null;
            if (selectedItem != null)
            {
                var computer = selectedItem.Tag as Computer;
                AddEditFormComputer form = new AddEditFormComputer(computer);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    displayComputers();
                    UpdateComputer(computer);
                }
            }
        }

        private void addComponentBtn_Click(object sender, EventArgs e)
        {
            var comp = new Entities.Component();
            AddEditFormComponent form = new AddEditFormComponent(comp);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //componentsList.Add(comp);
                AddComponent(comp);
                displayComponents();
            }
        }

        private void deleteBtnComp_Click(object sender, EventArgs e)
        {
            if (lvComp.SelectedItems.Count > 0)
            {
                ListViewItem selectedCompItem = lvComp.SelectedItems[0];
                Entities.Component selectedComp = (Entities.Component)selectedCompItem.Tag;


                //componentsList.Remove(selectedComputer);
                DeleteComponent(selectedComp);


                lvComp.Items.Remove(selectedCompItem);
            }
        }

        private void editBtnComp_Click(object sender, EventArgs e)
        {
            var selectedItem = lvComp.SelectedItems.Count > 0 ? lvComp.SelectedItems[0] : null;
            if (selectedItem != null)
            {
                var comp = selectedItem.Tag as Entities.Component;
                AddEditFormComponent form = new AddEditFormComponent(comp);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateComponent(comp);
                    displayComponents();
                }
            }
        }



       

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            /*FileStream stream = File.Create("serialized.bin");
            try {
                formatter.Serialize(stream, participants);
            }
            finally {
                stream.Dispose();
            }*/
            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, computers);
            }
        }

        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                computers = (List<Computer>)formatter.Deserialize(stream);
                displayComputers();
            }
        }

        private void componentToBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            /*FileStream stream = File.Create("serialized.bin");
            try {
                formatter.Serialize(stream, participants);
            }
            finally {
                stream.Dispose();
            }*/
            using (FileStream stream = File.Create("serialized2.bin"))
            {
                formatter.Serialize(stream, componentsList);
            }
        }

        private void componentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized2.bin"))
            {
                componentsList = (List<Entities.Component>)formatter.Deserialize(stream);
                displayComponents();
            }
        }

        private void AddComputer(Computer computer)
        {
            var query = "insert into Computers(Brand, Processor, RAM, Storage, GraphicsCard, Price)" +
                            " values(@brand, @processor, @ram, @storage, @graphicscard, @price2);  " +
                            "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@brand", computer.Brand);
                        command.Parameters.AddWithValue("@processor", computer.Processor);
                        command.Parameters.AddWithValue("@ram", computer.RAM);
                        command.Parameters.AddWithValue("@storage", computer.Storage);
                        command.Parameters.AddWithValue("@graphicscard", computer.GraphicsCard);
                        command.Parameters.AddWithValue("@price2", computer.Price);

                        computer.computerId = (long)command.ExecuteScalar();

                        transaction.Commit(); 
                        computers.Add(computer); 
                    }
                    catch (Exception)
                    {
                        transaction.Rollback(); 
                        throw; 
                    }
                }
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

        private void UpdateComputer(Computer computer)
        {
            var query = "UPDATE Computers SET Brand = @brand, Processor = @processor, RAM = @ram, Storage = @storage, GraphicsCard = @graphicscard, Price = @price WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@brand", computer.Brand);
                command.Parameters.AddWithValue("@processor", computer.Processor);
                command.Parameters.AddWithValue("@ram", computer.RAM);
                command.Parameters.AddWithValue("@storage", computer.Storage);
                command.Parameters.AddWithValue("@graphicscard", computer.GraphicsCard);
                command.Parameters.AddWithValue("@price", computer.Price);
                command.Parameters.AddWithValue("@id", computer.computerId);

                command.ExecuteNonQuery();
            }
        }

        private void AddComponent(Entities.Component component)
        {
            var query = "INSERT INTO Components (Name, Type, Manufacturer, Model, Price)" +
                        "VALUES (@name, @type, @manufacturer, @model, @price); " +
                        "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@name", component.Name);
                        command.Parameters.AddWithValue("@type", component.Type);
                        command.Parameters.AddWithValue("@manufacturer", component.Manufacturer);
                        command.Parameters.AddWithValue("@model", component.Model);
                        command.Parameters.AddWithValue("@price", component.Price);

                        component.componentId = Convert.ToInt32(command.ExecuteScalar());

                        transaction.Commit(); 
                        componentsList.Add(component); 
                    }
                    catch (Exception)
                    {
                        transaction.Rollback(); 
                        throw; 
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

        private void UpdateComponent(Entities.Component component)
        {
            var query = "UPDATE Components SET Name = @name, Type = @type, Manufacturer = @manufacturer, Model = @model, Price = @price WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", component.Name);
                command.Parameters.AddWithValue("@type", component.Type);
                command.Parameters.AddWithValue("@manufacturer", component.Manufacturer);
                command.Parameters.AddWithValue("@model", component.Model);
                command.Parameters.AddWithValue("@price", component.Price);
                command.Parameters.AddWithValue("@id", component.componentId);

                command.ExecuteNonQuery();
            }
        }

        private void AddComponentOrPc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
