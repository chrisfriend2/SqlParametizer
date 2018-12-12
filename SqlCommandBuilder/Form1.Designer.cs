namespace SqlCommandBuilder
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentConnectionStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.getInsert = new System.Windows.Forms.Button();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getData = new System.Windows.Forms.Button();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.txtCmdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtConnName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConditions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentDb = new System.Windows.Forms.ToolStripStatusLabel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.getToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.exportFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.connectToolStripMenuItem.Text = "Connect...";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exportFileToolStripMenuItem.Text = "Export File";
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schemaToolStripMenuItem,
            this.currentConnectionStringToolStripMenuItem});
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.getToolStripMenuItem.Text = "Get";
            // 
            // schemaToolStripMenuItem
            // 
            this.schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            this.schemaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.schemaToolStripMenuItem.Text = "Table Schema";
            this.schemaToolStripMenuItem.Click += new System.EventHandler(this.schemaToolStripMenuItem_Click);
            // 
            // currentConnectionStringToolStripMenuItem
            // 
            this.currentConnectionStringToolStripMenuItem.Name = "currentConnectionStringToolStripMenuItem";
            this.currentConnectionStringToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.currentConnectionStringToolStripMenuItem.Text = "Current Connection String";
            this.currentConnectionStringToolStripMenuItem.Click += new System.EventHandler(this.currentConnectionStringToolStripMenuItem_Click);
            // 
            // grdMain
            // 
            this.grdMain.AllowUserToAddRows = false;
            this.grdMain.AllowUserToDeleteRows = false;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Location = new System.Drawing.Point(12, 57);
            this.grdMain.Name = "grdMain";
            this.grdMain.ReadOnly = true;
            this.grdMain.Size = new System.Drawing.Size(506, 354);
            this.grdMain.TabIndex = 1;
            // 
            // getInsert
            // 
            this.getInsert.Location = new System.Drawing.Point(170, 475);
            this.getInsert.Name = "getInsert";
            this.getInsert.Size = new System.Drawing.Size(171, 23);
            this.getInsert.TabIndex = 4;
            this.getInsert.Text = "Get Parameterized SQL Insert";
            this.getInsert.UseVisualStyleBackColor = true;
            this.getInsert.Click += new System.EventHandler(this.getInsert_Click);
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(122, 419);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(219, 21);
            this.cmbTables.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "View Table Data For";
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(12, 27);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(75, 23);
            this.getData.TabIndex = 7;
            this.getData.Text = "Load Data";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(266, 446);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTable.TabIndex = 8;
            this.btnLoadTable.Text = "Use Table";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // txtCmdName
            // 
            this.txtCmdName.Location = new System.Drawing.Point(438, 419);
            this.txtCmdName.Name = "txtCmdName";
            this.txtCmdName.Size = new System.Drawing.Size(80, 20);
            this.txtCmdName.TabIndex = 9;
            this.txtCmdName.Text = "cmd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Command Name";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(525, 57);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(347, 491);
            this.txtResult.TabIndex = 11;
            this.txtResult.WordWrap = false;
            // 
            // txtConnName
            // 
            this.txtConnName.Location = new System.Drawing.Point(438, 446);
            this.txtConnName.Name = "txtConnName";
            this.txtConnName.Size = new System.Drawing.Size(79, 20);
            this.txtConnName.TabIndex = 12;
            this.txtConnName.Text = "conn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Connection Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Get Parameterized Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConditions
            // 
            this.txtConditions.Location = new System.Drawing.Point(347, 496);
            this.txtConditions.Multiline = true;
            this.txtConditions.Name = "txtConditions";
            this.txtConditions.Size = new System.Drawing.Size(170, 52);
            this.txtConditions.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select and Update conditions";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(797, 27);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCurrentDb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 24);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 19);
            this.toolStripStatusLabel1.Text = "Current Database";
            // 
            // lblCurrentDb
            // 
            this.lblCurrentDb.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentDb.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblCurrentDb.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblCurrentDb.Name = "lblCurrentDb";
            this.lblCurrentDb.Size = new System.Drawing.Size(38, 19);
            this.lblCurrentDb.Text = "none";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 584);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConditions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConnName);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCmdName);
            this.Controls.Add(this.btnLoadTable);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.getInsert);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SQL Statement Builder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schemaToolStripMenuItem;
        private System.Windows.Forms.Button getInsert;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.ToolStripMenuItem currentConnectionStringToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.TextBox txtCmdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtConnName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConditions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentDb;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

