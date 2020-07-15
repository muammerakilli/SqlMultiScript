using SqlMultiScript.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SqlMultiScript.Forms
{
    public partial class ConfigureDbList : Form
    {
        string AttributesName = String.Empty;
        string parentNode = string.Empty;

        List<XmlOperations> list = new List<XmlOperations>();
        List<XmlOperations> dlist = new List<XmlOperations>();
        
       
        public ConfigureDbList()
        {
            InitializeComponent();
        }

        private void ConfigureDbList_Load(object sender, EventArgs e)
        {
             LoadData(true,true);
        }

        private void ConfigureDbList_Activated(object sender, EventArgs e)
        {
            if (AddSqlServer.RefreshList)
            {
                LoadData(true, false);
                AddSqlServer.RefreshList = false;
            }

            if (AddDistiributionList.RefreshList)
            {
                LoadData(false, true);
                AddDistiributionList.RefreshList = false;
            }
        }



        private void BtnOK_Click(object sender, EventArgs e)
        {
            XmlOperations xml = new XmlOperations();            
            xml.SaveList(CmbList,ListDs,parentNode);

            parentNode = String.Empty;

            this.Close();
        }

        private void BtnAddSql_Click(object sender, EventArgs e)
        {
            AddSqlServer f = new AddSqlServer();
            f.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TreeSqlServer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            List<string> tList = new List<string>();

            foreach (var item in list)
            {
                if (item.ServerName == e.Node.Text)
                {
                    TreeSqlServer.Nodes[TreeSqlServer.SelectedNode.Index].Nodes.Clear();
                    tList = SqlOperations.GetDbName(item.ServerName, item.Username, item.PassWord);

                    for (int i = 0; i < tList.Count; i++)
                    {
                        TreeSqlServer.Nodes[TreeSqlServer.SelectedNode.Index].Nodes.Add(tList[i]);
                    }

                    TreeSqlServer.ExpandAll();
                }
            } 
        }

        private void TreeSqlServer_AfterExpand(object sender, TreeViewEventArgs e)
        {
            parentNode = e.Node.Text;
        }

        private void BtnNewList_Click(object sender, EventArgs e)
        {
            AddDistiributionList form = new AddDistiributionList();
            form.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool isthere=false;

            if (String.IsNullOrEmpty(CmbList.Text))
            {
                MessageBox.Show("Distribution list cannot be empty.");
                return;
            }


            if (TreeSqlServer.SelectedNode.Level != 0)
            {
                for (int i = 0; i < ListDs.Items.Count; i++)
                {
                    if (ListDs.Items[i].ToString()== TreeSqlServer.SelectedNode.Text)
                    {
                        isthere = true;
                        break;
                    }
                }

                if(isthere==false)
                    ListDs.Items.Add(TreeSqlServer.SelectedNode.Text);
            }


        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
       
            foreach(string s in ListDs.SelectedItems.OfType<string>().ToList())
                ListDs.Items.Remove(s);

        }

    
        private void CmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListDs.Items.Clear();

            List<string> dblist = new List<string>();

            XmlOperations xml = new XmlOperations();
            dblist = xml.GetList(CmbList.Text);

            for (int i = 0; i < dblist.Count; i++)
            {
                ListDs.Items.Add(dblist[i]);
            }
        }

        private void LoadData(bool tr,bool tr2)
        {
            if(tr)
            { 
                TreeSqlServer.Nodes.Clear();

                XmlOperations xml = new XmlOperations(GlobalVariables.ServerListXmlName);
                list = xml.GetSqlList(GlobalVariables.ServerListXmlName);
                foreach (var item in list)
                {
                    TreeSqlServer.Nodes.Add(item.ServerName);
                }
            }

            if (tr2)
            {
                CmbList.Items.Clear();

                XmlOperations xml2 = new XmlOperations(GlobalVariables.DistiributionListXmlName);
                dlist = xml2.GetDList(GlobalVariables.DistiributionListXmlName);
                foreach (var item in dlist)
                {
                    CmbList.Items.Add(item.ListName);
                }
            }
        }

        private void BtnDeleteList_Click(object sender, EventArgs e)
        {
            XmlOperations xml = new XmlOperations();
            xml.DeleteList(CmbList.Text, "/DistiributionList", GlobalVariables.DistiributionListXmlName);

            ListDs.Items.Clear();
            CmbList.Text = String.Empty;
            LoadData(true, true);
        }

        private void BtnDeleteSql_Click(object sender, EventArgs e)
        {
            XmlOperations xml = new XmlOperations();
            xml.DeleteList(TreeSqlServer.SelectedNode.Text, "/SqlServerList",GlobalVariables.ServerListXmlName);

            CmbList.Text = String.Empty;
            LoadData(true, true);
        }
    }
}
