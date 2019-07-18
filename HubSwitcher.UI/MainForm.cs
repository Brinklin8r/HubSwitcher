using System;
using System.Windows.Forms;

namespace HubSwitcher.UI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            lblResults.Text = "Add";
        }

        private void BtnUpdate_Click(object sender, EventArgs e) {
            lblResults.Text = "Update";
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            lblResults.Text = "Delete";
        }
    }
}
