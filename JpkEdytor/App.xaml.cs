namespace JpkEdytor
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Windows;

    using Helpers;

    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            SetupExceptionHandling();
            SetupCulture();
        }

        protected virtual void SetupExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler((s, ex) =>
                {
                    DialogHelper.ShowExceptionWindow(ex.ExceptionObject as Exception);
                    Environment.Exit(-1);
                });

            DispatcherUnhandledException += (s, ex) =>
            {
                DialogHelper.ShowExceptionWindow(ex.Exception as Exception);
                Environment.Exit(-1);
            };
        }

        protected virtual void SetupCulture()
        {
            var culture = new CultureInfo("pl-PL");
            culture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
    }
}
