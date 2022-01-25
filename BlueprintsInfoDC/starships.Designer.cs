
namespace BlueprintsInfoDC
{
    partial class starships
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(starships));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbSelected = new System.Windows.Forms.PictureBox();
            this.pbFront = new System.Windows.Forms.PictureBox();
            this.pbSide = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbRear = new System.Windows.Forms.PictureBox();
            this.lblNave = new System.Windows.Forms.Label();
            this.dgvDatosnave = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNaves = new System.Windows.Forms.ListBox();
            this.wmp360 = new AxWMPLib.AxWindowsMediaPlayer();
            this.wbPdf = new System.Windows.Forms.WebBrowser();
            this.pb360 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosnave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb360)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wbPdf);
            this.panel1.Location = new System.Drawing.Point(185, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 449);
            this.panel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1021, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(278, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Spaceship technical Information";
            // 
            // pbSelected
            // 
            this.pbSelected.Location = new System.Drawing.Point(811, 72);
            this.pbSelected.Name = "pbSelected";
            this.pbSelected.Size = new System.Drawing.Size(597, 426);
            this.pbSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelected.TabIndex = 4;
            this.pbSelected.TabStop = false;
            // 
            // pbFront
            // 
            this.pbFront.Location = new System.Drawing.Point(566, 536);
            this.pbFront.Name = "pbFront";
            this.pbFront.Size = new System.Drawing.Size(209, 172);
            this.pbFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFront.TabIndex = 5;
            this.pbFront.TabStop = false;
            this.pbFront.Click += new System.EventHandler(this.pbFront_Click);
            // 
            // pbSide
            // 
            this.pbSide.Location = new System.Drawing.Point(996, 536);
            this.pbSide.Name = "pbSide";
            this.pbSide.Size = new System.Drawing.Size(209, 172);
            this.pbSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSide.TabIndex = 6;
            this.pbSide.TabStop = false;
            this.pbSide.Click += new System.EventHandler(this.pbSide_Click);
            // 
            // pbTop
            // 
            this.pbTop.Location = new System.Drawing.Point(1211, 536);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(209, 172);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTop.TabIndex = 7;
            this.pbTop.TabStop = false;
            this.pbTop.Click += new System.EventHandler(this.pbTop_Click);
            // 
            // pbRear
            // 
            this.pbRear.Location = new System.Drawing.Point(781, 536);
            this.pbRear.Name = "pbRear";
            this.pbRear.Size = new System.Drawing.Size(209, 172);
            this.pbRear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRear.TabIndex = 8;
            this.pbRear.TabStop = false;
            this.pbRear.Click += new System.EventHandler(this.pbRear_Click);
            // 
            // lblNave
            // 
            this.lblNave.AutoSize = true;
            this.lblNave.Location = new System.Drawing.Point(1084, 516);
            this.lblNave.Name = "lblNave";
            this.lblNave.Size = new System.Drawing.Size(0, 17);
            this.lblNave.TabIndex = 10;
            // 
            // dgvDatosnave
            // 
            this.dgvDatosnave.AllowUserToOrderColumns = true;
            this.dgvDatosnave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosnave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Value});
            this.dgvDatosnave.Location = new System.Drawing.Point(185, 536);
            this.dgvDatosnave.Name = "dgvDatosnave";
            this.dgvDatosnave.RowHeadersWidth = 51;
            this.dgvDatosnave.RowTemplate.Height = 24;
            this.dgvDatosnave.Size = new System.Drawing.Size(302, 279);
            this.dgvDatosnave.TabIndex = 12;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 125;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 125;
            // 
            // lbNaves
            // 
            this.lbNaves.FormattingEnabled = true;
            this.lbNaves.ItemHeight = 16;
            this.lbNaves.Location = new System.Drawing.Point(12, 49);
            this.lbNaves.Name = "lbNaves";
            this.lbNaves.Size = new System.Drawing.Size(137, 244);
            this.lbNaves.TabIndex = 13;
            this.lbNaves.SelectedIndexChanged += new System.EventHandler(this.lbNaves_SelectedIndexChanged);
            // 
            // wmp360
            // 
            this.wmp360.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmp360.Enabled = true;
            this.wmp360.Location = new System.Drawing.Point(811, 72);
            this.wmp360.Name = "wmp360";
            this.wmp360.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp360.OcxState")));
            this.wmp360.Size = new System.Drawing.Size(597, 426);
            this.wmp360.TabIndex = 15;
            // 
            // wbPdf
            // 
            this.wbPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPdf.Location = new System.Drawing.Point(0, 0);
            this.wbPdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPdf.Name = "wbPdf";
            this.wbPdf.Size = new System.Drawing.Size(311, 449);
            this.wbPdf.TabIndex = 0;
            // 
            // pb360
            // 
            this.pb360.Location = new System.Drawing.Point(1426, 536);
            this.pb360.Name = "pb360";
            this.pb360.Size = new System.Drawing.Size(209, 172);
            this.pb360.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb360.TabIndex = 16;
            this.pb360.TabStop = false;
            this.pb360.Click += new System.EventHandler(this.pb360_Click);
            // 
            // starships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 929);
            this.Controls.Add(this.pb360);
            this.Controls.Add(this.lbNaves);
            this.Controls.Add(this.dgvDatosnave);
            this.Controls.Add(this.lblNave);
            this.Controls.Add(this.pbSide);
            this.Controls.Add(this.pbFront);
            this.Controls.Add(this.pbSelected);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbRear);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.wmp360);
            this.Name = "starships";
            this.Text = "Starship";
            this.Load += new System.EventHandler(this.starships_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosnave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp360)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb360)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbSelected;
        private System.Windows.Forms.PictureBox pbFront;
        private System.Windows.Forms.PictureBox pbSide;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.PictureBox pbRear;
        private System.Windows.Forms.Label lblNave;
        private System.Windows.Forms.DataGridView dgvDatosnave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.ListBox lbNaves;
        private AxWMPLib.AxWindowsMediaPlayer wmp360;
        private System.Windows.Forms.WebBrowser wbPdf;
        private System.Windows.Forms.PictureBox pb360;
    }
}