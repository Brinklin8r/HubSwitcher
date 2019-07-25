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
            this.lblPURI = new System.Windows.Forms.Label();
            this.tbPURI = new System.Windows.Forms.TextBox();
            this.lblSURI = new System.Windows.Forms.Label();
            this.tbSURI = new System.Windows.Forms.TextBox();
            this.lblUIN = new System.Windows.Forms.Label();
            this.tbUIN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(198, 23);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(624, 31);
            this.tbDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(60, 29);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblPURI
            // 
            this.lblPURI.AutoSize = true;
            this.lblPURI.Location = new System.Drawing.Point(48, 79);
            this.lblPURI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPURI.Name = "lblPURI";
            this.lblPURI.Size = new System.Drawing.Size(138, 25);
            this.lblPURI.TabIndex = 3;
            this.lblPURI.Text = "Primary URI: ";
            // 
            // tbPURI
            // 
            this.tbPURI.Location = new System.Drawing.Point(198, 73);
            this.tbPURI.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPURI.Name = "tbPURI";
            this.tbPURI.Size = new System.Drawing.Size(624, 31);
            this.tbPURI.TabIndex = 2;
            // 
            // lblSURI
            // 
            this.lblSURI.AutoSize = true;
            this.lblSURI.Location = new System.Drawing.Point(14, 129);
            this.lblSURI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSURI.Name = "lblSURI";
            this.lblSURI.Size = new System.Drawing.Size(168, 25);
            this.lblSURI.TabIndex = 5;
            this.lblSURI.Text = "Secondary URI: ";
            // 
            // tbSURI
            // 
            this.tbSURI.Location = new System.Drawing.Point(198, 123);
            this.tbSURI.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSURI.Name = "tbSURI";
            this.tbSURI.Size = new System.Drawing.Size(624, 31);
            this.tbSURI.TabIndex = 4;
            // 
            // lblUIN
            // 
            this.lblUIN.AutoSize = true;
            this.lblUIN.Location = new System.Drawing.Point(122, 179);
            this.lblUIN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUIN.Name = "lblUIN";
            this.lblUIN.Size = new System.Drawing.Size(59, 25);
            this.lblUIN.TabIndex = 7;
            this.lblUIN.Text = "UIN: ";
            // 
            // tbUIN
            // 
            this.tbUIN.Location = new System.Drawing.Point(198, 173);
            this.tbUIN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbUIN.Name = "tbUIN";
            this.tbUIN.Size = new System.Drawing.Size(624, 31);
            this.tbUIN.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 290);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 44);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(188, 290);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 44);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 290);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 44);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvDB
            // 
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Location = new System.Drawing.Point(26, 402);
            this.dgvDB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.RowHeadersWidth = 82;
            this.dgvDB.Size = new System.Drawing.Size(800, 500);
            this.dgvDB.TabIndex = 11;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(2, 985);
            this.lblResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 25);
            this.lblResults.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 1019);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dgvDB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUIN);
            this.Controls.Add(this.tbUIN);
            this.Controls.Add(this.lblSURI);
            this.Controls.Add(this.tbSURI);
            this.Controls.Add(this.lblPURI);
            this.Controls.Add(this.tbPURI);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbDescription);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Hub Switcher v2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPURI;
        private System.Windows.Forms.TextBox tbPURI;
        private System.Windows.Forms.Label lblSURI;
        private System.Windows.Forms.TextBox tbSURI;
        private System.Windows.Forms.Label lblUIN;
        private System.Windows.Forms.TextBox tbUIN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.Label lblResults;
    }
}

