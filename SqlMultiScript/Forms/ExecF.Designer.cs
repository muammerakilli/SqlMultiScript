using System.Drawing;
using ScintillaNET;

namespace SqlMultiScript.Forms
{
    partial class ExecF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecF));
            this.SqlText = new ScintillaNET.Scintilla();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCompile = new System.Windows.Forms.ToolStripButton();
            this.btn_execute = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewdb = new System.Windows.Forms.ListView();
            this.DbName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnConfigure = new System.Windows.Forms.Button();
            this.CmbListName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.MessageView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SqlText
            // 
            this.SqlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqlText.Lexer = ScintillaNET.Lexer.Sql;
            this.SqlText.Location = new System.Drawing.Point(3, 16);
            this.SqlText.Name = "SqlText";
            this.SqlText.Size = new System.Drawing.Size(1198, 361);
            this.SqlText.TabIndex = 0;
            this.SqlText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SqlText_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1514, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCompile,
            this.btn_execute});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1514, 26);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnCompile
            // 
            this.BtnCompile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnCompile.Image = global::SqlMultiScript.Properties.Resources.correct;
            this.BtnCompile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCompile.Name = "BtnCompile";
            this.BtnCompile.Size = new System.Drawing.Size(100, 23);
            this.BtnCompile.Text = "Parse Script";
            this.BtnCompile.Click += new System.EventHandler(this.BtnCompile_Click);
            // 
            // btn_execute
            // 
            this.btn_execute.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_execute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_execute.Image = global::SqlMultiScript.Properties.Resources.next;
            this.btn_execute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(130, 23);
            this.btn_execute.Text = "Execute Now(F5)";
            this.btn_execute.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.listViewdb);
            this.groupBox1.Controls.Add(this.BtnConfigure);
            this.groupBox1.Controls.Add(this.CmbListName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 539);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Distribution List";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // listViewdb
            // 
            this.listViewdb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewdb.CheckBoxes = true;
            this.listViewdb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DbName});
            this.listViewdb.GridLines = true;
            this.listViewdb.HideSelection = false;
            this.listViewdb.Location = new System.Drawing.Point(12, 60);
            this.listViewdb.Name = "listViewdb";
            this.listViewdb.Size = new System.Drawing.Size(292, 479);
            this.listViewdb.TabIndex = 2;
            this.listViewdb.UseCompatibleStateImageBehavior = false;
            this.listViewdb.View = System.Windows.Forms.View.Details;
            // 
            // DbName
            // 
            this.DbName.Text = "Databases";
            this.DbName.Width = 214;
            // 
            // BtnConfigure
            // 
            this.BtnConfigure.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnConfigure.Location = new System.Drawing.Point(229, 3);
            this.BtnConfigure.Name = "BtnConfigure";
            this.BtnConfigure.Size = new System.Drawing.Size(75, 51);
            this.BtnConfigure.TabIndex = 1;
            this.BtnConfigure.Text = "Configure";
            this.BtnConfigure.UseVisualStyleBackColor = false;
            this.BtnConfigure.Click += new System.EventHandler(this.BtnConfigure_Click);
            // 
            // CmbListName
            // 
            this.CmbListName.FormattingEnabled = true;
            this.CmbListName.Location = new System.Drawing.Point(12, 19);
            this.CmbListName.Name = "CmbListName";
            this.CmbListName.Size = new System.Drawing.Size(211, 21);
            this.CmbListName.TabIndex = 0;
            this.CmbListName.SelectedIndexChanged += new System.EventHandler(this.CmbListName_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SqlText);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1204, 380);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Script";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel1.Controls.Add(this.BtnClear);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAddFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1204, 418);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnSave.Location = new System.Drawing.Point(184, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnClear.Location = new System.Drawing.Point(95, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(83, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnAddFile.Location = new System.Drawing.Point(6, 3);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(83, 23);
            this.BtnAddFile.TabIndex = 0;
            this.BtnAddFile.Text = "Add File";
            this.BtnAddFile.UseVisualStyleBackColor = false;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // MessageView
            // 
            this.MessageView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MessageView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.status});
            this.MessageView.ContextMenuStrip = this.contextMenuStrip1;
            this.MessageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageView.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MessageView.ForeColor = System.Drawing.Color.Firebrick;
            this.MessageView.FullRowSelect = true;
            this.MessageView.GridLines = true;
            this.MessageView.HideSelection = false;
            this.MessageView.Location = new System.Drawing.Point(0, 0);
            this.MessageView.Name = "MessageView";
            this.MessageView.Size = new System.Drawing.Size(1204, 117);
            this.MessageView.TabIndex = 0;
            this.MessageView.UseCompatibleStateImageBehavior = false;
            this.MessageView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Database Name";
            this.name.Width = 300;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 1500;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(310, 26);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MessageView);
            this.splitContainer2.Size = new System.Drawing.Size(1204, 539);
            this.splitContainer2.SplitterDistance = 418;
            this.splitContainer2.TabIndex = 6;
            // 
            // ExecF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1514, 587);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExecF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Multi Script";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ExecF_Activated);
            this.Load += new System.EventHandler(this.ExecF_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ScintillaNET.Scintilla SqlText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnConfigure;
        private System.Windows.Forms.ComboBox CmbListName;
        private System.Windows.Forms.ListView listViewdb;
        private System.Windows.Forms.ToolStripButton BtnCompile;
        private System.Windows.Forms.ToolStripButton btn_execute;
        private System.Windows.Forms.ColumnHeader DbName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnAddFile;
        private System.Windows.Forms.ListView MessageView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
    }
}