#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

namespace DG.UI.GHF
{
    public class DGUIGHFLanguageBase : IDGUIGHFLanguage
    {
        public string formDeleteMessageBoxText = "Do you really want to delete this item?";
        public string formDeleteManyMessageBoxText = "Do you really want to delete the selected items?";
        public string formDeleteMessageBoxTitle = "Deleting";
        public string mainExitMessageBoxText = "Exit this application?";
        public string mainExitMessageBoxTitle = "Exit";
        public string aboutVersion = "Version: ";
        public string errorsShowDetailsButton = "> Show Details";
        public string errorsHideDetailsButton = "< Hide Details";
        public string errorsCancelButton = "Cancel";
        public string errorsContinueButton = "Continue";
        public string errorsOKButton = "OK";
        public string errorsTitle = "Errors";
        public string errorsInfoLabel = "Errors encountered while performing this operation.";
    }
}
