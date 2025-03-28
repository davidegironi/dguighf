﻿#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using DG.DataConcurrencyHelper;
using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace DG.UI.GHF
{
    public class DGUIGHFApplication
    {
        /// <summary>
        /// Setup the Application
        /// </summary>
        public struct DGUIGHFApplicationConfig
        {
            /// <summary>
            /// Global Data Concurrency Helper enabler
            /// </summary>
            public bool isConcurrecyHelperEnabled;

            /// <summary>
            /// Tab Elements default Data Concurrency Helper enabler
            /// </summary>
            public bool defaultConcurrecyHelperEnabled;

            /// <summary>
            /// Tab Elements default Data Concurrency Helper is blocking
            /// </summary>
            public bool defaultConcurrecyHelperIsBlocking;

            /// <summary>
            /// Global Concurrency Helper connection string
            /// </summary>
            public string concurrecyHelperConnectionString;

            /// <summary>
            /// Global Concurrency Helper table prefix
            /// </summary>
            public string concurrecyHelperTablePrefix;

            /// <summary>
            /// Tab Elements default data consistency check on save
            /// </summary>
            public bool defaultConsistencyCheckOnSave;

            /// <summary>
            /// First form to be loaded
            /// </summary>
            public Type entryFormType;

            /// <summary>
            /// First form constructor parameter
            /// </summary>
            public object[] entryFormParameters;

            /// <summary>
            /// Display the splash screen on first Run
            /// </summary>
            public bool displaySplashScreen;

            /// <summary>
            /// Global IsEditing Blocker enabler
            /// </summary>
            public bool isEditingBlockEnabled;

            /// <summary>
            /// Enable or disable the custom exception handler
            /// </summary>
            public bool isStackTracerEnabled;

            /// <summary>
            /// Alternative sender email
            /// </summary>
            public string stackTracerSenderMail;

            /// <summary>
            /// Sender of the exception handler
            /// </summary>
            public string stackTracerSenderFrom;

            /// <summary>
            /// Application Web link
            /// </summary>
            public string appWeblink;

            /// <summary>
            /// Language folder
            /// </summary>
            public string languageFolder;

            /// <summary>
            /// Language
            /// </summary>
            public string language;

            /// <summary>
            /// About page logo
            /// </summary>
            public Image aboutLogo;

            /// <summary>
            /// SplashScreen page logo
            /// </summary>
            public Image splashScreenLogo;

            /// <summary>
            /// Initialized the Application Configuration
            /// </summary>
            /// <param name="isConcurrecyHelperEnabled"></param>
            /// <param name="defaultConcurrecyHelperEnabled"></param>
            /// <param name="defaultConcurrecyHelperIsBlocking"></param>
            /// <param name="concurrecyHelperConnectionString"></param>
            /// <param name="concurrecyHelperTablePrefix"></param>
            /// <param name="defaultConsistencyCheckOnSave"></param>
            /// <param name="entryFormType"></param>
            /// <param name="entryFormParameters"></param>
            /// <param name="displaySplashScreen"></param>
            /// <param name="isEditingBlockEnabled"></param>
            /// <param name="isStackTracerEnabled"></param>
            /// <param name="stackTracerSenderMail"></param>
            /// <param name="stackTracerSenderFrom"></param>
            /// <param name="appWeblink"></param>
            /// <param name="languageFolder"></param>
            /// <param name="language"></param>
            /// <param name="aboutLogo"></param>
            /// <param name="splashScreenLogo"></param>
            public DGUIGHFApplicationConfig(
                bool isConcurrecyHelperEnabled,
                bool defaultConcurrecyHelperEnabled,
                bool defaultConcurrecyHelperIsBlocking,
                string concurrecyHelperConnectionString,
                string concurrecyHelperTablePrefix,
                bool defaultConsistencyCheckOnSave,
                Type entryFormType,
                object[] entryFormParameters,
                bool displaySplashScreen,
                bool isEditingBlockEnabled,
                bool isStackTracerEnabled,
                string stackTracerSenderMail,
                string stackTracerSenderFrom,
                string appWeblink,
                string languageFolder,
                string language,
                Image aboutLogo,
                Image splashScreenLogo)
            {
                this.isConcurrecyHelperEnabled = isConcurrecyHelperEnabled;
                this.defaultConcurrecyHelperEnabled = defaultConcurrecyHelperEnabled;
                this.defaultConcurrecyHelperIsBlocking = defaultConcurrecyHelperIsBlocking;
                this.concurrecyHelperConnectionString = concurrecyHelperConnectionString;
                this.concurrecyHelperTablePrefix = concurrecyHelperTablePrefix;
                this.defaultConsistencyCheckOnSave = defaultConsistencyCheckOnSave;
                this.entryFormType = entryFormType;
                this.entryFormParameters = entryFormParameters;
                this.displaySplashScreen = displaySplashScreen;
                this.isEditingBlockEnabled = isEditingBlockEnabled;
                this.isStackTracerEnabled = isStackTracerEnabled;
                this.stackTracerSenderMail = stackTracerSenderMail;
                this.stackTracerSenderFrom = stackTracerSenderFrom;
                this.appWeblink = appWeblink;
                this.languageFolder = languageFolder;
                this.language = language;
                this.aboutLogo = aboutLogo;
                this.splashScreenLogo = splashScreenLogo;
            }
        }

        /// <summary>
        /// Current user name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Check if Data Concurrency Helper is enabled
        /// </summary>
        public bool IsConcurrencyHelperEnabled { get; private set; }

        /// <summary>
        /// Data Concurrency Helper enabler inherited by Tab Elements
        /// </summary>
        public bool DefaultConcurrencyHelperEnabled { get; private set; }

        /// <summary>
        /// Data Concurrency Helper is blocking check inherited by Tab Elements
        /// </summary>
        public bool DefaultConcurrecyHelperIsBlocking { get; private set; }

        /// <summary>
        /// Data Concurrency Helper
        /// </summary>
        public DGDataConcurrencyHelper ConcurrencyHelper { get; private set; }

        /// <summary>
        /// Data consistency check On Save check inherited by Tab Elements
        /// </summary>
        public bool DefaultConsistencyCheckOnSave { get; private set; }

        /// <summary>
        /// Check if is Editing Block is enabled
        /// </summary>
        public bool IsEditingBlockEnabled { get; set; }

        /// <summary>
        /// Check if any form is Editing
        /// </summary>
        public bool IsEditing { get; set; }

        /// <summary>
        /// Set last editing form
        /// </summary>
        internal string LastEditingName { get; set; }

        /// <summary>
        /// Application Version
        /// </summary>
        public string AppVersion { get; private set; }

        /// <summary>
        /// Application Name
        /// </summary>
        public string AppName { get; private set; }

        /// <summary>
        /// Application Title
        /// </summary>
        public string AppTitle { get; private set; }

        /// <summary>
        /// Application Title
        /// </summary>
        public string AppProduct { get; private set; }

        /// <summary>
        /// Application Copyright
        /// </summary>
        public string AppCopyright { get; private set; }

        /// <summary>
        /// Application Company
        /// </summary>
        public string AppCompany { get; private set; }

        /// <summary>
        /// Application Web link
        /// </summary>
        public string AppWeblink { get; private set; }

        /// <summary>
        /// Language filename
        /// </summary>
        public string LanguageFilename { get; set; }

        /// <summary>
        /// About page logo
        /// </summary>
        public Image AboutLogo { get; private set; }

        /// <summary>
        /// SplashScreen page logo
        /// </summary>
        public Image SplashScreenLogo { get; private set; }

        /// <summary>
        /// Check if StackTracer is enabled
        /// </summary>
        public bool IsStackTracerEnabled { get; private set; }

        /// <summary>
        /// Sender for the exception feedback
        /// </summary>
        public string StackTracerSenderFrom { get; private set; }

        /// <summary>
        /// Email used to send exception feedback
        /// </summary>
        public string StackTracerSenderMail { get; private set; }

        /// <summary>
        /// Application configuration
        /// </summary>
        private DGUIGHFApplicationConfig m_applicationConfig = new DGUIGHFApplicationConfig();

        /// <summary>
        /// Entry form to be loaded at Run
        /// </summary>
        private Type m_entryFormType = null;

        /// <summary>
        /// Entry form parameters
        /// </summary>
        private object[] m_entryFormParameters = null;

        /// <summary>
        /// Display splash screen on Run
        /// </summary>
        private bool m_displaySplashScreen = false;

        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="applicationConfig"></param>
        public DGUIGHFApplication(DGUIGHFApplicationConfig applicationConfig)
        {
            //set application configuration
            m_applicationConfig = applicationConfig;

            //generate a random username
            UserName = Guid.NewGuid().ToString();

            //get app info
            AppVersion = Assembly.GetCallingAssembly().GetName().Version.ToString();
            AppName = Assembly.GetCallingAssembly().GetName().Name.ToString();
            AppTitle = ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetCallingAssembly(), typeof(AssemblyTitleAttribute), false)).Title;
            AppProduct = ((AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetCallingAssembly(), typeof(AssemblyProductAttribute), false)).Product;
            if (((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetCallingAssembly(), typeof(AssemblyCopyrightAttribute), false)) != null)
                AppCopyright = ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetCallingAssembly(), typeof(AssemblyCopyrightAttribute), false)).Copyright;
            else
                AppCopyright = "";
            if (((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetCallingAssembly(), typeof(AssemblyCompanyAttribute), false)) != null)
                AppCompany = ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetCallingAssembly(), typeof(AssemblyCompanyAttribute), false)).Company;
            else
                AppCompany = "";
            AppWeblink = applicationConfig.appWeblink;

            //language
            LanguageFilename = applicationConfig.languageFolder + "\\" + applicationConfig.language + ".json";

            //about page logo
            AboutLogo = applicationConfig.aboutLogo;

            //splash screen logo
            SplashScreenLogo = applicationConfig.splashScreenLogo;

            //set entryForm
            m_entryFormType = applicationConfig.entryFormType;
            m_entryFormParameters = applicationConfig.entryFormParameters;

            //set splash screen display
            m_displaySplashScreen = applicationConfig.displaySplashScreen;

            //set is editing block enabler
            IsEditingBlockEnabled = applicationConfig.isEditingBlockEnabled;

            //initialize DataConcurrencyHelper
            IsConcurrencyHelperEnabled = applicationConfig.isConcurrecyHelperEnabled;
            DefaultConcurrencyHelperEnabled = applicationConfig.defaultConcurrecyHelperEnabled;
            DefaultConcurrecyHelperIsBlocking = applicationConfig.defaultConcurrecyHelperIsBlocking;
            if (DefaultConcurrencyHelperEnabled && !IsConcurrencyHelperEnabled)
            {
                throw new Exception("Concurrency Helper may not be disabled globally and enabled on elements.");
            }
            if (IsConcurrencyHelperEnabled)
                ConcurrencyHelper = new DGDataConcurrencyHelper(applicationConfig.concurrecyHelperConnectionString, applicationConfig.concurrecyHelperTablePrefix);

            //initialize consistency check
            DefaultConsistencyCheckOnSave = applicationConfig.defaultConsistencyCheckOnSave;

            //set stacktracer enabler
            IsStackTracerEnabled = applicationConfig.isStackTracerEnabled;
            StackTracerSenderMail = applicationConfig.stackTracerSenderMail;
            StackTracerSenderFrom = applicationConfig.stackTracerSenderFrom;
        }

        /// <summary>
        /// Handle a Thread exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="t"></param>
        /// <param name="stacktracerSenderFrom"></param>
        private static void ThreadException_Hanlder(object sender, ThreadExceptionEventArgs t, string stacktracerSenderFrom, string stacktracerSenderMail)
        {
            try
            {
                if (new DGUIGHFFormStackTracer(t.Exception, false, stacktracerSenderFrom, stacktracerSenderMail).ShowDialog() == DialogResult.Abort)
                {
                    System.Environment.Exit(0);
                }
            }
            catch
            {
                if (MessageBox.Show("There was an error loading the Exception.\nClose the application?\nIf you click Yes the application will be shutdown immediately. If you click No the application will ignore this error.\nPlease report us this error at the mail address: " + stacktracerSenderMail, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Abort)
                {
                    System.Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Hanlde an Unhandled exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="stacktracerSenderFrom"></param>
        private static void CurrentDomainUnhandledException_Handler(object sender, UnhandledExceptionEventArgs e, string stacktracerSenderFrom, string stacktracerSenderMail)
        {
            try
            {
                Exception ex = e.ExceptionObject as Exception;
                if (new DGUIGHFFormStackTracer(ex, true, stacktracerSenderFrom, stacktracerSenderMail).ShowDialog() == DialogResult.Abort)
                {
                    System.Environment.Exit(0);
                }
            }
            catch
            {
                if (MessageBox.Show("There was an error loading the Exception.\nClose the application?\nIf you click Yes the application will be shutdown immediately. If you click No the application will ignore this error.\nPlease report us this error at the mail address: " + stacktracerSenderMail, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Abort)
                {
                    System.Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Run the entry Form
        /// </summary>
        /// <param name="uighfApplication"></param>
        public static void Run(DGUIGHFApplication uighfApplication)
        {
            //attach the custom stackTracker
            if (uighfApplication.IsStackTracerEnabled)
            {
                Application.ThreadException += new ThreadExceptionEventHandler((sender, t) => ThreadException_Hanlder(sender, t, uighfApplication.StackTracerSenderFrom, uighfApplication.StackTracerSenderMail));
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler((sender, e) => CurrentDomainUnhandledException_Handler(sender, e, uighfApplication.StackTracerSenderFrom, uighfApplication.StackTracerSenderMail));
            }

            Form form = (Form)Activator.CreateInstance(uighfApplication.m_entryFormType, uighfApplication.m_entryFormParameters);
            if (uighfApplication.m_displaySplashScreen)
            {
                DGUIGHFFormSplashScreen.DisplaySplashScreen(form, uighfApplication.AppProduct, uighfApplication.AppCopyright, uighfApplication.SplashScreenLogo);
            }

            Application.Run(form);
        }

    }
}
