using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using UserAccess.Data.Migrations;
using UserAccess.Models;
namespace UserAccess.Forms.Common
{
    public class UpdateAppConfig
    {
        
        public static void add(string name, SettingsDbContent nameofDatabaseSettings, TextBox appConfigDescription, string pathG)
        {
            //TODO:
            //string ApplicationPath = Application.StartupPath;
            //string YourPath = Path.GetDirectoryName(ApplicationPath);

            bool isNew = false;

            //string path = Path.GetDirectoryName(YourPath) + "\\App.config";
            string path = pathG;

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList list = doc.DocumentElement.SelectNodes(string.Format("connectionStrings/add[@name='{0}']", name));
            XmlNode node;
            isNew = list.Count == 0;
            if (isNew)
            {
                node = doc.CreateNode(XmlNodeType.Element, "add", null);
                XmlAttribute attribute = doc.CreateAttribute("name");
                attribute.Value = name;
                node.Attributes.Append(attribute);

                attribute = doc.CreateAttribute("connectionString");
                attribute.Value = "";
                node.Attributes.Append(attribute);

                attribute = doc.CreateAttribute("providerName");
                attribute.Value = "System.Data.SqlClient";
                node.Attributes.Append(attribute);
            }
            else
            {
                node = list[0];
            }
            
            string conString = node.Attributes["connectionString"].Value;
            SqlConnectionStringBuilder conStringBuilder = new SqlConnectionStringBuilder(conString);
            conStringBuilder.InitialCatalog = nameofDatabaseSettings.NameOfDatabase;
            conStringBuilder.DataSource = GlobalConstants.MachineName;
            conStringBuilder.IntegratedSecurity = true;
            conStringBuilder.MultipleActiveResultSets = true;
            node.Attributes["connectionString"].Value = conStringBuilder.ConnectionString;
            if (isNew)
            {
                doc.DocumentElement.SelectNodes("connectionStrings")[0].AppendChild(node);
            }

            doc.Save(path);

        }
        public static void ViewAppConfig(string name, SettingsDbContent nameofDatabaseSettings, TextBox appConfigDescription)
        {
            //string ApplicationPath = Application.StartupPath;
            //string YourPath = Path.GetDirectoryName(ApplicationPath);
            bool isNew = false;

            //string path = Path.GetDirectoryName(YourPath) + "\\App.config";
            string path = "C:\\Program Files (x86)\\_4\\UserAccess.Forms.vshost.exe.config";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList list = doc.DocumentElement.SelectNodes(string.Format("connectionStrings/add[@name='{0}']", name));
            XmlNode node;
            isNew = list.Count == 0;

            if (isNew)
            {
                node = doc.CreateNode(XmlNodeType.Element, "add", null);
                XmlAttribute attribute = doc.CreateAttribute("name");
                attribute.Value = name;
                node.Attributes.Append(attribute);

                attribute = doc.CreateAttribute("connectionString");
                attribute.Value = "";
                node.Attributes.Append(attribute);

                attribute = doc.CreateAttribute("providerName");
                attribute.Value = "System.Data.SqlClient";
                node.Attributes.Append(attribute);
            }
            else
            {
                node = list[0];
            }
            string conString = node.Attributes["connectionString"].Value;
            SqlConnectionStringBuilder conStringBuilder = new SqlConnectionStringBuilder(conString);
            conStringBuilder.InitialCatalog = nameofDatabaseSettings.NameOfDatabase;
            conStringBuilder.DataSource = GlobalConstants.MachineName;
            conStringBuilder.IntegratedSecurity = true;
            conStringBuilder.MultipleActiveResultSets = true;
            node.Attributes["connectionString"].Value = conStringBuilder.ConnectionString;
            string curentConStrings = node.Attributes["connectionString"].Value;
            appConfigDescription.Text = curentConStrings;                  

        }
    }
}
