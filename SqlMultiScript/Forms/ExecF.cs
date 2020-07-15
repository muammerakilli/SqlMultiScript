using ScintillaNET;
using SqlMultiScript.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SqlMultiScript.Forms
{
    public partial class ExecF : Form
    {
        public ExecF()
        {
            InitializeComponent();

            #region  Scintilla Text Init

            // Reset the styles
            SqlText.StyleResetDefault();
            SqlText.Styles[Style.Default].Font = "Courier New";
            SqlText.Styles[Style.Default].Size = 10;
            SqlText.StyleClearAll();

            // Set the SQL Lexer
            SqlText.Lexer = Lexer.Sql;

            // Show line numbers
            SqlText.Margins[0].Width = 20;

            // Set the Styles
            SqlText.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128);  //Dark Gray
            SqlText.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 228, 228, 228);  //Light Gray
            SqlText.Styles[Style.Sql.Comment].ForeColor = Color.Green;
            SqlText.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;
            SqlText.Styles[Style.Sql.CommentLineDoc].ForeColor = Color.Green;
            SqlText.Styles[Style.Sql.Number].ForeColor = Color.Maroon;
            SqlText.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            SqlText.Styles[Style.Sql.Word2].ForeColor = Color.Fuchsia;
            SqlText.Styles[Style.Sql.User1].ForeColor = Color.Gray;
            SqlText.Styles[Style.Sql.User2].ForeColor = Color.FromArgb(255, 00, 128, 192);    //Medium Blue-Green
            SqlText.Styles[Style.Sql.String].ForeColor = Color.Red;
            SqlText.Styles[Style.Sql.Character].ForeColor = Color.Red;
            SqlText.Styles[Style.Sql.Operator].ForeColor = Color.Black;

            // Set keyword lists
            // Word = 0
            SqlText.SetKeywords(0, @"add alter as authorization backup begin bigint binary bit break browse bulk by cascade case catch check checkpoint close clustered column commit compute constraint containstable continue create current cursor cursor database date datetime datetime2 datetimeoffset dbcc deallocate decimal declare default delete deny desc disk distinct distributed double drop dump else end errlvl escape except exec execute exit external fetch file fillfactor float for foreign freetext freetexttable from full function goto grant group having hierarchyid holdlock identity identity_insert identitycol if image index insert int intersect into key kill lineno load merge money national nchar nocheck nocount nolock nonclustered ntext numeric nvarchar of off offsets on open opendatasource openquery openrowset openxml option order over percent plan precision primary print proc procedure public raiserror read readtext real reconfigure references replication restore restrict return revert revoke rollback rowcount rowguidcol rule save schema securityaudit select set setuser shutdown smalldatetime smallint smallmoney sql_variant statistics table table tablesample text textsize then time timestamp tinyint to top tran transaction trigger truncate try union unique uniqueidentifier update updatetext use user values varbinary varchar varying view waitfor when where while with writetext xml go ");
            // Word2 = 1
            SqlText.SetKeywords(1, @"ascii cast char charindex ceiling coalesce collate contains convert current_date current_time current_timestamp current_user floor isnull max min nullif object_id session_user substring system_user tsequal ");
            // User1 = 4
            SqlText.SetKeywords(4, @"all and any between cross exists in inner is join left like not null or outer pivot right some unpivot ( ) * ");
            // User2 = 5
            SqlText.SetKeywords(5, @"sys objects sysobjects ");

            #endregion
        }


        private void ExecF_Load(object sender, EventArgs e)
        {
            List<XmlOperations> dlist = new List<XmlOperations>();
            XmlOperations xml2 = new XmlOperations(GlobalVariables.DistiributionListXmlName);
            dlist = xml2.GetDList(GlobalVariables.ServerListXmlName);
            foreach (var item in dlist)
            {
                CmbListName.Items.Add(item.ListName);
            }
        }


        private void BtnConfigure_Click(object sender, EventArgs e)
        {
            ConfigureDbList f = new ConfigureDbList();
            f.ShowDialog();
        }

        private void CmbListName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> dblist = new List<string>();

            XmlOperations xml = new XmlOperations();
            dblist = xml.GetList(CmbListName.Text);

            listViewdb.Items.Clear();

            for (int i = 0; i < dblist.Count; i++)
            {
                listViewdb.Items.Add(dblist[i]);
                listViewdb.Items[i].Checked = true;
            }


        }

        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                string script = File.ReadAllText(file.FileName);
                SqlText.Text = script;
            }
        }

        private void BtnCompile_Click(object sender, EventArgs e)
        {
            string invalidSql = SqlText.Text;
            IEnumerable<string> results = invalidSql.ValidateSql();

            foreach (var item in results)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listViewdb.Items.Count; i++)
            {

                if(listViewdb.Items[i].Checked==true)
                { 

                string[] deger = XmlOperations.GetServerConnect(listViewdb.Items[i].Text);

                if (deger.Length > 0)
                {
                    string dbname = listViewdb.Items[i].Text.Substring(listViewdb.Items[i].Text.IndexOf("dbo."), listViewdb.Items[i].Text.Length - listViewdb.Items[i].Text.IndexOf("dbo."));
                    dbname = dbname.Remove(dbname.IndexOf("dbo."),4);

                    if (!String.IsNullOrEmpty(dbname))
                    {
                        SqlOperations runexec = new SqlOperations(deger[3], dbname, deger[0], deger[1], deger[2]);

                        List<string> errors = new List<string>();
                        errors = runexec.UpdateDataBase(SqlText.Text);

                        if (errors.Count==0)
                        {
                            MessageView.Items.Add(dbname).SubItems.Add("Database updated successfully.");
                        }
                        else
                        {
                            foreach (var err in errors)
                            {
                                MessageView.Items.Add(dbname).SubItems.Add(err.ToString());
                            }
                        }                                             
                    }
                }


                }
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageView.Items.Clear();
        }
    }
}
