namespace JpkEdytor.ViewModels
{
    using Framework;

    public class MessageViewModel : NotifyPropertyChanged
    {
        private string message;

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                RaisePropertyChanged();
            }
        }

        private string title;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                RaisePropertyChanged();
            }
        }

        public MessageViewModel(string message)
        {
            Message = message;
        }

        public MessageViewModel(string message, string title)
        {
            Message = message;
            Title = title;
        }
    }
}
