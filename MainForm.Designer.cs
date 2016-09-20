namespace LyncTracker
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Available");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Away");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Busy");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Do not disturb");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bAdd = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.rbOn = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChange = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.lvList = new System.Windows.Forms.ListView();
            this.tbTabEmail = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSendActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSendEmail = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbSaveActive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.clbStatuses = new System.Windows.Forms.ListView();
            this.colHead1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tbTabEmail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(235, 10);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "&Add to list";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(53, 12);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(176, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(15, 141);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(501, 23);
            this.bRemove.TabIndex = 4;
            this.bRemove.Text = "&Remove selected";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Send emails when status changes to:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOff);
            this.groupBox1.Controls.Add(this.rbOn);
            this.groupBox1.Location = new System.Drawing.Point(12, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 40);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "On/Off";
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Checked = true;
            this.rbOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbOff.Location = new System.Drawing.Point(51, 19);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(42, 17);
            this.rbOff.TabIndex = 15;
            this.rbOff.TabStop = true;
            this.rbOff.Text = "Off";
            this.rbOff.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOff.UseVisualStyleBackColor = true;
            // 
            // rbOn
            // 
            this.rbOn.AutoSize = true;
            this.rbOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbOn.Location = new System.Drawing.Point(6, 19);
            this.rbOn.Name = "rbOn";
            this.rbOn.Size = new System.Drawing.Size(41, 17);
            this.rbOn.TabIndex = 14;
            this.rbOn.Text = "On";
            this.rbOn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOn.UseVisualStyleBackColor = true;
            this.rbOn.CheckedChanged += new System.EventHandler(this.rbOn_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslChange});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(10, 17);
            this.tsslStatus.Text = " ";
            // 
            // tsslChange
            // 
            this.tsslChange.Name = "tsslChange";
            this.tsslChange.Size = new System.Drawing.Size(10, 17);
            this.tsslChange.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "When changed:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lvList
            // 
            this.lvList.Location = new System.Drawing.Point(15, 39);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(501, 96);
            this.lvList.TabIndex = 19;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.List;
            // 
            // tbTabEmail
            // 
            this.tbTabEmail.Controls.Add(this.tabPage1);
            this.tbTabEmail.Controls.Add(this.tabPage2);
            this.tbTabEmail.Location = new System.Drawing.Point(15, 285);
            this.tbTabEmail.Name = "tbTabEmail";
            this.tbTabEmail.SelectedIndex = 0;
            this.tbTabEmail.Size = new System.Drawing.Size(501, 100);
            this.tbTabEmail.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbSendActive);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbSendEmail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send email";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(403, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "*";
            // 
            // cbSendActive
            // 
            this.cbSendActive.AutoSize = true;
            this.cbSendActive.Checked = true;
            this.cbSendActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSendActive.Location = new System.Drawing.Point(3, 6);
            this.cbSendActive.Name = "cbSendActive";
            this.cbSendActive.Size = new System.Drawing.Size(56, 17);
            this.cbSendActive.TabIndex = 22;
            this.cbSendActive.Text = "Active";
            this.cbSendActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email to which the notification is to be sent:";
            // 
            // tbSendEmail
            // 
            this.tbSendEmail.Location = new System.Drawing.Point(221, 31);
            this.tbSendEmail.Name = "tbSendEmail";
            this.tbSendEmail.Size = new System.Drawing.Size(176, 20);
            this.tbSendEmail.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bSearch);
            this.tabPage2.Controls.Add(this.cbSaveActive);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Save to CSV";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(421, 31);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(28, 23);
            this.bSearch.TabIndex = 25;
            this.bSearch.Text = "...";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // cbSaveActive
            // 
            this.cbSaveActive.AutoSize = true;
            this.cbSaveActive.Checked = true;
            this.cbSaveActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSaveActive.Location = new System.Drawing.Point(3, 6);
            this.cbSaveActive.Name = "cbSaveActive";
            this.cbSaveActive.Size = new System.Drawing.Size(56, 17);
            this.cbSaveActive.TabIndex = 24;
            this.cbSaveActive.Text = "Active";
            this.cbSaveActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(403, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Path to log file:";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(88, 31);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(309, 20);
            this.tbLog.TabIndex = 21;
            // 
            // clbStatuses
            // 
            this.clbStatuses.CheckBoxes = true;
            this.clbStatuses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHead1});
            this.clbStatuses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.clbStatuses.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.clbStatuses.Location = new System.Drawing.Point(15, 183);
            this.clbStatuses.Name = "clbStatuses";
            this.clbStatuses.Size = new System.Drawing.Size(112, 83);
            this.clbStatuses.TabIndex = 22;
            this.clbStatuses.UseCompatibleStateImageBehavior = false;
            this.clbStatuses.View = System.Windows.Forms.View.Details;
            // 
            // colHead1
            // 
            this.colHead1.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 459);
            this.Controls.Add(this.clbStatuses);
            this.Controls.Add(this.tbTabEmail);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.bAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lync Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tbTabEmail.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bAdd;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bRemove;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbOff;
        public System.Windows.Forms.RadioButton rbOn;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        public System.Windows.Forms.ToolStripStatusLabel tsslChange;
        public System.Windows.Forms.Label label5;
        public System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.SaveFileDialog sfdSave;
        public System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.TabControl tbTabEmail;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.CheckBox cbSendActive;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbSendEmail;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button bSearch;
        public System.Windows.Forms.CheckBox cbSaveActive;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbLog;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView clbStatuses;
        private System.Windows.Forms.ColumnHeader colHead1;
    }
}

