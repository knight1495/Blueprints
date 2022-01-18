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
    public partial class frmBlueprints : Form
    {
        public frmBlueprints()
        {
            InitializeComponent();
        }
       

        private void frmBlueprints_Load(object sender, EventArgs e)
        {
           

        }

        private void labelTransparent1_Load(object sender, EventArgs e)
        {
            string filePath = "info.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            string xmlcontents = doc.InnerXml;
            doc.Save("infoSave.xml");
            
        }

        private void labelTransparent1_Click(object sender, EventArgs e)
        {
            string id = "3";
            tinkiwinky(id);
        }

        private void labelTransparent2_Click(object sender, EventArgs e)
        {
            string id = "1";
            tinkiwinky(id);
        }

        private void tinkiwinky(String idDetail)
        {
            string filePath = Application.StartupPath+"\\files\\info.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNode details = doc.SelectSingleNode("//Detail[idDetail = '" + idDetail + "']");
            foreach (XmlNode node in details)
            {
                switch (node.Name)
                {
                    case"title":
                        lblTitulo.Text = node.InnerText;
                        break;
                    case "textDetail":
                        lblDetails.Text = node.InnerText;
                        break;
                    case "imageDetail":
                        pbxZoom.Image =Image.FromFile(Application.StartupPath+"\\images\\"+node.InnerText);
                        break;
                    default:
                        break;
                }
            }

        }

        private void lblBase_Load(object sender, EventArgs e)
        {

        }

        private void lblSupply_Click(object sender, EventArgs e)
        {
            string id = "2";
            tinkiwinky(id);
        }
    }
}
