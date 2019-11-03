namespace JpkEdytor.Helpers
{
    using System;
    using System.Windows.Input;
    using System.Windows.Controls;

    using Framework;

    /// <summary>
    /// A class providing useful date utilities.
    /// </summary>
    public static class DateUtils
    {
        /// <summary>
        /// Sets today's date to a given <see cref="Calendar"/> control.
        /// </summary>
        public static ICommand Today => new RelayCommand<object>(obj => SetDateIfPossible(obj, DateTime.Today));

        /// <summary>
        /// Sets a beginning of current moth's date to a given <see cref="Calendar"/> control.
        /// </summary>
        public static ICommand BeginningOfCurrentMonth => new RelayCommand<object>(obj =>
        {
            var today = DateTime.Today;
            var date = new DateTime(today.Year, today.Month, 1);
            SetDateIfPossible(obj, date);
        });

        /// <summary>
        /// Sets an end of current moth's date to a given <see cref="Calendar"/> control.
        /// </summary>
        public static ICommand EndOfCurrentMonth => new RelayCommand<object>(obj =>
        {
            var today = DateTime.Today;
            var date = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
            SetDateIfPossible(obj, date);
        });

        /// <summary>
        /// Sets Jesus Christ's birth date to a given <see cref="Calendar"/> control.
        /// </summary>
        public static ICommand Default => new RelayCommand<object>(obj => SetDateIfPossible(obj, default(DateTime)));

        /// <summary>
        /// Sets a given date to a given object.
        /// </summary>
        /// <param name="obj"><see cref="Calendar"/> control</param>
        /// <param name="date">Date to be set to <paramref name="obj"/> object.</param>
        private static void SetDateIfPossible(object obj, DateTime date)
        {
            if (!(obj is Calendar calendar))
                return;

            calendar.SelectedDate = date;
            calendar.DisplayDate = date;
        }
    }
}
