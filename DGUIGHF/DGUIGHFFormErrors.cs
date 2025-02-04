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
    public partial class DGUIGHFFormErrors : Form
    {
        private bool m_showdetails = false;

        private string m_errors = "";

        private Buttons _buttons = Buttons.OK;

        /// <summary>
        /// Buttons to display
        /// OK returns DialogResult.Cancel
        /// ContinueCancel returns DialogResult.Ignore | DialogResult.Cancel
        /// </summary>
        public enum Buttons { OK, ContinueCancel }

        /// <summary>
        /// Form language
        /// </summary>
        public DGUIGHFLanguageBase languageBase = new DGUIGHFLanguageBase();

        /// <summary>
        /// Display Errors happened
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="expanded"></param>
        /// <param name="buttons"></param>
        /// <param name="language"></param>
        public DGUIGHFFormErrors(string errors, bool expanded, Buttons buttons, DGUIGHFLanguageBase language)
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;

            this._buttons = buttons;

            pictureBox1.Image = global::DG.UI.GHF.Properties.Resources.systemicon_exclamation;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            if (this._buttons == Buttons.OK)
                button_left.Visible = false;

            m_errors = errors;
            if (String.IsNullOrEmpty(m_errors))
                expanded = false;

            if (language != null)
                languageBase = language;
            else
                languageBase = new DGUIGHFLanguageBase();

            ShowDetails(expanded);
        }

        /// <summary>
        /// Display Errors happened
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="expanded"></param>
        /// <param name="buttons"></param>
        public DGUIGHFFormErrors(string errors, bool expanded, Buttons buttons)
            : this(errors, expanded, buttons, null)
        { }

        /// <summary>
        /// Display Errors happened
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="expanded"></param>
        /// <param name="language"></param>
        public DGUIGHFFormErrors(string errors, bool expanded, DGUIGHFLanguageBase language)
            : this(errors, expanded, Buttons.OK, language)
        { }

        /// <summary>
        /// Display Errors happened
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="expanded"></param>
        public DGUIGHFFormErrors(string errors, bool expanded)
            : this(errors, expanded, Buttons.OK, null)
        { }

        /// <summary>
        /// Load the Data Error Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGUIGHFFormErrors_Load(object sender, EventArgs e)
        {
            this.Text = languageBase.errorsTitle;
            label_info.Text = languageBase.errorsInfoLabel;
            button_left.Text = languageBase.errorsContinueButton;
            if (_buttons == Buttons.OK)
                button_right.Text = languageBase.errorsOKButton;
            else
                button_right.Text = languageBase.errorsCancelButton;

            //setup the error message
            textBox_errors.Text = m_errors;

            //set button focus
            if (this._buttons == Buttons.OK)
                button_right.Select();
            else if (this._buttons == Buttons.ContinueCancel)
                button_left.Select();
        }

        /// <summary>
        /// Right button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_right_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Left button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_left_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
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
                button_details.Text = languageBase.errorsShowDetailsButton;

                int actualwidth = this.Size.Width;
                Size minsize = new Size(480, 320 - 184);
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
                button_details.Text = languageBase.errorsHideDetailsButton;

                int actualwidth = this.Size.Width;
                Size minsize = new Size(480, 320);
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

    }
}
