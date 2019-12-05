namespace HubSwitcher.UI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMURL = new System.Windows.Forms.Label();
            this.tbMURL = new System.Windows.Forms.TextBox();
            this.lblSURL = new System.Windows.Forms.Label();
            this.tbSURL = new System.Windows.Forms.TextBox();
            this.lblUIN = new System.Windows.Forms.Label();
            this.tbUIN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblSPort = new System.Windows.Forms.Label();
            this.tbSPort = new System.Windows.Forms.TextBox();
            this.lblMPort = new System.Windows.Forms.Label();
            this.tbMPort = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(99, 12);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(314, 20);
            this.tbDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 15);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblMURL
            // 
            this.lblMURL.AutoSize = true;
            this.lblMURL.Location = new System.Drawing.Point(13, 41);
            this.lblMURL.Name = "lblMURL";
            this.lblMURL.Size = new System.Drawing.Size(80, 13);
            this.lblMURL.TabIndex = 3;
            this.lblMURL.Text = "Manager URL: ";
            // 
            // tbMURL
            // 
            this.tbMURL.Location = new System.Drawing.Point(99, 38);
            this.tbMURL.Name = "tbMURL";
            this.tbMURL.Size = new System.Drawing.Size(172, 20);
            this.tbMURL.TabIndex = 2;
            // 
            // lblSURL
            // 
            this.lblSURL.AutoSize = true;
            this.lblSURL.Location = new System.Drawing.Point(4, 67);
            this.lblSURL.Name = "lblSURL";
            this.lblSURL.Size = new System.Drawing.Size(89, 13);
            this.lblSURL.TabIndex = 5;
            this.lblSURL.Text = "Secondary URL: ";
            // 
            // tbSURL
            // 
            this.tbSURL.Location = new System.Drawing.Point(99, 64);
            this.tbSURL.Name = "tbSURL";
            this.tbSURL.Size = new System.Drawing.Size(172, 20);
            this.tbSURL.TabIndex = 4;
            // 
            // lblUIN
            // 
            this.lblUIN.AutoSize = true;
            this.lblUIN.Location = new System.Drawing.Point(61, 93);
            this.lblUIN.Name = "lblUIN";
            this.lblUIN.Size = new System.Drawing.Size(32, 13);
            this.lblUIN.TabIndex = 7;
            this.lblUIN.Text = "UIN: ";
            // 
            // tbUIN
            // 
            this.tbUIN.Location = new System.Drawing.Point(99, 90);
            this.tbUIN.Name = "tbUIN";
            this.tbUIN.Size = new System.Drawing.Size(172, 20);
            this.tbUIN.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(315, 122);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(98, 23);
            this.btnSaveConfig.TabIndex = 9;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvDB
            // 
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Location = new System.Drawing.Point(13, 209);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.RowHeadersWidth = 82;
            this.dgvDB.Size = new System.Drawing.Size(400, 260);
            this.dgvDB.TabIndex = 11;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(1, 512);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 12;
            // 
            // lblSPort
            // 
            this.lblSPort.AutoSize = true;
            this.lblSPort.Location = new System.Drawing.Point(277, 67);
            this.lblSPort.Name = "lblSPort";
            this.lblSPort.Size = new System.Drawing.Size(32, 13);
            this.lblSPort.TabIndex = 16;
            this.lblSPort.Text = "Port: ";
            // 
            // tbSPort
            // 
            this.tbSPort.Location = new System.Drawing.Point(315, 64);
            this.tbSPort.Name = "tbSPort";
            this.tbSPort.Size = new System.Drawing.Size(98, 20);
            this.tbSPort.TabIndex = 15;
            // 
            // lblMPort
            // 
            this.lblMPort.AutoSize = true;
            this.lblMPort.Location = new System.Drawing.Point(277, 41);
            this.lblMPort.Name = "lblMPort";
            this.lblMPort.Size = new System.Drawing.Size(32, 13);
            this.lblMPort.TabIndex = 14;
            this.lblMPort.Text = "Port: ";
            // 
            // tbMPort
            // 
            this.tbMPort.Location = new System.Drawing.Point(315, 38);
            this.tbMPort.Name = "tbMPort";
            this.tbMPort.Size = new System.Drawing.Size(98, 20);
            this.tbMPort.TabIndex = 13;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(315, 151);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(98, 23);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Re-load Config";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update DB";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 530);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblSPort);
            this.Controls.Add(this.tbSPort);
            this.Controls.Add(this.lblMPort);
            this.Controls.Add(this.tbMPort);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dgvDB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUIN);
            this.Controls.Add(this.tbUIN);
            this.Controls.Add(this.lblSURL);
            this.Controls.Add(this.tbSURL);
            this.Controls.Add(this.lblMURL);
            this.Controls.Add(this.tbMURL);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbDescription);
            this.Name = "MainForm";
            this.Text = "Hub Switcher v2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMURL;
        private System.Windows.Forms.TextBox tbMURL;
        private System.Windows.Forms.Label lblSURL;
        private System.Windows.Forms.TextBox tbSURL;
        private System.Windows.Forms.Label lblUIN;
        private System.Windows.Forms.TextBox tbUIN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblSPort;
        private System.Windows.Forms.TextBox tbSPort;
        private System.Windows.Forms.Label lblMPort;
        private System.Windows.Forms.TextBox tbMPort;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnUpdate;
    }
}

