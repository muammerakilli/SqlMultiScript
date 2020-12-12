using SqlMultiScript.Class;
using System;
using System.Windows.Forms;

namespace SqlMultiScript.Forms
{
    public partial class AddDistiributionList : Form
    {
        public static bool RefreshList;

        public AddDistiributionList()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtListName.Text))
            {
                MessageBox.Show("You can enter list name.");
                return;
            }

            XmlOperations xml = new XmlOperations("DistiributionList.xml", TxtListName.Text);
            xml.AddDistiributionList();

            RefreshList = true;



            this.Close();

        }
    }
}
