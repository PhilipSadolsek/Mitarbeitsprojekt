using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeitsprojekt
{
    public partial class DatabaseForm : Form
    {
        public string SelectedDatabase;

        public DatabaseForm()
        {
            InitializeComponent();

            LoadComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxDatenbanken_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedDatabase = ComboBoxDatenbanken.Text;
        }

        public void LoadComboBox()
        {
            ComboBoxDatenbanken.Items.Clear();

            sqlManagement SqlManagement = new sqlManagement();


            foreach (var database in sqlManagement.databases)
            {
                ComboBoxDatenbanken.Items.Add(database);
            }
        }

        private void ButtonDatabaseDelete_Click(object sender, EventArgs e)
        {
            sqlManagement sqlManagement = new sqlManagement();

            string databaseToDelete = ComboBoxDatenbanken.SelectedItem.ToString();
            string selectedServer = "";

            sqlManagement.DeleteDatabase(selectedServer, databaseToDelete);
            ComboBoxDatenbanken.Text = "";

            LoadComboBox();
        }

        private void ButtonCreateDatabase_Click(object sender, EventArgs e)
        {
            sqlManagement sqlManagement = new sqlManagement();

            string NewDatabaseName = TextBoxCreateDatabase.Text;
            string selectedServer = "";

            sqlManagement.CreateDatabase(SelectedDatabase, NewDatabaseName);
            TextBoxCreateDatabase.Text = "";

            LoadComboBox();
        }

        private void TextBoxCreateDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDatabaseLoad_Click(object sender, EventArgs e)
        {
            string UsedDatabase = ComboBoxDatenbanken.Text;
        }
    }
}
