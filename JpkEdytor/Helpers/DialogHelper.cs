namespace JpkEdytor.Helpers
{
    using Microsoft.Win32;
    using System;
    using System.Windows;

    using ViewModels;
    using Views;

    /// <summary>
    /// A class providing useful dialog window utilities.
    /// </summary>
    public static class DialogHelper
    {
        /// <summary>
        /// File type enum
        /// </summary>
        public enum FileType { Jpk, Csv };

        /// <summary>
        /// Returns <see cref="OpenFileDialog"/> object for a given file type. 
        /// </summary>
        /// <param name="fileType"><see cref="FileType"/> enum value</param>
        /// <returns>
        /// <see cref="OpenFileDialog"/> object with a file filter set up 
        /// accordingly to a give <paramref name="fileType"/>.
        /// </returns>
        public static OpenFileDialog GetOpenFileDialog(FileType fileType)
        {
            return new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = GetFilter(fileType),
                InitialDirectory =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            };
        }

        /// <summary>
        /// Returns <see cref="SaveFileDialog"/> object for a given file type. 
        /// </summary>
        /// <param name="fileType"><see cref="FileType"/> enum value</param>
        /// <returns>
        /// <see cref="SaveFileDialog"/> object with a file filter set up 
        /// accordingly to a give <paramref name="fileType"/>.
        /// </returns>
        public static SaveFileDialog GetSaveFileDialog(FileType fileType)
        {
            return new SaveFileDialog
            {
                CheckFileExists = false,
                CheckPathExists = true,
                Filter = GetFilter(fileType),
                InitialDirectory =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
        }

        /// <summary>
        /// Shows an exception window.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> object to show exception window for.</param>
        public static void ShowExceptionWindow(Exception exception)
        {
            ShowExceptionWindow(exception, Application.Current.MainWindow);
        }

        /// <summary>
        /// Shows an exception window.
        /// </summary>
        /// <param name="exception"><see cref="Exception"/> object to show an exception window for.</param>
        /// <param name="parent">Parent <see cref="Window"/> object</param>
        public static void ShowExceptionWindow(Exception exception, object parent)
        {
            var exceptionWindow = new ExceptionView
            {
                DataContext = new ExceptionViewModel(exception),
                Owner = parent as Window
            };

            exceptionWindow.ShowDialog();
        }

        /// <summary>
        /// Shows XML validation errors window.
        /// </summary>
        /// <param name="validationErrors"><see cref="string"/> containing XML validation errors message.</param>
        public static void ShowValidationErrorsWindow(string validationErrors)
        {
            ShowValidationErrorsWindow(validationErrors, Application.Current.MainWindow);
        }

        /// <summary>
        /// Shows XML validation errors window.
        /// </summary>
        /// <param name="validationErrors"><see cref="string"/> containing XML validation errors message.</param>
        /// <param name="parent">Parent <see cref="Window"/> object</param>
        public static void ShowValidationErrorsWindow(string validationErrors, object parent)
        {
            var exceptionWindow = new ValidationErrorsView
            {
                DataContext = new ValidationErrorsViewModel(validationErrors),
                Owner = parent as Window
            };

            exceptionWindow.ShowDialog();
        }

        /// <summary>
        /// Shows an information window.
        /// </summary>
        /// <param name="message"><see cref="string"/> containing an information message.</param>
        /// <param name="title"><see cref="string"/> containing an window title.</param>
        public static void ShowInformationWindow(string message, string title)
        {
            ShowInformationWindow(message, title, Application.Current.MainWindow);
        }

        /// <summary>
        /// Shows an information window.
        /// </summary>
        /// <param name="message"><see cref="string"/> containing an information message.</param>
        /// <param name="title"><see cref="string"/> containing an window title.</param>
        /// <param name="parent">Parent <see cref="Window"/> object</param>
        public static void ShowInformationWindow(string message, string title, object parent)
        {
            var messageWindow = new MessageView
            {
                DataContext = new MessageViewModel(message, title),
                Owner = parent as Window
            };

            messageWindow.ShowDialog();
        }

        /// <summary>
        /// Returns filter string to be applied to file dialog.
        /// </summary>
        /// <param name="fileType"><see cref="FileType"/> enum value</param>
        /// <returns>Filter <see cref="string"/></returns>
        private static string GetFilter(FileType fileType)
        {
            switch (fileType)
            {
                case FileType.Jpk:
                    return "Pliki JPK (*.xml)|*.xml";
                case FileType.Csv:
                    return "Pliki CSV (*.csv)|*.csv";
                default:
                    return "Pliki (*.*)|*.*";
            }
        }
    }
}