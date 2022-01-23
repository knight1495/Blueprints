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

        string filePath = Application.StartupPath + "\\files\\info.xml";
        XmlDocument doc = new XmlDocument();
        
        public starships()
        {
            InitializeComponent();
        }

        private void starships_Load(object sender, EventArgs e)
        {

            
            doc.Load(filePath);
            ListViewGroup naves = new ListViewGroup("Naves");
            XmlNodeList detailsTitle = doc.SelectNodes("//InfoOptions//textOption");
            lbNaves.Items.Clear();
            foreach (XmlNode nodo in detailsTitle)
            {

                lbNaves.Items.Add(nodo.InnerText);
            }

            //Seleccionar foto y meterla
            //XmlNodeList detailsFoto = doc.SelectNodes("//TechnicalInfo//Blueprint");
            //ListView
            //foreach (XmlNode nodo in detailsFoto)
            //{
                
                
            //}

            

        }

        

        private void añadirInfoDesdeXML(string clave)
        {
            doc.Load(filePath);
            XmlNode details = doc.SelectSingleNode("//TechnicalInfo//InfoDetails//InfoDetail[idInfoDetail ='" + clave + "']//Data" );
            
            foreach(XmlNode nodo in details)
            {
                dgvDatosnave.Rows.Add(nodo.Name.ToString(), nodo.InnerText.ToString());
            }

        }

        private void lbNaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nave;
            nave = lbNaves.SelectedIndex.ToString();
            dgvDatosnave.Rows.Clear();
            añadirInfoDesdeXML(nave);
            lblNave.Text = lbNaves.SelectedItem.ToString();

            pbFront.Image = Image.FromFile(Application.StartupPath+"//images//"+lbNaves.SelectedItem+"//"+fotoFront(nave));
            pb360.Image = Image.FromFile(Application.StartupPath + "//images//" + lbNaves.SelectedItem + "//" + foto360(nave));
            pbRear.Image = Image.FromFile(Application.StartupPath + "//images//" + lbNaves.SelectedItem + "//" + fotoRear(nave));
            pbSide.Image = Image.FromFile(Application.StartupPath + "//images//" + lbNaves.SelectedItem + "//" + fotoSide(nave));
            pbTop.Image = Image.FromFile(Application.StartupPath + "//images//" + lbNaves.SelectedItem + "//" + fotoTop(nave));

            //wbPdf.Url = Application.StartupPath + "//images//" + lbNaves.SelectedItem + "//" + pillapdf(nave);


        }

        private string pillapdf(string nave)
        {
            string pdf;
            XmlNode nodopdf = doc.SelectSingleNode("//TechnicalInfo//InfoDetails//InfoDetail[idInfoDetail ='" + nave + "']//pdfFile");

            pdf = nodopdf.InnerText;
            return pdf;
        }

        private string fotoFront(string nave)
        {
            string foto;
            XmlNode frontFoto = doc.SelectSingleNode("//TechnicalInfo//InfoDetails//InfoDetail[idInfoDetail ='" + nave + "']//FrontView");
            
            foto = frontFoto.InnerText;
            

            return foto;
        }

        private string fotoTop(string nave)
        {
            string foto;
            XmlNode topFoto = doc.SelectSingleNode("//TechnicalInfo//InfoDetails//InfoDetail[idInfoDetail ='" + nave + "']//TopView");

            foto = topFoto.InnerText;


            return foto;
        }

        private string foto360(string nave)
        {
            string foto;
            XmlNode frontFoto = doc.SelectSingleNode("//TechnicalInfo//InfoDetails//InfoDetail[idInfoDetail ='" + nave + "']//View360");

            foto = frontFoto.InnerText;


            return foto;
        }

        private string fotoSide(string nave)
        {
            string foto;
            XmlNode frontFoto = doc.SelectSingleNode("//TechnicalInfo//InfoDetails//InfoDetail[idInfoDetail ='" + nave + "']//SideView");

            foto = frontFoto.InnerText;


            return foto;
        }

        private string fotoRear(string nave)
        {
            string foto;
            XmlNode frontFoto = doc.SelectSingleNode("//TechnicalInfo//InfoDetails//InfoDetail[idInfoDetail ='" + nave + "']//RearView");

            foto = frontFoto.InnerText;


            return foto;
        }

        private void pbFront_Click(object sender, EventArgs e)
        {
            pbSelected.Image = pbFront.Image;
        }

        private void pbSide_Click(object sender, EventArgs e)
        {
            pbSelected.Image = pbSide.Image;
        }

        private void pbTop_Click(object sender, EventArgs e)
        {
            pbSelected.Image = pbTop.Image;
        }

        private void pbRear_Click(object sender, EventArgs e)
        {
            pbSelected.Image = pbRear.Image;
        }

        private void pb360_Click(object sender, EventArgs e)
        {
            pbSelected.Image = pb360.Image;
        }
    }
}
