namespace DG.UI.GHF
{
    partial class DGUIGHFFormSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGUIGHFFormSplashScreen));
            this.label_loading = new System.Windows.Forms.Label();
            this.label_application = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_loader = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_loading
            // 
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.ForeColor = System.Drawing.Color.White;
            this.label_loading.Location = new System.Drawing.Point(12, 115);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(354, 23);
            this.label_loading.TabIndex = 2;
            this.label_loading.Text = "...";
            this.label_loading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_application
            // 
            this.label_application.Font = new System.Drawing.Font("Open Sans Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_application.ForeColor = System.Drawing.Color.White;
            this.label_application.Location = new System.Drawing.Point(7, 14);
            this.label_application.Name = "label_application";
            this.label_application.Size = new System.Drawing.Size(359, 92);
            this.label_application.TabIndex = 3;
            this.label_application.Text = "Application Name";
            this.label_application.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_copyright
            // 
            this.label_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyright.ForeColor = System.Drawing.Color.White;
            this.label_copyright.Location = new System.Drawing.Point(12, 241);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(280, 13);
            this.label_copyright.TabIndex = 4;
            this.label_copyright.Text = "Copyright";
            this.label_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 10);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panel2.Location = new System.Drawing.Point(330, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 10);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox_loader
            // 
            this.pictureBox_loader.Image = global::DG.UI.GHF.Properties.Resources.splashscreen_loader;
            this.pictureBox_loader.Location = new System.Drawing.Point(379, 16);
            this.pictureBox_loader.Name = "pictureBox_loader";
            this.pictureBox_loader.Size = new System.Drawing.Size(31, 31);
            this.pictureBox_loader.TabIndex = 8;
            this.pictureBox_loader.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackgroundImage = global::DG.UI.GHF.Properties.Resources.splashscreen_logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(302, 222);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(108, 30);
            this.pictureBox_logo.TabIndex = 5;
            this.pictureBox_logo.TabStop = false;
            // 
            // DGUIGHFFormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(425, 270);
            this.Controls.Add(this.pictureBox_loader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_loading);
            this.Controls.Add(this.label_application);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(425, 270);
            this.MinimumSize = new System.Drawing.Size(425, 270);
            this.Name = "DGUIGHFFormSplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.Label label_application;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_loader;
    }
}