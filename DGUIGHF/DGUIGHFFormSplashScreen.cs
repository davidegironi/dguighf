#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DG.UI.GHF
{
    public partial class DGUIGHFFormSplashScreen : Form
    {
        private static DGUIGHFFormSplashScreen splashscreen = null;
        private static Thread backgroundThread = null;
        private static bool closeme = false;
        private static string loading = "...";
        private System.Windows.Forms.Timer updateviewTimer;

        /// <summary>
        /// Display a SplashScreen
        /// </summary>
        /// <param name="firstForm"></param>
        /// <param name="appName"></param>
        /// <param name="appCopyright"></param>
        /// <param name="logo"></param>
        public static void DisplaySplashScreen(Form firstForm, string appName, string appCopyright, Image logo)
        {
            //view loading splash screen
            AppDomain.CurrentDomain.AssemblyLoad += new AssemblyLoadEventHandler(SetSpashScreenStatus);
            DGUIGHFFormSplashScreen.ShowSplashScreen(appName, appCopyright, logo);
            Application.DoEvents();
            AppDomain.CurrentDomain.AssemblyLoad -= SetSpashScreenStatus;
            DGUIGHFFormSplashScreen.SetStatus("Building UI and Opening DB Connections");

            //show this screen at least 500ms
            Thread.Sleep(500);

            //attach the event to the first form displaied to close the splash screen
            firstForm.Activated += new System.EventHandler(FirstForm_Activated);
        }

        /// <summary>
        /// Display a SplashScreen
        /// </summary>
        /// <param name="firstForm"></param>
        /// <param name="appName"></param>
        /// <param name="appCopyright"></param>
        public static void DisplaySplashScreen(Form firstForm, string appName, string appCopyright)
        {
            DisplaySplashScreen(firstForm, appName, appCopyright, null);
        }

        /// <summary>
        /// Initialize SplashScreen
        /// </summary>
        /// <param name="appProduct"></param>
        /// <param name="appCopyright"></param>
        /// <param name="logo"></param>
        private DGUIGHFFormSplashScreen(string appProduct, string appCopyright, Image logo)
        {
            InitializeComponent();

            //handler timer
            updateviewTimer = new System.Windows.Forms.Timer();
            updateviewTimer.Enabled = true;
            updateviewTimer.Tick += new System.EventHandler(this.updateviewTimer_Tick);

            try
            {
                appCopyright = appCopyright + (appCopyright[appCopyright.Length - 1].ToString() != "." ? "." : "") + " All rights reserved.";
            }
            catch { }

            //set labels
            label_application.Text = appProduct;
            label_copyright.Text = appCopyright;

            if (logo != null)
                pictureBox_logo.Image = logo;
        }

        /// <summary>
        /// Show the SplashScreen
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="appCopyright"></param>
        /// <param name="logo"></param>
        private static void ShowSplashScreen(string appName, string appCopyright, Image logo)
        {
            if (splashscreen != null)
                return;
            backgroundThread = new Thread(() => DGUIGHFFormSplashScreen.ShowForm(appName, appCopyright, logo));

            backgroundThread.IsBackground = true;
#if NETFRAMEWORK
            backgroundThread.SetApartmentState(ApartmentState.STA);
#endif
            backgroundThread.Start();
        }

        /// <summary>
        /// Close the SplashScreen
        /// </summary>
        private static void CloseSplashScreen()
        {
#if NETFRAMEWORK
            backgroundThread.Abort();
#endif
            backgroundThread = null;
            splashscreen = null;
            closeme = true;
        }

        /// <summary>
        /// Get the SplashScreen
        /// </summary>
        /// <returns></returns>
        private static DGUIGHFFormSplashScreen GetSplashScreen()
        {
            return splashscreen;
        }

        /// <summary>
        /// Set the SplashScreen status
        /// </summary>
        /// <param name="loadingText"></param>
        private static void SetStatus(string loadingText)
        {
            loading = loadingText + "...";
        }

        /// <summary>
        /// Set SplashScreen Status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void SetSpashScreenStatus(object sender, AssemblyLoadEventArgs e)
        {
            DGUIGHFFormSplashScreen.SetStatus(e.LoadedAssembly.GetName().Name);
        }

        /// <summary>
        /// Attach activated event for first form, to close SplashScreen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void FirstForm_Activated(object sender, EventArgs e)
        {
            //close the splash screen if one is active
            if (DGUIGHFFormSplashScreen.GetSplashScreen() != null)
            {
                DGUIGHFFormSplashScreen.CloseSplashScreen();
                ((Form)sender).Activated -= new System.EventHandler(FirstForm_Activated);
                //activate the form
                ((Form)sender).Activate();
            }
        }

        /// <summary>
        /// Ticker hanlder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateviewTimer_Tick(object sender, EventArgs e)
        {
            label_loading.Text = loading;

            if (closeme)
                this.Close();
        }

        /// <summary>
        /// Build this form and run it
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="appCopyright"></param>
        /// <param name="logo"></param>
        private static void ShowForm(string appName, string appCopyright, Image logo)
        {
            if (splashscreen != null)
                return;
            splashscreen = new DGUIGHFFormSplashScreen(appName, appCopyright, logo);
            Application.Run(splashscreen);
        }
    }
}
