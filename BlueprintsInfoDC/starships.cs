using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BlueprintsInfoDC
{
    public partial class starships : Form
    {
        public starships()
        {
            InitializeComponent();
        }

        private void starships_Load(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\files\\info.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList details = doc.SelectNodes("//TechnicalInfo//[title]");
            foreach (XmlNode nodo in details)
            {
                lvListSpaceships.Items.Add(nodo.InnerText);   
            }
        }
    }
}
