using DG.UI.GHF;
using System.Windows.Forms;

namespace DG.UIGHFSample
{
    public class MessageBoxSample
    {
        public class MessageBoxSampleLanguage : IDGUIGHFLanguage
        {
            public string text001 = "Test.";
        }

        public MessageBoxSampleLanguage language = new MessageBoxSampleLanguage();

        public DGUIGHFLanguageHelper LanguageHelper { get; private set; }

        public MessageBoxSample()
        {
            LanguageHelper = new DGUIGHFLanguageHelper(this);
            LanguageHelper.LoadFromFile(Program.uighfApplication.LanguageFilename);
        }

        public void Show()
        {
            MessageBox.Show(language.text001);
        }
    }
}
