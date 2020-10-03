using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lister {
    public partial class Form_RemoveTable : Form {
        //Data
        public Form_RemoveTable() {
            InitializeComponent();
            UpdateComboBox();
        }

        //Classes
        private void UpdateComboBox() {
            DatabaseCommands databaseCommands = new DatabaseCommands();
            DataTable dataTable = databaseCommands.SearchInDatabase("Select * from sqlite_master where name != 'Options' and name != 'sqlite_sequence';");
            foreach (DataRow i in dataTable.Rows) {
                ComboBox_Tables.Items.Add(i.Field<string>("name"));
            }
            ComboBox_Tables.SelectedItem = ComboBox_Tables.Items[0];
        }

        //Form Objs
        private void Button_Confirm_Click(object sender, EventArgs e) {
            if (ComboBox_Tables.Items.Count == 1) {
                Label_Error.Text = "Você não pode excluir sua única tabela!";
            } else {
                DatabaseCommands databaseCommands = new DatabaseCommands();
                databaseCommands.RemoveTable(ComboBox_Tables.SelectedItem.ToString());
                this.Close();
            }
        }
    }
}
