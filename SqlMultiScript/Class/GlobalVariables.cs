using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SqlMultiScript.Class
{
    public static class GlobalVariables
    {


        static string ServerList = "ServerList.xml";
        static string DistiributionList = "DistiributionList.xml";
        static readonly string workingDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +@"\SqlMultiScript";

        public static string ServerListXmlName { get => ServerList; }
        public static string DistiributionListXmlName { get => DistiributionList; }
        public static string CurrentDir { get => workingDir; }

    }
}
