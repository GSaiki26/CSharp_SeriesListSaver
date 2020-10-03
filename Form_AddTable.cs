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
    public partial class Form_AddTable : Form {
        public Form_AddTable() {
            InitializeComponent();
        }

        private void Button_Confirm_Click(object sender, EventArgs e) {
            if (TextBox_TableName.Text.Length != 0) {
                string name = TextBox_TableName.Text;
                DatabaseCommands databaseCommands = new DatabaseCommands();
                if (databaseCommands.AddTable(name).Equals(true)) {
                    this.Close();
                } else {
                    Label_Error.Text = "Já existe uma tabela com esse nome!";
                }
            } else {
                Label_Error.Text = "Digite um nome válido!";
            }
        }
    }
}
