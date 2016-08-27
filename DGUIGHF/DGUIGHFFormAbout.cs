#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DG.UI.GHF
{
    public partial class DGUIGHFFormAbout : Form
    {
        private string appProduct;
        private string appVersion;
        private string appCompany;
        private string appCopyright;
        private string appWeblink;

        /// <summary>
        /// Form language
        /// </summary>
        public DGUIGHFLanguageBase languageBase = new DGUIGHFLanguageBase();

        /// <summary>
        /// Initialize the About Form
        /// </summary>
        /// <param name="appProduct"></param>
        /// <param name="appVersion"></param>
        /// <param name="appCompany"></param>
        /// <param name="appCopyright"></param>
        /// <param name="appWeblink"></param>
        /// <param name="logo"></param>
        /// <param name="language"></param>
        public DGUIGHFFormAbout(string appProduct, string appVersion, string appCompany, string appCopyright, string appWeblink, Image logo, DGUIGHFLanguageBase language)
        {
            InitializeComponent();

            this.appProduct = appProduct.Trim();
            this.appVersion = appVersion.Trim();
            this.appCompany = appCompany.Trim();
            this.appCopyright = appCopyright.Trim();
            this.appWeblink = appWeblink.Trim();

            if (logo != null)
                pictureBox_logoimg.Image = logo;

            if (language != null)
                languageBase = language;
            else
                languageBase = new DGUIGHFLanguageBase();
        }

        /// <summary>
        /// Initialize the About Form
        /// </summary>
        /// <param name="appProduct"></param>
        /// <param name="appVersion"></param>
        /// <param name="appCompany"></param>
        /// <param name="appCopyright"></param>
        /// <param name="appWeblink"></param>
        /// <param name="logo"></param>
        public DGUIGHFFormAbout(string appProduct, string appVersion, string appCompany, string appCopyright, string appWeblink, Image logo)
            : this(appProduct, appVersion, appCompany, appCopyright, appWeblink, logo, null)
        { }

        /// <summary>
        /// Initialize the About Form
        /// </summary>
        /// <param name="appProduct"></param>
        /// <param name="appVersion"></param>
        /// <param name="appCompany"></param>
        /// <param name="appCopyright"></param>
        /// <param name="appWeblink"></param>
        public DGUIGHFFormAbout(string appProduct, string appVersion, string appCompany, string appCopyright, string appWeblink)
            : this(appProduct, appVersion, appCompany, appCopyright, appWeblink, null)
        { }

        /// <summary>
        /// About form loader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAbout_Load(object sender, EventArgs e)
        {
            try
            {
                appCopyright = appCopyright + (appCopyright[appCopyright.Length - 1].ToString() != "." ? "." : "") + " All rights reserved.";
            }
            catch { }

            label_application.Text = appProduct;
            label_version.Text = languageBase.aboutVersion + appVersion;
            label_company.Text = appCompany;
            label_copyright.Text = appCopyright;
            label_weblink.Text = appWeblink;

            this.button_Ok.Select();
        }

        /// <summary>
        /// Close the about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click on the weblink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_weblink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(appWeblink);
        }
    }
}
