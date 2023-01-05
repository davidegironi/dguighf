#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace DG.UI.GHF
{
    public partial class DGUIGHFFormStackTracer : Form
    {
        private bool m_showdetails = false;

        private Exception m_ex = null;
        private bool m_unhandledException = false;

        private bool m_closeme = false;

        private string m_stacktracerMessage = "";
        private string m_stacktracerServiceFrom = "";

        /// <summary>
        /// Exception String Builder max depth
        /// </summary>
        private const int ExceptionStringBuilderMaxDepth = 10;

        /// <summary>
        /// Display the Stack Tracer Form
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="unhandledException"></param>
        /// <param name="stacktracerSenderFrom"></param>
        /// <param name="stacktracerSenderMail"></param>
        public DGUIGHFFormStackTracer(Exception ex, bool unhandledException, string stacktracerSenderFrom, string stacktracerSenderMail)
        {
            InitializeComponent();

            pictureBox1.Image = (Image)SystemIcons.Error.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            this.m_ex = ex;
            this.m_unhandledException = unhandledException;
            this.m_stacktracerServiceFrom = stacktracerSenderFrom;

            if (!String.IsNullOrEmpty(stacktracerSenderMail))
                label_info.Text += "\nPlease, help us build a better software, send an email at " + stacktracerSenderMail + "with all the above Details to our support Team.";

            ShowDetails(false);
        }

        /// <summary>
        /// Load the Stack Tracer Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGUIGHFFormStackTracer_Load(object sender, EventArgs e)
        {
            //setup the exception message

            string exceptionText = "";
            exceptionText += "EXCEPTION      : " + (m_unhandledException ? "Unhandled" : "Handled") + Environment.NewLine;

            try
            {
                string messageerr = m_ex.Message + "\n";
                label_errormessage.Text = "Error: " + messageerr;
            }
            catch { }

            try
            {
                DGUIGHFFormStackTracer.GetExceptionString(ref exceptionText, 0, m_ex);
            }
            catch
            {
                exceptionText += "EXCEPTIONERR   : There was an error loading this exception." + Environment.NewLine;
            }

            string exceptionDate = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.UtcNow);
            string applicationName = Assembly.GetEntryAssembly().GetName().Name.ToString();
            string applicationVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();

            m_stacktracerMessage += "DATETIME       : " + exceptionDate + Environment.NewLine;
            m_stacktracerMessage += "SENDER         : " + m_stacktracerServiceFrom + Environment.NewLine;
            m_stacktracerMessage += "APPLICATION    : " + applicationName + Environment.NewLine;
            m_stacktracerMessage += "VERSION        : " + applicationVersion + Environment.NewLine;
            m_stacktracerMessage += Environment.NewLine;
            m_stacktracerMessage += exceptionText;

            textBox_stacktrace.Text = exceptionText;
        }

        /// <summary>
        /// Exit click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_exit_Click(object sender, EventArgs e)
        {
            m_closeme = true;
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        /// <summary>
        /// Continue app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_continue_Click(object sender, EventArgs e)
        {
            m_closeme = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGUIGHFFormStackTracer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!m_closeme)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Show or hide details Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_details_Click(object sender, EventArgs e)
        {
            ShowDetails(!m_showdetails);
        }

        /// <summary>
        /// Show or hide details
        /// </summary>
        /// <param name="showdetails"></param>
        private void ShowDetails(bool showdetails)
        {
            if (!showdetails)
            {
                this.m_showdetails = false;
                panel_details.Visible = false;
                button_details.Text = "> Show Details";

                int actualwidth = this.Size.Width;
#if NETFRAMEWORK
                Size minsize = new Size(480, 320 - 124);
#else
                Size minsize = new Size(480, 345 - 124);
#endif
                if (this.Size.Height < minsize.Height)
                {
                    this.Size = minsize;
                }
                this.MinimumSize = minsize;
                this.MaximumSize = this.MinimumSize;
                this.WindowState = FormWindowState.Normal;
                this.MaximizeBox = false;
                this.Size = new Size(actualwidth, minsize.Height);
            }
            else
            {
                this.m_showdetails = true;
                panel_details.Visible = true;
                button_details.Text = "< Hide Details";

                int actualwidth = this.Size.Width;
#if NETFRAMEWORK
                Size minsize = new Size(480, 320);
#else
                Size minsize = new Size(480, 345);
#endif
                if (this.Size.Height < minsize.Height)
                {
                    this.Size = minsize;
                }
                this.MinimumSize = minsize;
                this.MaximumSize = new Size(0, 0);
                this.MaximizeBox = true;
                this.Size = new Size(actualwidth, minsize.Height);
            }
        }

        /// <summary>
        /// Build the Exception string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="depth"></param>
        /// <param name="ex"></param>
        private static void GetExceptionString(ref string s, int depth, Exception ex)
        {
            if (ex == null)
            {
                s += "EXCEPTIONERR   : No Exception found." + Environment.NewLine;
            }
            else
            {
                if (depth < ExceptionStringBuilderMaxDepth)
                {
                    if (depth > 0)
                    {
                        s += "INNEREXCEPTION   " + depth + Environment.NewLine;
                    }
                    s += "MESSAGE        : " + ex.Message + Environment.NewLine;
                    s += "SOURCE         : " + ex.Source + Environment.NewLine;
                    s += "TARGETSITE     : " + ex.TargetSite + Environment.NewLine;
                    s += "STACKTRACE     : " + Environment.NewLine + ex.StackTrace.ToString() + Environment.NewLine;
                    if (ex.InnerException != null)
                    {
                        s += "-------------------------------------------------------" + Environment.NewLine;
                        s += Environment.NewLine;
                        depth++;
                        try
                        {
                            DGUIGHFFormStackTracer.GetExceptionString(ref s, depth, ex.InnerException);
                        }
                        catch
                        {
                            s += "EXCEPTIONERR   : There was an error loading this exception." + Environment.NewLine;
                        }
                    }
                }
            }
        }
    }
}
