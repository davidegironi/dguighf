using DG.UI.GHF;
using DG.UIGHFSample.Model;
using System;

namespace DG.UIGHFSample
{
    public partial class FormMain : DGUIGHFFormMain
    {
        private DGUIGHFSampleModel samplemodel = null;

        public FormMain()
        {
            InitializeComponent();

            Initialize(Program.uighfApplication);
        }

        public override void AddLanguageComponents()
        {
            LanguageHelper.AddComponent(blogsToolStripMenuItem);
        }

        public override void SetAdditionalLanguage()
        {
            samplemodel = new DGUIGHFSampleModel();
            samplemodel.LanguageHelper.LoadFromFile(Program.uighfApplication.LanguageFilename);
            LanguageHelper.AddAdditionalLanguage(samplemodel.LanguageHelper.Get());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //load the entity framework
            samplemodel = new DGUIGHFSampleModel();
            samplemodel.Blogs.Find(-1);
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinimizeAllForms(this);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication(this);
        }

        private void FormMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            FormClosingHandler(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAbout();
        }

        private void blogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(this, typeof(FormBlogs));
        }

        private void postsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(this, typeof(FormPosts));
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(this, typeof(FormTags));
        }

    }
}
