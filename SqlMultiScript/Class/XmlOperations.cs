using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SqlMultiScript.Class
{
    public class XmlOperations : ExceptionOperations
    {               
        string FileName;
        string servername;
        string authenticationmode;
        string username;
        string password;

        string DistiributionListName;

        public XmlOperations(){}
        public XmlOperations(string file) { FileName = file;}
        public XmlOperations(string file,string list){FileName = file; ListName = list; }

        public XmlOperations(params string[] args)
        {
            XmlFileName = args[0];
            ServerName = args[1];
            AuthenMode = args[2];
            Username = args[3];
            PassWord = args[4];
        }

        public string XmlFileName { get { return FileName; } set { FileName = value; } }
        public string ServerName { get { return servername; } set { servername = value; } }
        public string AuthenMode { get { return authenticationmode; } set { authenticationmode = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string PassWord { get { return password; } set { password = value; } }
        public string ListName { get { return DistiributionListName; } set { DistiributionListName = value; } }


        public void AddSqlServerList()
        {
            try
            {
                string XmlFile = Path.Combine(GlobalVariables.CurrentDir, FileName);

                if (String.IsNullOrEmpty(XmlFile))
                    throw new ApplicationException("Unable to access "+ FileName + " file.");

                XElement xDoc = XElement.Load(XmlFile);
                xDoc.Add(
                new XElement("SqlServer", servername,
                        new XAttribute("ServerName", servername),
                        new XAttribute("AuthenMode", authenticationmode),
                        new XAttribute("Username", username),
                        new XAttribute("PassWord", password)));
                xDoc.Save(XmlFile);
            }
            catch (ApplicationException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        public List<XmlOperations> GetSqlList(string file)
        {
            string XmlFile = Path.Combine(GlobalVariables.CurrentDir, XmlFileName);
            List<XmlOperations> list = new List<XmlOperations>();


            XmlDocument document = new XmlDocument();
            document.Load(XmlFile);
            var nodes = document.SelectNodes("//SqlServerList/SqlServer");

            foreach (XmlElement node in nodes)
            {

                list.Add(new XmlOperations()
                {
                    XmlFileName = file,
                    ServerName = node.GetAttribute("ServerName"),
                    AuthenMode = node.GetAttribute("AuthenMode"),
                    Username = node.GetAttribute("Username"),
                    PassWord = node.GetAttribute("PassWord")
                    }
                );
            }
          

            return list;  
        }

        public void AddDistiributionList()
        {
            try
            {
                string XmlFile = Path.Combine(GlobalVariables.CurrentDir, FileName);

                if (String.IsNullOrEmpty(XmlFile))
                    throw new ApplicationException("Unable to access " + FileName + " file.");

                XElement xDoc = XElement.Load(XmlFile);
                xDoc.Add(new XElement("ListName", DistiributionListName));
                xDoc.Save(XmlFile);
            }
            catch (ApplicationException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        public List<XmlOperations> GetDList(string file)
        {
           
            string XmlFile = Path.Combine(GlobalVariables.CurrentDir, XmlFileName);
            List<XmlOperations> list = new List<XmlOperations>();

            XmlDocument xml = new XmlDocument();
            xml.Load(XmlFile);

            var nodes = xml.SelectNodes("//DistiributionList");
            foreach (XmlNode node in nodes)
            {

                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    list.Add(new XmlOperations(){XmlFileName = file,ListName = node.ChildNodes[i].InnerText});
                }
 
            }

            return list;
        }

        public void SaveList(ComboBox cmb,ListBox list,string pNode)
        {
 
            try
            {

                string XmlFile = Path.Combine(GlobalVariables.CurrentDir, cmb.Text + ".xml");

                if (File.Exists(XmlFile) == true)
                {
                    File.Delete(XmlFile);
                }

                //create a new file in the working directory
                XmlTextWriter textWriter = new XmlTextWriter(XmlFile, null);
                textWriter.WriteStartElement("Lists");
                textWriter.WriteEndElement();
                textWriter.Close();

                XElement xDoc = XElement.Load(XmlFile);
                for (int i = 0; i < list.Items.Count; i++)
                {
                    xDoc.Add(new XElement("DbName", list.Items[i].ToString(), new XAttribute("ServerName", pNode)));
                }                                                                
                xDoc.Save(XmlFile);

            }
            catch (ApplicationException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        public List<string> GetList(string filename)
        {
            List<string> list = new List<string>();

            string XmlFile = Path.Combine(GlobalVariables.CurrentDir, filename + ".xml");

            if (File.Exists(XmlFile) == true)
            {

                XmlDocument xml = new XmlDocument();
                xml.Load(XmlFile);
                XmlNodeList xmlNodeList = xml.SelectNodes("/Lists");

                foreach (XmlNode xmlNode in xmlNodeList)
                {
                    for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                    {
                        list.Add(xmlNode.ChildNodes[i].InnerText);
                    }                    
                }
            }

            return list;

        }

        public void DeleteList(string listname,string NodeName,string XmlFileName)
        {
            string XmlFile = Path.Combine(GlobalVariables.CurrentDir, listname + ".xml");
            if (File.Exists(XmlFile) == true)
            {
                File.Delete(XmlFile);
            }

       
            XmlFile = Path.Combine(GlobalVariables.CurrentDir, XmlFileName);
 
            XmlDocument xml = new XmlDocument();
            xml.Load(XmlFile);
            XmlNodeList xmlNodeList = xml.SelectNodes(NodeName);

            foreach (XmlNode xmlNode in xmlNodeList)
            {

                for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                {
                    if (xmlNode.ChildNodes[i].InnerText == listname)
                    {                      
                        xmlNode.RemoveChild(xmlNode.ChildNodes[i]);
                    }
                }
            }

            xml.Save(XmlFile);
 
        }

        public static string[] GetServerConnect(string text)
        {

            XmlOperations result = new XmlOperations();

            string[] connectInf = new string[4];


            string XmlFile = Path.Combine(GlobalVariables.CurrentDir, GlobalVariables.ServerListXmlName);


            if (File.Exists(XmlFile) == true)
            {

                XmlDocument xml = new XmlDocument();
                xml.Load(XmlFile);
                XmlNodeList xmlNodeList = xml.SelectNodes("/SqlServerList");

                foreach (XmlNode xmlNode in xmlNodeList)
                {
                    for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                    {
                        string dbname = text.Substring(0, text.IndexOf(']'));
                        dbname = dbname.Remove(0, 1);

                        if (xmlNode.ChildNodes[i].InnerText== dbname)
                        {
                            for (int j = 0; j < xmlNode.ChildNodes[i].Attributes.Count; j++)
                            {
                                if (xmlNode.ChildNodes[i].Attributes[j].Name== "PassWord")
                                {
                                    connectInf[0] = xmlNode.ChildNodes[i].Attributes[j].Value;
                                }
                                if (xmlNode.ChildNodes[i].Attributes[j].Name == "Username")
                                {
                                    connectInf[1] = xmlNode.ChildNodes[i].Attributes[j].Value;
                                }
                                if (xmlNode.ChildNodes[i].Attributes[j].Name == "AuthenMode")
                                {
                                    connectInf[2] = xmlNode.ChildNodes[i].Attributes[j].Value;
                                }
                                if (xmlNode.ChildNodes[i].Attributes[j].Name == "ServerName")
                                {
                                    connectInf[3] = xmlNode.ChildNodes[i].Attributes[j].Value;
                                }
                            }
                        }
                    }
                }
            }

            return connectInf; 
        }

    }


}
