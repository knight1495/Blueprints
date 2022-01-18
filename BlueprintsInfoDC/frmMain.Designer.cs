namespace BlueprintsInfoDC
{
    partial class frmMain
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
            this.btnStarkiller = new System.Windows.Forms.Button();
            this.btnSpaceships = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStarkiller
            // 
            this.btnStarkiller.Location = new System.Drawing.Point(89, 58);
            this.btnStarkiller.Margin = new System.Windows.Forms.Padding(4);
            this.btnStarkiller.Name = "btnStarkiller";
            this.btnStarkiller.Size = new System.Drawing.Size(128, 63);
            this.btnStarkiller.TabIndex = 1;
            this.btnStarkiller.Text = "Starkiller";
            this.btnStarkiller.UseVisualStyleBackColor = true;
            this.btnStarkiller.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSpaceships
            // 
            this.btnSpaceships.Location = new System.Drawing.Point(768, 58);
            this.btnSpaceships.Name = "btnSpaceships";
            this.btnSpaceships.Size = new System.Drawing.Size(128, 63);
            this.btnSpaceships.TabIndex = 2;
            this.btnSpaceships.Text = "Spaceships";
            this.btnSpaceships.UseVisualStyleBackColor = true;
            this.btnSpaceships.Click += new System.EventHandler(this.btnSpaceships_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSpaceships);
            this.Controls.Add(this.btnStarkiller);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStarkiller;
        private System.Windows.Forms.Button btnSpaceships;
    }
}