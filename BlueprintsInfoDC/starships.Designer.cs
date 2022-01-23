
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.wbPdf = new System.Windows.Forms.WebBrowser();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbSelected = new System.Windows.Forms.PictureBox();
            this.pbFront = new System.Windows.Forms.PictureBox();
            this.pbSide = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbRear = new System.Windows.Forms.PictureBox();
            this.pb360 = new System.Windows.Forms.PictureBox();
            this.lblNave = new System.Windows.Forms.Label();
            this.dgvDatosnave = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNaves = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosnave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wbPdf);
            this.panel1.Location = new System.Drawing.Point(211, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 270);
            this.panel1.TabIndex = 1;
            // 
            // wbPdf
            // 
            this.wbPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPdf.Location = new System.Drawing.Point(0, 0);
            this.wbPdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPdf.Name = "wbPdf";
            this.wbPdf.Size = new System.Drawing.Size(311, 270);
            this.wbPdf.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(640, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(278, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Spaceship technical Information";
            // 
            // pbSelected
            // 
            this.pbSelected.Location = new System.Drawing.Point(670, 105);
            this.pbSelected.Name = "pbSelected";
            this.pbSelected.Size = new System.Drawing.Size(234, 188);
            this.pbSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelected.TabIndex = 4;
            this.pbSelected.TabStop = false;
            // 
            // pbFront
            // 
            this.pbFront.Location = new System.Drawing.Point(630, 321);
            this.pbFront.Name = "pbFront";
            this.pbFront.Size = new System.Drawing.Size(62, 59);
            this.pbFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFront.TabIndex = 5;
            this.pbFront.TabStop = false;
            this.pbFront.Click += new System.EventHandler(this.pbFront_Click);
            // 
            // pbSide
            // 
            this.pbSide.Location = new System.Drawing.Point(698, 321);
            this.pbSide.Name = "pbSide";
            this.pbSide.Size = new System.Drawing.Size(62, 59);
            this.pbSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSide.TabIndex = 6;
            this.pbSide.TabStop = false;
            this.pbSide.Click += new System.EventHandler(this.pbSide_Click);
            // 
            // pbTop
            // 
            this.pbTop.Location = new System.Drawing.Point(766, 321);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(62, 59);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTop.TabIndex = 7;
            this.pbTop.TabStop = false;
            this.pbTop.Click += new System.EventHandler(this.pbTop_Click);
            // 
            // pbRear
            // 
            this.pbRear.Location = new System.Drawing.Point(834, 321);
            this.pbRear.Name = "pbRear";
            this.pbRear.Size = new System.Drawing.Size(62, 59);
            this.pbRear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRear.TabIndex = 8;
            this.pbRear.TabStop = false;
            this.pbRear.Click += new System.EventHandler(this.pbRear_Click);
            // 
            // pb360
            // 
            this.pb360.Location = new System.Drawing.Point(902, 321);
            this.pb360.Name = "pb360";
            this.pb360.Size = new System.Drawing.Size(62, 59);
            this.pb360.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb360.TabIndex = 9;
            this.pb360.TabStop = false;
            this.pb360.Click += new System.EventHandler(this.pb360_Click);
            // 
            // lblNave
            // 
            this.lblNave.AutoSize = true;
            this.lblNave.Location = new System.Drawing.Point(728, 409);
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
            this.dgvDatosnave.Location = new System.Drawing.Point(220, 325);
            this.dgvDatosnave.Name = "dgvDatosnave";
            this.dgvDatosnave.RowHeadersWidth = 51;
            this.dgvDatosnave.RowTemplate.Height = 24;
            this.dgvDatosnave.Size = new System.Drawing.Size(302, 150);
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
            // starships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 548);
            this.Controls.Add(this.lbNaves);
            this.Controls.Add(this.dgvDatosnave);
            this.Controls.Add(this.lblNave);
            this.Controls.Add(this.pb360);
            this.Controls.Add(this.pbRear);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.pbSide);
            this.Controls.Add(this.pbFront);
            this.Controls.Add(this.pbSelected);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "starships";
            this.Text = "Starship";
            this.Load += new System.EventHandler(this.starships_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb360)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosnave)).EndInit();
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
        private System.Windows.Forms.PictureBox pb360;
        private System.Windows.Forms.Label lblNave;
        private System.Windows.Forms.DataGridView dgvDatosnave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.ListBox lbNaves;
        private System.Windows.Forms.WebBrowser wbPdf;
    }
}