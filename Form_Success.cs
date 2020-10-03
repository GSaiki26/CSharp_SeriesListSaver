using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime_Lister {
    public partial class Form_Success : Form {
        public Form_Success(string a) {
            InitializeComponent();
            LabelP_Success.Text = a;
        }

        private void Button_Ok_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
