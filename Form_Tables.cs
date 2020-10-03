using Anime_Lister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lister {
    public partial class Form_Tables : Form {
        //Data
        bool select = false;
        public Form_Tables() {
            InitializeComponent();
            UpdateDataGrid();
        }

        //Classes
        private void UpdateDataGrid() {
            DatabaseCommands databaseCommands = new DatabaseCommands();
            DataGrid_Show.DataSource = databaseCommands.SearchInDatabase("Select * from sqlite_master where name!= 'Options' and name!='sqlite_sequence';");
        }

        //Form Objs
        private void Button_Confirm_Click(object sender, EventArgs e) {
            if (TextBox_Name.TextLength != 0) {
                if (select.Equals(true)) {
                    DatabaseCommands databaseCommands = new DatabaseCommands();
                    if (TextBox_Name.Text != DataGrid_Show.SelectedCells[0].Value.ToString()) {
                        string name = DataGrid_Show.SelectedCells[0].Value.ToString();
                        string newName = TextBox_Name.Text;
                        databaseCommands.EditTable(name, newName);
                    }
                    if (CheckBox_Define.Checked == true & DataGrid_Show.SelectedCells[0].Value != databaseCommands.GetTable()) {
                        databaseCommands.DefineAsMainTable(DataGrid_Show.SelectedCells[0].Value.ToString());
                    }
                    UpdateDataGrid();
                    Form_Success form_Success = new Form_Success("Sucesso ao editar a tabela!");
                    form_Success.ShowDialog();
                } else {
                    Label_Error.Location = new Point(23,192);
                    Label_Error.Text = "Selecione uma tabela para editar!";
                }
            } else {
                Label_Error.Location = new Point(45, 192);
                Label_Error.Text = "Digite um nome válido!";
            }
        }
        private void DataGrid_Show_CellClick(object sender, DataGridViewCellEventArgs e) {
            DatabaseCommands databaseCommands = new DatabaseCommands();
            if (DataGrid_Show.SelectedCells[0].Value.ToString() == databaseCommands.GetTable()) {
                CheckBox_Define.Checked = true;
                CheckBox_Define.Enabled = false;
            } else {
                CheckBox_Define.Checked = false;
                CheckBox_Define.Enabled = true;
            }
            select = true;
            TextBox_Name.Text = DataGrid_Show.SelectedCells[0].Value.ToString();
        }
        private void MenuStripItem_MainAdd_Click(object sender, EventArgs e) {
            Form_AddTable form_AddTable = new Form_AddTable();
            form_AddTable.ShowDialog();
            UpdateDataGrid();
        }

        private void MenuStripItem_MainRemove_Click(object sender, EventArgs e) {
            Form_RemoveTable form_RemoveTable = new Form_RemoveTable();
            form_RemoveTable.ShowDialog();
            UpdateDataGrid();
        }
    }
}
