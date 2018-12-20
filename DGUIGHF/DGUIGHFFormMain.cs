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
    public class DGUIGHFFormMain : Form
    {
        /// <summary>
        /// Reference to UIGHFApplication
        /// </summary>
        protected DGUIGHFApplication UIGHFApplication { get; private set; }

        /// <summary>
        /// Check if is Editing Mode enabled
        /// </summary>
        protected bool CheckIsEditing { get; private set; }

        /// <summary>
        /// Check if is form can close
        /// </summary>
        protected bool CheckIsClosing { get; private set; }

        /// <summary>
        /// Form language
        /// </summary>
        public DGUIGHFLanguageBase languageBase = new DGUIGHFLanguageBase();

        /// <summary>
        /// Langauge Helper
        /// </summary>
        public DGUIGHFLanguageHelper LanguageHelper { get; private set; }

        /// <summary>
        /// Constructor for Main form
        /// </summary>
        public DGUIGHFFormMain()
        {
            CheckIsClosing = false;
        }

        /// <summary>
        /// Initialize the Main form
        /// </summary>
        /// <param name="uighfApplication"></param>
        /// <param name="checkIsEditing"></param>
        public void Initialize(DGUIGHFApplication uighfApplication, bool checkIsEditing)
        {
            UIGHFApplication = uighfApplication;

            CheckIsEditing = checkIsEditing;

            //set language
            LanguageHelper = new DGUIGHFLanguageHelper(this);
            AddLanguageComponents();
            LanguageHelper.LoadFromFile(uighfApplication.LanguageFilename);
            SetAdditionalLanguage();
        }

        /// <summary>
        /// Initialize the Main form, set default value of check Editing Mode to true
        /// </summary>
        /// <param name="uighfApplication"></param>
        public void Initialize(DGUIGHFApplication uighfApplication)
        {
            Initialize(uighfApplication, true);
        }

        /// <summary>
        /// Add language components to this form
        /// </summary>
        public virtual void AddLanguageComponents()
        { }

        /// <summary>
        /// Set additional language for this form
        /// </summary>
        public virtual void SetAdditionalLanguage()
        { }

        /// <summary>
        /// Menu item Exit application click
        /// </summary>
        /// <param name="s"></param>
        /// <param name="checkIsEditing"></param>
        public void ExitApplication(object s, bool checkIsEditing)
        {
            if (UIGHFApplication == null)
                return;

            if (checkIsEditing && UIGHFApplication.IsEditing)
                return;

            if (MessageBox.Show(languageBase.mainExitMessageBoxText, languageBase.mainExitMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CheckIsClosing = true;
                (s as Form).Close();
            }
            else
            {
                CheckIsClosing = false;
            }
        }

        /// <summary>
        /// Menu item Exit application click, use default value to check Editing Mode
        /// </summary>
        /// <param name="s"></param>
        public void ExitApplication(object s)
        {
            ExitApplication(s, CheckIsEditing);
        }

        /// <summary>
        /// Form closing handler helper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="checkIsEditing"></param>
        public void FormClosingHandler(object sender, FormClosingEventArgs e, bool checkIsEditing)
        {
            if (!CheckIsClosing)
            {
                e.Cancel = true;
                ExitApplication(sender, checkIsEditing);
            }
        }

        /// <summary>
        /// Form closing handler helper, use default value to check Editing Mode
        /// </summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FormClosingHandler(object sender, FormClosingEventArgs e)
        {
            FormClosingHandler(sender, e, CheckIsEditing);
        }

        /// <summary>
        /// Menu item Minimize All forms click
        /// </summary>
        /// <param name="s"></param>
        /// <param name="checkIsEditing"></param>
        public void MinimizeAllForms(object s, bool checkIsEditing)
        {
            if (UIGHFApplication == null)
                return;

            if (checkIsEditing && UIGHFApplication.IsEditing)
                return;

            foreach (Form fa in (s as Form).MdiChildren)
            {
                fa.WindowState = FormWindowState.Minimized;
            }
        }

        /// <summary>
        /// Menu item Minimize All forms click, use default value to check Editing Mode
        /// </summary>
        /// <param name="s"></param>
        public void MinimizeAllForms(object s)
        {
            MinimizeAllForms(s, CheckIsEditing);
        }

        /// <summary>
        /// Menu item Close All forms click
        /// </summary>
        /// <param name="s"></param>
        /// <param name="checkIsEditing"></param>
        public void CloseAllForms(object s, bool checkIsEditing)
        {
            if (UIGHFApplication == null)
                return;

            if (checkIsEditing && UIGHFApplication.IsEditing)
                return;

            foreach (Form fa in (s as Form).MdiChildren)
            {
                fa.Close();
            }
        }

        /// <summary>
        /// Menu item Close All forms click, use default value to check Editing Mode
        /// </summary>
        /// <param name="s"></param>
        public void CloseAllForms(object s)
        {
            CloseAllForms(s, CheckIsEditing);
        }

        /// <summary>
        /// Menu item Fit All forms click
        /// </summary>
        /// <param name="s"></param>
        /// <param name="checkIsEditing"></param>
        public void FitAllForms(object s, bool checkIsEditing)
        {
            if (UIGHFApplication == null)
                return;

            if (checkIsEditing && UIGHFApplication.IsEditing)
                return;

            //get max value for minimum width and height
            int maxminWidth = 300;
            int maxminHeight = 300;
            foreach (Form fa in (s as Form).MdiChildren)
            {
                if (fa.MinimumSize.Height > maxminHeight)
                    maxminHeight = fa.MinimumSize.Height;
                if (fa.MinimumSize.Width > maxminWidth)
                    maxminWidth = fa.MinimumSize.Width;
            }

            //get actual width and height
            int width = (s as Form).ClientRectangle.Width;
            int height = (s as Form).ClientRectangle.Height;
            foreach (Control c in (s as Form).Controls)
            {
                if (c as MdiClient != null)
                {
                    width = c.ClientSize.Width;
                    height = c.ClientSize.Height;
                    break;
                }
            }

            //check how many forms fit the parent, and fit that in lines
            int widthSplit = (int)Math.Floor((decimal)width / (decimal)maxminWidth);
            int heightSplit = (int)Math.Floor((decimal)height / (decimal)maxminHeight);
            if ((s as Form).MdiChildren.Length < widthSplit * heightSplit)
            {
                if ((s as Form).MdiChildren.Length < widthSplit)
                {
                    widthSplit = (s as Form).MdiChildren.Length;
                    heightSplit = 1;
                }
                else
                    heightSplit = (int)Math.Ceiling((decimal)(s as Form).MdiChildren.Length / (decimal)widthSplit);
            }
            if (widthSplit == 0)
                widthSplit = 1;
            if (heightSplit == 0)
                heightSplit = 1;

            //get the width for forms
            int widthSel = maxminWidth + (int)Math.Floor(((decimal)width - ((decimal)widthSplit * (decimal)maxminWidth)) / (decimal)widthSplit);
            int heightSel = maxminHeight + (int)Math.Floor(((decimal)height - ((decimal)heightSplit * (decimal)maxminHeight)) / (decimal)heightSplit);

            //iterate and set forms size
            int x = 0;
            int y = 0;
            int xcount = 0;
            int ycount = 0;
            bool minimizeform = false;
            for (int i = (s as Form).MdiChildren.Length - 1; i >= 0; i--)
            {
                Form fa = (s as Form).MdiChildren[i];

                //reset forms states
                fa.WindowState = FormWindowState.Normal;

                if (minimizeform)
                {
                    fa.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    //set size and location
                    fa.Size = new Size(widthSel, heightSel);
                    fa.Location = new Point(x, y);

                    //fill by line
                    x += widthSel;

                    xcount++;
                    if (xcount >= widthSplit)
                    {
                        xcount = 0;
                        ycount++;
                        x = 0;
                        y += heightSel;

                        //rebuild width for the last line
                        if (ycount + 1 == heightSplit)
                        {
                            if ((s as Form).MdiChildren.Length < widthSplit * heightSplit)
                            {
                                int lastlinenum = (s as Form).MdiChildren.Length - (widthSplit * ycount);
                                widthSel = maxminWidth + (int)Math.Floor(((decimal)width - ((decimal)lastlinenum * (decimal)maxminWidth)) / (decimal)lastlinenum);
                            }
                        }
                    }

                    if (ycount >= heightSplit)
                    {
                        minimizeform = true;
                    }
                }
            }
        }

        /// <summary>
        /// Menu item Fit All forms click, use default value to check Editing Mode
        /// </summary>
        /// <param name="s"></param>
        public void FitAllForms(object s)
        {
            FitAllForms(s, CheckIsEditing);
        }

        /// <summary>
        /// Show the About form
        /// </summary>
        /// <param name="checkIsEditing"></param>
        public void DisplayAbout(bool checkIsEditing)
        {
            if (UIGHFApplication == null)
                return;

            if (checkIsEditing && UIGHFApplication.IsEditing)
                return;

            new DGUIGHFFormAbout(UIGHFApplication.AppProduct, UIGHFApplication.AppVersion, UIGHFApplication.AppCompany, UIGHFApplication.AppCopyright, UIGHFApplication.AppWeblink, UIGHFApplication.AboutLogo, languageBase).ShowDialog();
        }

        /// <summary>
        /// Show the About form, use default value to check Editing Mode
        /// </summary>
        public void DisplayAbout()
        {
            DisplayAbout(CheckIsEditing);
        }

        /// <summary>
        /// Show a Form
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="checkIsEditing"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Form ShowForm(object s, Type t, bool checkIsEditing, params object[] args)
        {
            if (UIGHFApplication == null)
                return null;

            if (checkIsEditing && UIGHFApplication.IsEditing)
                return null;

            bool loadme = true;
            Form f = null;
            foreach (Form fa in (s as Form).MdiChildren)
            {
                if (fa.GetType() == t)
                {
                    f = fa;
                    loadme = false;
                }
            }

            if (loadme)
            {
                if (args != null)
                {
                    f = (Form)Activator.CreateInstance(t, args);
                }
                f.MdiParent = (s as Form);
                f.WindowState = FormWindowState.Minimized;
                f.Show();
                f.WindowState = FormWindowState.Maximized;
            }
            else
            {
                f.Show();
                f.WindowState = FormWindowState.Maximized;
            }
            return f;
        }

        /// <summary>
        /// Show a Form, use default value to check Editing Mode
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Form ShowForm(object s, Type t, params object[] args)
        {
            return ShowForm(s, t, CheckIsEditing, args);
        }

        /// <summary>
        /// Show a Form, use default value to check Editing Mode
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public Form ShowForm(object s, Type t)
        {
            return ShowForm(s, t, CheckIsEditing);
        }

        /// <summary>
        /// Close a form
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        public void CloseForm(object s, Type t)
        {
            foreach (Form fa in (s as Form).MdiChildren)
            {
                if (fa.GetType() == t)
                {
                    fa.Close();
                    break;
                }
            }
        }

        /// <summary>
        /// Get an opened form
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        public Form GetForm(object s, Type t)
        {
            Form ret = null;

            foreach (Form fa in (s as Form).MdiChildren)
            {
                if (fa.GetType() == t)
                {
                    ret = fa;
                    break;
                }
            }

            return ret;
        }
    }
}
