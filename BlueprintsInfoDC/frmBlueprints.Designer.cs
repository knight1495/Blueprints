namespace BlueprintsInfoDC
{
    partial class frmBlueprints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlueprints));
            this.pnlGeneralinfo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbxZoom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitol = new System.Windows.Forms.Label();
            this.picGeneral = new System.Windows.Forms.Panel();
            this.lblLaser = new ControlsDC.LabelTransparent();
            this.lblBase = new ControlsDC.LabelTransparent();
            this.lblSupply = new ControlsDC.LabelTransparent();
            this.lblZoomInfo = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlGeneralinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxZoom)).BeginInit();
            this.picGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneralinfo
            // 
            this.pnlGeneralinfo.Controls.Add(this.lblDetails);
            this.pnlGeneralinfo.Controls.Add(this.lblTitulo);
            this.pnlGeneralinfo.Controls.Add(this.pbxZoom);
            this.pnlGeneralinfo.Controls.Add(this.label1);
            this.pnlGeneralinfo.Controls.Add(this.lblTitol);
            this.pnlGeneralinfo.Controls.Add(this.picGeneral);
            this.pnlGeneralinfo.Controls.Add(this.lblZoomInfo);
            this.pnlGeneralinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralinfo.ForeColor = System.Drawing.Color.Yellow;
            this.pnlGeneralinfo.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralinfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGeneralinfo.Name = "pnlGeneralinfo";
            this.pnlGeneralinfo.Size = new System.Drawing.Size(1480, 891);
            this.pnlGeneralinfo.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(1049, 89);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(401, 268);
            this.lblTitulo.TabIndex = 27;
            // 
            // pbxZoom
            // 
            this.pbxZoom.Location = new System.Drawing.Point(657, 90);
            this.pbxZoom.Name = "pbxZoom";
            this.pbxZoom.Size = new System.Drawing.Size(350, 350);
            this.pbxZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxZoom.TabIndex = 25;
            this.pbxZoom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "StarKiller Technical Data";
            // 
            // lblTitol
            // 
            this.lblTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitol.Location = new System.Drawing.Point(692, 596);
            this.lblTitol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitol.Name = "lblTitol";
            this.lblTitol.Size = new System.Drawing.Size(743, 48);
            this.lblTitol.TabIndex = 23;
            this.lblTitol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGeneral
            // 
            this.picGeneral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGeneral.BackgroundImage")));
            this.picGeneral.Controls.Add(this.lblLaser);
            this.picGeneral.Controls.Add(this.lblBase);
            this.picGeneral.Controls.Add(this.lblSupply);
            this.picGeneral.Location = new System.Drawing.Point(31, 89);
            this.picGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.picGeneral.Name = "picGeneral";
            this.picGeneral.Size = new System.Drawing.Size(467, 369);
            this.picGeneral.TabIndex = 22;
            // 
            // lblLaser
            // 
            this.lblLaser.BackColor = System.Drawing.Color.Crimson;
            this.lblLaser.Caption = "click here";
            this.lblLaser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLaser.DimmedColor = System.Drawing.Color.Yellow;
            this.lblLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaser.ForeColor = System.Drawing.Color.Transparent;
            this.lblLaser.Location = new System.Drawing.Point(323, 71);
            this.lblLaser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblLaser.Name = "lblLaser";
            this.lblLaser.Opacity = 1;
            this.lblLaser.Radius = 0;
            this.lblLaser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLaser.Size = new System.Drawing.Size(128, 100);
            this.lblLaser.TabIndex = 25;
            this.lblLaser.Tag = "1";
            this.lblLaser.Click += new System.EventHandler(this.labelTransparent2_Click);
            // 
            // lblBase
            // 
            this.lblBase.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblBase.Caption = "Click";
            this.lblBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBase.DimmedColor = System.Drawing.Color.Yellow;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.Color.Transparent;
            this.lblBase.Location = new System.Drawing.Point(1, 1);
            this.lblBase.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblBase.Name = "lblBase";
            this.lblBase.Opacity = 1;
            this.lblBase.Radius = 0;
            this.lblBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBase.Size = new System.Drawing.Size(69, 59);
            this.lblBase.TabIndex = 24;
            this.lblBase.Tag = "3";
            this.lblBase.Load += new System.EventHandler(this.lblBase_Load);
            this.lblBase.Click += new System.EventHandler(this.labelTransparent1_Click);
            // 
            // lblSupply
            // 
            this.lblSupply.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSupply.Caption = "click here";
            this.lblSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupply.DimmedColor = System.Drawing.Color.Yellow;
            this.lblSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupply.ForeColor = System.Drawing.Color.Transparent;
            this.lblSupply.Location = new System.Drawing.Point(159, 116);
            this.lblSupply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblSupply.Name = "lblSupply";
            this.lblSupply.Opacity = 1;
            this.lblSupply.Radius = 0;
            this.lblSupply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupply.Size = new System.Drawing.Size(153, 132);
            this.lblSupply.TabIndex = 23;
            this.lblSupply.Tag = "2";
            this.lblSupply.Click += new System.EventHandler(this.lblSupply_Click);
            // 
            // lblZoomInfo
            // 
            this.lblZoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoomInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZoomInfo.Location = new System.Drawing.Point(36, 474);
            this.lblZoomInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZoomInfo.Name = "lblZoomInfo";
            this.lblZoomInfo.Size = new System.Drawing.Size(445, 98);
            this.lblZoomInfo.TabIndex = 17;
            this.lblZoomInfo.Text = "Check in the image for detailed area  and click to enlarge it";
            this.lblZoomInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetails
            // 
            this.lblDetails.Location = new System.Drawing.Point(654, 474);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(759, 368);
            this.lblDetails.TabIndex = 28;
            this.lblDetails.Text = "label2";
            // 
            // frmBlueprints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1480, 891);
            this.Controls.Add(this.pnlGeneralinfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBlueprints";
            this.Text = "frmBlueprints";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlGeneralinfo.ResumeLayout(false);
            this.pnlGeneralinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxZoom)).EndInit();
            this.picGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneralinfo;
        private System.Windows.Forms.Label lblZoomInfo;
        private System.Windows.Forms.Panel picGeneral;
        private ControlsDC.LabelTransparent lblSupply;
        private ControlsDC.LabelTransparent lblLaser;
        private ControlsDC.LabelTransparent lblBase;
        private System.Windows.Forms.Label lblTitol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxZoom;
        private System.Windows.Forms.Label lblDetails;
    }
}