using SqlMultiScript.Class;
using System;
using System.Windows.Forms;

namespace SqlMultiScript.Forms
{
    public partial class AddSqlServer : Form
    {
        public static bool RefreshList;

        public AddSqlServer()
        {
            InitializeComponent();
        }

        private void AddSqlServer_Load(object sender, EventArgs e)
        {
            RdWindowsAut.Checked = true;
            RdSqlAuth.Checked = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(TxtServer.Text) || String.IsNullOrEmpty(TxtUsername.Text) || String.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Server information cannot be empty.");
                return;
            }

            string check = String.Empty;

            if (RdSqlAuth.Checked)
                check = "SqlServer";
            else
                check = "Windows";

            XmlOperations x = new XmlOperations("ServerList.xml", TxtServer.Text, check, TxtUsername.Text, TxtPassword.Text);
            x.AddSqlServerList();

            RefreshList = true;

            this.Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtServer.Text) || String.IsNullOrEmpty(TxtUsername.Text) || String.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Server information cannot be empty.");

                return;
            }

            SqlOperations.ConnectTest(TxtServer.Text, TxtUsername.Text, TxtPassword.Text);

        }
    }
}