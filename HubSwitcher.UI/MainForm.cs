using System;
using System.Windows.Forms;

namespace HubSwitcher.UI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            lblResults.Text = "Add button pressed.";
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            lblResults.Text = "Update button pressed.";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            lblResults.Text = "Delete button pressed.";
        }
    }
}
