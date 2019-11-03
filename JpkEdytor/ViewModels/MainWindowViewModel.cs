namespace JpkEdytor.ViewModels
{
    using System;
    using System.Windows.Input;

    using Framework;
    using Helpers;
    using Models;

    public class MainWindowViewModel : NotifyPropertyChanged
    {
        private bool isBusy;

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                RaisePropertyChanged();
            }
        }

        private IJpkViewModel<IJpk> jpkViewModel;

        public IJpkViewModel<IJpk> JpkViewModel
        {
            get
            {
                return jpkViewModel;
            }
            set
            {
                jpkViewModel = value;
                RaisePropertyChanged();
            }
        }

        public ICommand NewJpk
        {
            get
            {
                return new RelayCommand<string>(obj =>
                {
                    var jpkVm = GetJpkViewModel(obj);
                    JpkViewModel = jpkVm;
                }, x => { return JpkViewModel == null || !IsBusy; });
            }
        }

        public ICommand OpenJpk => new RelayCommand<string>(async obj =>
            {
                var jpkVm = GetJpkViewModel(obj);
                var openFileDialog = DialogHelper.GetOpenFileDialog(DialogHelper.FileType.Jpk);

                if (openFileDialog.ShowDialog() == true)
                {
                    try
                    {
                        IsBusy = true;

                        await jpkVm.LoadFromFile(openFileDialog.FileName);
                        JpkViewModel = jpkVm;

                        IsBusy = false;
                    }
                    catch (Exception ex)
                    {
                        IsBusy = false;
                        DialogHelper.ShowExceptionWindow(ex);
                    }
                }
            }, x => { return JpkViewModel == null || !IsBusy; });

        #region Importing CSV commands

        public ICommand ImportJpkVat3 => new RelayCommand<string>(async obj =>
        {
            var openFileDialog = DialogHelper.GetOpenFileDialog(DialogHelper.FileType.Csv);

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    switch (obj)
                    {
                        case "0":
                            await (JpkViewModel as JpkVat3ViewModel)?.ImportSprzedazFromCsv(openFileDialog.FileName);
                            break;
                        case "1":
                            await (JpkViewModel as JpkVat3ViewModel)?.ImportZakupyFromCsv(openFileDialog.FileName);
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    DialogHelper.ShowExceptionWindow(ex);
                }
            }
        }, x => { return JpkViewModel is IJpkViewModel<Models.Vat3.Jpk> && !IsBusy; });

        public ICommand ImportJpkEwp1 => new RelayCommand(async obj =>
        {
            var openFileDialog = DialogHelper.GetOpenFileDialog(DialogHelper.FileType.Csv);

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    await (JpkViewModel as JpkEwp1ViewModel)?.ImportEwpFromCsv(openFileDialog.FileName);

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    DialogHelper.ShowExceptionWindow(ex);
                }
            }
        }, x => { return JpkViewModel is IJpkViewModel<Models.Ewp1.Jpk> && !IsBusy; });

        public ICommand ImportJpkFa2 => new RelayCommand<string>(async obj =>
        {
            var openFileDialog = DialogHelper.GetOpenFileDialog(DialogHelper.FileType.Csv);

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    switch (obj)
                    {
                        case "0":
                            await (JpkViewModel as JpkFa2ViewModel)?.ImportFakturaFromCsv(openFileDialog.FileName);
                            break;
                        case "1":
                            await (JpkViewModel as JpkFa2ViewModel)?.ImportFakturaWierszFromCsv(openFileDialog.FileName);
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    DialogHelper.ShowExceptionWindow(ex);
                }
            }
        }, x => { return JpkViewModel is IJpkViewModel<Models.Fa2.Jpk> && !IsBusy; });

        public ICommand ImportJpkKr1 => new RelayCommand<string>(async obj =>
        {
            var openFileDialog = DialogHelper.GetOpenFileDialog(DialogHelper.FileType.Csv);

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    switch (obj)
                    {
                        case "0":
                            await (JpkViewModel as JpkKr1ViewModel)?.ImportZoisFromCsv(openFileDialog.FileName);
                            break;
                        case "1":
                            await (JpkViewModel as JpkKr1ViewModel)?.ImportDziennikFromCsv(openFileDialog.FileName);
                            break;
                        case "2":
                            await (JpkViewModel as JpkKr1ViewModel)?.ImportKontoZapisFromCsv(openFileDialog.FileName);
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    DialogHelper.ShowExceptionWindow(ex);
                }
            }
        }, x => { return JpkViewModel is IJpkViewModel<Models.Kr1.Jpk> && !IsBusy; });

        public ICommand ImportJpkMag1 => new RelayCommand<string>(async obj =>
        {
            var openFileDialog = DialogHelper.GetOpenFileDialog(DialogHelper.FileType.Csv);

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    switch (obj)
                    {
                        case "0":
                            await (JpkViewModel as JpkMag1ViewModel)?.ImportPzWartoscFromCsv(openFileDialog.FileName);
                            break;
                        case "1":
                            await (JpkViewModel as JpkMag1ViewModel)?.ImportPzWierszFromCsv(openFileDialog.FileName);
                            break;
                        case "2":
                            await (JpkViewModel as JpkMag1ViewModel)?.ImportWzWartoscFromCsv(openFileDialog.FileName);
                            break;
                        case "3":
                            await (JpkViewModel as JpkMag1ViewModel)?.ImportWzWierszFromCsv(openFileDialog.FileName);
                            break;
                        case "4":
                            await (JpkViewModel as JpkMag1ViewModel)?.ImportRwWartoscFromCsv(openFileDialog.FileName);
                            break;
                        case "5":
                            await (JpkViewModel as JpkMag1ViewModel)?.ImportRwWierszFromCsv(openFileDialog.FileName);
                            break;
                        case "6":
                            await (JpkViewModel as JpkMag1ViewModel)?.ImportMmWartoscFromCsv(openFileDialog.FileName);
                            break;
                        case "7":
                            await (JpkViewModel as JpkMag1ViewModel)?.ImportMmWierszFromCsv(openFileDialog.FileName);
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    DialogHelper.ShowExceptionWindow(ex);
                }
            }
        }, x => { return JpkViewModel is IJpkViewModel<Models.Mag1.Jpk> && !IsBusy; });

        public ICommand ImportJpkPkpir2 => new RelayCommand<string>(async obj =>
        {
            var openFileDialog = DialogHelper.GetOpenFileDialog(DialogHelper.FileType.Csv);

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    switch (obj)
                    {
                        case "0":
                            await (JpkViewModel as JpkPkpir2ViewModel)?.ImportSpisFromCsv(openFileDialog.FileName);
                            break;
                        case "1":
                            await (JpkViewModel as JpkPkpir2ViewModel)?.ImportWierszFromCsv(openFileDialog.FileName);
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    DialogHelper.ShowExceptionWindow(ex);
                }
            }
        }, x => { return JpkViewModel is IJpkViewModel<Models.Pkpir2.Jpk> && !IsBusy; });

        public ICommand ImportJpkWb1 => new RelayCommand(async obj =>
        {
            var openFileDialog = DialogHelper.GetOpenFileDialog(DialogHelper.FileType.Csv);

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    await (JpkViewModel as JpkWb1ViewModel)?.ImportWyciagFromCsv(openFileDialog.FileName);

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    DialogHelper.ShowExceptionWindow(ex);
                }
            }
        }, x => { return JpkViewModel is IJpkViewModel<Models.Wb1.Jpk> && !IsBusy; });

        #endregion

        public ICommand ValidateJpk => new RelayCommand(async obj =>
        {
            try
            {
                IsBusy = true;

                var validationErrors = await JpkViewModel.Validate();

                IsBusy = false;

                if (string.IsNullOrEmpty(validationErrors))
                    DialogHelper.ShowInformationWindow(
                        "Walidacja zakończona powodzeniem, brak błędów merytorycznych.", 
                        "Walidacja");
                else
                    DialogHelper.ShowValidationErrorsWindow(validationErrors);
            }
            catch (Exception ex)
            {
                IsBusy = false;
                DialogHelper.ShowExceptionWindow(ex);
            }
        }, x => { return JpkViewModel != null && !IsBusy; });

        public ICommand SaveJpk => new RelayCommand(async obj =>
        {
            var saveFileDialog = DialogHelper.GetSaveFileDialog(DialogHelper.FileType.Jpk);

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    await JpkViewModel.SaveToFile(saveFileDialog.FileName);

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    DialogHelper.ShowExceptionWindow(ex);
                }
            }
        }, x => { return JpkViewModel != null && !IsBusy; });

        public ICommand Exit => new RelayCommand(obj => Environment.Exit(0));

        public MainWindowViewModel()
        {
        }

        private IJpkViewModel<IJpk> GetJpkViewModel(object index)
        {
            switch (index)
            {
                case "0":
                    return new JpkVat3ViewModel();
                case "1":
                    return new JpkEwp1ViewModel();
                case "2":
                    return new JpkFa2ViewModel();
                case "3":
                    return new JpkKr1ViewModel();
                case "4":
                    return new JpkMag1ViewModel();
                case "5":
                    return new JpkPkpir2ViewModel();
                case "6":
                    return new JpkWb1ViewModel();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}