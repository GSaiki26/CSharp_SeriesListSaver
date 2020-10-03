using Anime_Lister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lister {
    public partial class Form_Main : Form {
        //Data
        public Form_Main() {
            InitializeComponent();
            UpdateDataGrid();
        }
        //Classes
        public void UpdateDataGrid() {
            DatabaseCommands databaseCommands = new DatabaseCommands();
            this.Text = databaseCommands.GetTable();
            DataGrid_Show.DataSource = databaseCommands.SearchInDatabase("Select * from "+databaseCommands.GetTable()+";");
        }
        private void TextBox_Search_TextChanged(object sender, EventArgs e) {
            DatabaseCommands databaseCommands = new DatabaseCommands();
            if (TextBox_Search.Text.Length == 0) {
                UpdateDataGrid();
                Label_Error.Text = "";
            }
            else {
                DataTable dataTable = databaseCommands.SearchInDatabase("Select * from "+databaseCommands.GetTable()+";");
                dataTable = databaseCommands.SearchInDatabase("Select * from "+databaseCommands.GetTable()+" where WorkName Like '%" + TextBox_Search.Text + "%'");
                DataGrid_Show.DataSource = dataTable;
                if (dataTable.Rows.Count > 0) {
                    Label_Error.Text = "";
                } else {
                    Label_Error.Text = "Não foi possivel localizar!";
                }
            }
        }
        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e) {
            Form_Add addAnime = new Form_Add();
            addAnime.ShowDialog();
            UpdateDataGrid();
        }
        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e) {
            Form_Edit form_Edit = new Form_Edit();
            form_Edit.ShowDialog();
            UpdateDataGrid();
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_About form_About = new Form_About();
            form_About.ShowDialog();
        }

        private void gerenciarTabelasToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_Tables form_Tables = new Form_Tables();
            form_Tables.ShowDialog();
            UpdateDataGrid();
        }
    }
}