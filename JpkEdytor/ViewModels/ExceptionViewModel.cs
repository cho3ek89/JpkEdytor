namespace JpkEdytor.ViewModels
{
    using System;

    using Framework;

    public class ExceptionViewModel : NotifyPropertyChanged
    {
        private Exception exception;

        public Exception Exception
        {
            get
            {
                return exception;
            }
            private set
            {
                exception = value;
                RaisePropertyChanged();
            }
        }

        public ExceptionViewModel(Exception exception)
        {
            Exception = exception;
        }
    }
}
