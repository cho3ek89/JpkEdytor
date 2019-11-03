namespace JpkEdytor.ViewModels
{
    using System.Windows;
    using System.Windows.Documents;
    using System.Windows.Media;

    using Framework;
    public class ValidationErrorsViewModel : NotifyPropertyChanged
    {
        private FlowDocument errorsDoc;

        public FlowDocument ErrorsDoc
        {
            get
            {
                return errorsDoc;
            }
            set
            {
                errorsDoc = value;
                RaisePropertyChanged();
            }
        }

        public ValidationErrorsViewModel(string validationErrorsMessage)
        {
            FlowDocument doc = new FlowDocument
            {
                Background = Brushes.WhiteSmoke,
            };

            var p = new Paragraph(new Run(validationErrorsMessage))
            {
                FontSize = 12,
                TextAlignment = TextAlignment.Left,
                FontFamily = new FontFamily("Arial"),
            };

            doc.Blocks.Add(p);

            ErrorsDoc = doc;
        }
    }
}
