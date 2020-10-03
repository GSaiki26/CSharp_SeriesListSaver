using Anime_Lister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lister {
    public partial class Form_Add : Form {
        //Data
        public Form_Add() {
            InitializeComponent();
            UpdateStatus();
        }
        //Classes
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
        //Form Objects
        private void Button_Add_Click(object sender, EventArgs e) {
            if (ComboBox_Status.SelectedItem == null| TextBox_Name.Text.Length==0) {
                LabelP_Error.Visible = true;
            } else {
                string a = TextBox_Name.Text;
                string d = Convert.ToString(ComboBox_Status.SelectedItem);
                DatabaseCommands databaseCommands = new DatabaseCommands();
                DatabaseCommands.Add(a, d);
                LabelP_Error.Visible = false;
                this.Close();
            }
        }
    }
}