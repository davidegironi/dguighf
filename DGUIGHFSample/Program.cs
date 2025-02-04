using DG.UI.GHF;
using System;
using System.Configuration;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DG.UIGHFSample
{
    static class Program
    {
        public static DGUIGHFApplication uighfApplication = new DGUIGHFApplication(
            new DGUIGHFApplication.DGUIGHFApplicationConfig
            {
                entryFormType = typeof(FormMain),
                entryFormParameters = null,
                displaySplashScreen = true,
                isConcurrecyHelperEnabled = true,
                defaultConcurrecyHelperEnabled = false,
                defaultConcurrecyHelperIsBlocking = false,
                concurrecyHelperConnectionString = ConfigurationManager.AppSettings["dataconcurrencyhelperConnectionString"],
                concurrecyHelperTablePrefix = DataConcurrencyHelper.DGDataConcurrencyHelper.DefaultTablePrefix,
                defaultConsistencyCheckOnSave = false,
                isEditingBlockEnabled = true,
                isStackTracerEnabled = true,
                stackTracerSenderMail = "email@email.com",
                stackTracerSenderFrom = ConfigurationManager.AppSettings["stacktracerSenderFrom"],
                appWeblink = "http://www.example.com",
                languageFolder = "lang",
                language = ConfigurationManager.AppSettings["language"],
                aboutLogo = new Bitmap(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DG.UIGHFSample.about_logoimg.png")),
                splashScreenLogo = new Bitmap(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DG.UIGHFSample.splashscreen_logo.png")),
            });

        // Defines native methods for command out
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //attach the console
            if (args.Length > 0)
            {
                AttachConsole(ATTACH_PARENT_PROCESS);

                bool defaultlanguagerebuild = false;
                bool languagerebuild = false;

                if (args[0] == "-l")
                    languagerebuild = true;
                else if (args[0] == "-r")
                    defaultlanguagerebuild = true;

                Console.WriteLine();

                if (defaultlanguagerebuild)
                {
                    //rebuilt the default language
                    Console.WriteLine("Rebuilding the default language file \"" + DGUIGHFLanguageHelper.DefaultLanguageFilename + "\"...");
                    if (DGUIGHFLanguageHelper.RebuiltDefaultLanguage(DGUIGHFLanguageHelper.DefaultLanguageFilename))
                        Console.WriteLine("File successfully rebuilt.");
                    else
                        Console.WriteLine("Rebuild ends with errors.");
                }
                else if (languagerebuild)
                {
                    //rebuilt the loaded language
                    string[] messages = new string[] { };
                    Console.WriteLine("Rebuilt the language file \"" + Program.uighfApplication.LanguageFilename + "\"...");
                    if (DGUIGHFLanguageHelper.RebuiltLanguage(Program.uighfApplication.LanguageFilename, false, ref messages))
                    {
                        foreach (string message in messages)
                            Console.WriteLine("  " + message);
                        Console.WriteLine("File successfully rebuilt.");
                    }
                    else
                    {
                        Console.WriteLine("Rebuild ends with errors.");
                    }
                }

                Console.WriteLine();
                SendKeys.SendWait("{ENTER}");
                Application.Exit();
            }
            else
            {
                //show main form
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                DGUIGHFApplication.Run(Program.uighfApplication);
            }
        }
    }
}
