﻿using System;
using System.Windows.Forms;
using HubSwitcher.DTO;

namespace HubSwitcher.UI {
    public partial class MainForm : Form {
        Config _adminConfig = new Config();
        DBConnect _dbc = new DBConnect();

        public MainForm() {
            InitializeComponent();
            UpdateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            _adminConfig.UpdateConfig(tbDescription.Text, tbMURL.Text, tbMPort.Text,
                tbSURL.Text, tbSPort.Text, tbUIN.Text);
            _dbc.AddConfig(_adminConfig);

            UpdateDisplay();

            lblResults.Text = "Add button pressed.";
        }

        private void btnSaveConfig_Click(object sender, EventArgs e) {
            _adminConfig.UpdateConfig(tbDescription.Text, tbMURL.Text, tbMPort.Text,
                tbSURL.Text, tbSPort.Text, tbUIN.Text);

            lblResults.Text = "Save Config button pressed.";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            _dbc.DeleteFromDB(10);

            UpdateDisplay();

            lblResults.Text = "Delete button pressed.";
        }

        private void btn_reload_Click(object sender, EventArgs e) {
            _adminConfig = new Config();
            DisplayConfig();

            lblResults.Text = "Config successfully reloaded.";
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            _adminConfig.UpdateConfig(tbDescription.Text, tbMURL.Text, tbMPort.Text,
                tbSURL.Text, tbSPort.Text, tbUIN.Text);
            _dbc.UpdateDB(10, _adminConfig);

            UpdateDisplay();

            lblResults.Text = "Update button pressed.";
        }

        private void DisplayConfig() {
            tbDescription.Text = _adminConfig.GetValue(Config.ConfigFields.Description);
            tbMURL.Text        = _adminConfig.GetValue(Config.ConfigFields.ManagerURL);
            tbMPort.Text       = _adminConfig.GetValue(Config.ConfigFields.ManagerPort);
            tbSURL.Text        = _adminConfig.GetValue(Config.ConfigFields.SecondaryManagerURL);
            tbSPort.Text       = _adminConfig.GetValue(Config.ConfigFields.SecondaryManagerPort);
            tbUIN.Text         = _adminConfig.GetValue(Config.ConfigFields.UIN);
        }

        private void UpdateDisplay() {
            DisplayConfig();
            dgvDB.DataSource = _dbc.ReadFromDB();
        }
    }
}
