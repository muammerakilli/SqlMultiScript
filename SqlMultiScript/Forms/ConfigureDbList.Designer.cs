namespace SqlMultiScript.Forms
{
    partial class ConfigureDbList
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
            this.BtnAddSql = new System.Windows.Forms.Button();
            this.TreeSqlServer = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNewList = new System.Windows.Forms.Button();
            this.BtnDeleteList = new System.Windows.Forms.Button();
            this.ListDs = new System.Windows.Forms.ListBox();
            this.CmbList = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnDeleteSql = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDeleteSql);
            this.groupBox1.Controls.Add(this.BtnAddSql);
            this.groupBox1.Controls.Add(this.TreeSqlServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // BtnAddSql
            // 
            this.BtnAddSql.Location = new System.Drawing.Point(7, 359);
            this.BtnAddSql.Name = "BtnAddSql";
            this.BtnAddSql.Size = new System.Drawing.Size(259, 23);
            this.BtnAddSql.TabIndex = 1;
            this.BtnAddSql.Text = "Add SQL Server";
            this.BtnAddSql.UseVisualStyleBackColor = true;
            this.BtnAddSql.Click += new System.EventHandler(this.BtnAddSql_Click);
            // 
            // TreeSqlServer
            // 
            this.TreeSqlServer.Location = new System.Drawing.Point(7, 19);
            this.TreeSqlServer.Name = "TreeSqlServer";
            this.TreeSqlServer.Size = new System.Drawing.Size(259, 321);
            this.TreeSqlServer.TabIndex = 2;
            this.TreeSqlServer.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeSqlServer_AfterExpand);
            this.TreeSqlServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeSqlServer_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distribution List:";
            // 
            // BtnNewList
            // 
            this.BtnNewList.Location = new System.Drawing.Point(560, 17);
            this.BtnNewList.Name = "BtnNewList";
            this.BtnNewList.Size = new System.Drawing.Size(59, 23);
            this.BtnNewList.TabIndex = 2;
            this.BtnNewList.Text = "New";
            this.BtnNewList.UseVisualStyleBackColor = true;
            this.BtnNewList.Click += new System.EventHandler(this.BtnNewList_Click);
            // 
            // BtnDeleteList
            // 
            this.BtnDeleteList.Location = new System.Drawing.Point(625, 17);
            this.BtnDeleteList.Name = "BtnDeleteList";
            this.BtnDeleteList.Size = new System.Drawing.Size(59, 23);
            this.BtnDeleteList.TabIndex = 3;
            this.BtnDeleteList.Text = "Delete";
            this.BtnDeleteList.UseVisualStyleBackColor = true;
            this.BtnDeleteList.Click += new System.EventHandler(this.BtnDeleteList_Click);
            // 
            // ListDs
            // 
            this.ListDs.FormattingEnabled = true;
            this.ListDs.Location = new System.Drawing.Point(462, 75);
            this.ListDs.Name = "ListDs";
            this.ListDs.Size = new System.Drawing.Size(326, 277);
            this.ListDs.TabIndex = 4;
            // 
            // CmbList
            // 
            this.CmbList.FormattingEnabled = true;
            this.CmbList.Location = new System.Drawing.Point(462, 48);
            this.CmbList.Name = "CmbList";
            this.CmbList.Size = new System.Drawing.Size(326, 21);
            this.CmbList.TabIndex = 5;
            this.CmbList.SelectedIndexChanged += new System.EventHandler(this.CmbList_SelectedIndexChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(712, 394);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(631, 394);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(337, 120);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add>>";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(337, 160);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.Text = "<<Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnDeleteSql
            // 
            this.BtnDeleteSql.Location = new System.Drawing.Point(6, 383);
            this.BtnDeleteSql.Name = "BtnDeleteSql";
            this.BtnDeleteSql.Size = new System.Drawing.Size(259, 23);
            this.BtnDeleteSql.TabIndex = 3;
            this.BtnDeleteSql.Text = "Delete SQL Server";
            this.BtnDeleteSql.UseVisualStyleBackColor = true;
            this.BtnDeleteSql.Click += new System.EventHandler(this.BtnDeleteSql_Click);
            // 
            // ConfigureDbList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.CmbList);
            this.Controls.Add(this.ListDs);
            this.Controls.Add(this.BtnDeleteList);
            this.Controls.Add(this.BtnNewList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigureDbList";
            this.Text = "Configure Database Distribution List";
            this.Activated += new System.EventHandler(this.ConfigureDbList_Activated);
            this.Load += new System.EventHandler(this.ConfigureDbList_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddSql;
        private System.Windows.Forms.TreeView TreeSqlServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNewList;
        private System.Windows.Forms.Button BtnDeleteList;
        private System.Windows.Forms.ListBox ListDs;
        private System.Windows.Forms.ComboBox CmbList;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnDeleteSql;
    }
}