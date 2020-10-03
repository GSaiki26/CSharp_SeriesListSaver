using Anime_Lister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lister {
    public partial class Form_Edit : Form {
        //Data
        private bool selected = false;
        private int key;
        private string name;
        private string status;
        public Form_Edit() {
            InitializeComponent();
            UpdateDataGrid();
            UpdateStatus();
        }

        //Classes
        private void UpdateDataGrid() {
            DatabaseCommands databaseCommands = new DatabaseCommands();
            DataGrid_Show.DataSource = databaseCommands.SearchInDatabase($"Select * from {databaseCommands.GetTable()};");
        }
        private void UpdateStatus() {
            ComboBox_Status.Items.Add(".Lançamento");
            ComboBox_Status.Items.Add("Assistindo");
            ComboBox_Status.Items.Add("Assistir");
            ComboBox_Status.Items.Add("Desistido");
            ComboBox_Status.Items.Add("Reassistindo");
            ComboBox_Status.Items.Add("Reassistir");
            ComboBox_Status.Items.Add("Terminado");
            ComboBox_Status.SelectedItem = ".Lançamento";
        }
        //Form Objs
        private void Button_Confirm_Click(object sender, EventArgs e) {
            if (TextBox_WorkName.Text.Length != 0 & selected.Equals(true)) {
                int a = DataGrid_Show.SelectedCells[0].RowIndex;
                string b = DataGrid_Show.Rows[a].Cells[1].Value.ToString();
                string c = DataGrid_Show.Rows[a].Cells[2].Value.ToString();
                if (TextBox_WorkName.Text == b & ComboBox_Status.Text == c) {
                    Label_Error.Text = "            Edite algo!";
                }
                else {
                    Label_Error.Text = "";
                    name = TextBox_WorkName.Text;
                    status = ComboBox_Status.Text;
                    DatabaseCommands databaseCommands = new DatabaseCommands();
                    databaseCommands.Edit(key, name, status);
                    Form_Success form_Success = new Form_Success("Sucesso ao editar a obra!");
                    form_Success.ShowDialog();
                    if (TextBox_Search.Text.Length != 0) {
                        TextBox_Search_TextChanged(sender, e);
                    }
                    else {
                        UpdateDataGrid();
                    }
                }
            } else if (TextBox_WorkName.Text.Length == 0) {
                Label_Error.Text = "Insira um nome válido!";
            } else {
                Label_Error.Text = "Selecione uma obra para editar!";
            }
        }
        private void DataGrid_Show_CellClick(object sender, DataGridViewCellEventArgs e) {
            selected = true;
            int a = DataGrid_Show.SelectedCells[0].RowIndex;
            key = int.Parse(DataGrid_Show.Rows[a].Cells[0].Value.ToString());
            DatabaseCommands databaseCommands = new DatabaseCommands();
            DataTable dataTable = databaseCommands.SearchInDatabase($"Select * from {databaseCommands.GetTable()} where Key='{key}'");
            name = dataTable.Rows[0].Field<string>("WorkName");
            status = dataTable.Rows[0].Field<string>("Status"); ;
            TextBox_WorkName.Text = name;
            ComboBox_Status.SelectedItem = status;
        }
        private void TextBox_Search_TextChanged(object sender, EventArgs e) {
            DatabaseCommands databaseCommands = new DatabaseCommands();
            if (TextBox_Search.Text.Length == 0) {
                UpdateDataGrid();
                Label_Error.Text = "";
            }
            else {
                DataTable dataTable = databaseCommands.SearchInDatabase($"Select * from {databaseCommands.GetTable()};");
                dataTable = databaseCommands.SearchInDatabase($"Select * from {databaseCommands.GetTable()} where WorkName Like '%{TextBox_Search.Text}%'");
                DataGrid_Show.DataSource = dataTable;
                if (dataTable.Rows.Count > 0) {
                    Label_Error.Text = "";
                }
                else {
                    selected = false;
                    Label_Error.Text = "Não foi possivel localizar!";
                }
            }
        }
    }
}
