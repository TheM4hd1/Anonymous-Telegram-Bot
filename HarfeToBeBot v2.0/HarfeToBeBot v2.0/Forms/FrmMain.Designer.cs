namespace HarfeToBeBot_v2._0
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvIncommingMessages = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRemoveAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.txtErrors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbxProfile = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxSendAll = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncommingMessages)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestart);
            this.groupBox1.Controls.Add(this.btnStartStop);
            this.groupBox1.Controls.Add(this.txtToken);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Token";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(84, 46);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnStartStop
            // 
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStartStop.Location = new System.Drawing.Point(3, 46);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_ClickAsync);
            // 
            // txtToken
            // 
            this.txtToken.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtToken.Location = new System.Drawing.Point(3, 18);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(531, 22);
            this.txtToken.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvIncommingMessages);
            this.groupBox2.Location = new System.Drawing.Point(15, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Data";
            // 
            // dgvIncommingMessages
            // 
            this.dgvIncommingMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncommingMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvIncommingMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncommingMessages.Location = new System.Drawing.Point(3, 18);
            this.dgvIncommingMessages.Name = "dgvIncommingMessages";
            this.dgvIncommingMessages.Size = new System.Drawing.Size(963, 200);
            this.dgvIncommingMessages.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "From";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "To";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Receiver Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Message";
            this.Column5.Name = "Column5";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.cbxSendAll);
            this.groupBox3.Controls.Add(this.lblDetails);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnSendMessage);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.btnRemoveAdmin);
            this.groupBox3.Controls.Add(this.btnAddAdmin);
            this.groupBox3.Controls.Add(this.txtErrors);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.pbxProfile);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Location = new System.Drawing.Point(18, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(963, 234);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(6, 186);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(63, 14);
            this.lblDetails.TabIndex = 12;
            this.lblDetails.Text = "Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Errors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Message";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.AutoSize = true;
            this.btnSendMessage.Location = new System.Drawing.Point(238, 101);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(101, 24);
            this.btnSendMessage.TabIndex = 9;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(399, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(558, 82);
            this.textBox2.TabIndex = 8;
            // 
            // btnRemoveAdmin
            // 
            this.btnRemoveAdmin.AutoSize = true;
            this.btnRemoveAdmin.Location = new System.Drawing.Point(238, 191);
            this.btnRemoveAdmin.Name = "btnRemoveAdmin";
            this.btnRemoveAdmin.Size = new System.Drawing.Size(101, 24);
            this.btnRemoveAdmin.TabIndex = 7;
            this.btnRemoveAdmin.Text = "Remove Admin";
            this.btnRemoveAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.AutoSize = true;
            this.btnAddAdmin.Location = new System.Drawing.Point(238, 161);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(84, 24);
            this.btnAddAdmin.TabIndex = 6;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            // 
            // txtErrors
            // 
            this.txtErrors.BackColor = System.Drawing.SystemColors.Control;
            this.txtErrors.Location = new System.Drawing.Point(399, 163);
            this.txtErrors.Multiline = true;
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtErrors.Size = new System.Drawing.Size(558, 65);
            this.txtErrors.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(238, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search Image";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pbxProfile
            // 
            this.pbxProfile.Location = new System.Drawing.Point(6, 21);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(226, 162);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProfile.TabIndex = 3;
            this.pbxProfile.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(238, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 22);
            this.txtId.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblUsers);
            this.groupBox4.Controls.Add(this.lblStatus);
            this.groupBox4.Location = new System.Drawing.Point(558, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 80);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bot Status";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(6, 46);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(98, 14);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Unique Users:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 14);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Offline";
            // 
            // cbxSendAll
            // 
            this.cbxSendAll.AutoSize = true;
            this.cbxSendAll.Location = new System.Drawing.Point(812, 131);
            this.cbxSendAll.Name = "cbxSendAll";
            this.cbxSendAll.Size = new System.Drawing.Size(145, 18);
            this.cbxSendAll.TabIndex = 2;
            this.cbxSendAll.Text = "Send to all users";
            this.cbxSendAll.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(996, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.Text = "HarfeToBeBot v2.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncommingMessages)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvIncommingMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbxProfile;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtErrors;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRemoveAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.CheckBox cbxSendAll;
    }
}

