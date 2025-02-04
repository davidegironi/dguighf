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
        public string formConcurrencyMessageBoxTitle = "Concurrency Check";
        public string formConcurrencyUserNonBlockingQuestionText = "User '{0}' is editing this item. Do you want to unlock this record?";
        public string formConcurrencyNonBlockingQuestionText = "Another user is editing this item. Do you want to unlock this record";
        public string formConcurrencyUserBlockingQuestionText = "User '{0}' is editing this item. You must wait for the user to finish the operation, or contact administrator if the problem persists.";
        public string formConcurrencyBlockingQuestionText = "Another user is editing this item. You must wait for the user to finish the operation, or contact administrator if the problem persists.";
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
        public string dataConsistencyViewerShowDetailsButton = "> Show Details";
        public string dataConsistencyViewerHideDetailsButton = "< Hide Details";
        public string dataConsistencyViewerIgnoreButton = "Ignore and Save";
        public string dataConsistencyViewerReloadButton = "Reload";
        public string dataConsistencyViewerEditButton = "Edit";
        public string dataConsistencyViewerTitle = "Data Consistency Comparer";
        public string dataConsistencyViewerInfoLabel = "Warning: the underlying values for the current record were changed.";
        public string dataConsistencyViewerTextLabel = "If you click Ignore and Save, the record you are editing will be updated to the current values.\r\nIf you click Reload, the record will be reloaded and your changes will be lost.\r\nClick Edit to close this form and go back to the edit mask.";
        public string dataConsistencyFieldNameColumn = "Field Name";
        public string dataConsistencyOriginalValueColumn = "Original Value";
        public string dataConsistencyCurrentValueColumn = "Current Value";
    }
}
