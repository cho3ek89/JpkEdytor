namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Framework;
    using Models.Common;
    using Models.Fa3;

    public sealed class JpkFa3ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkFa3ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new JpkNaglowek(),
                Podmiot = new Podmiot()
                {
                    Item = new AdresPolski1V50(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznej1V50(),
                },
                Faktura = new ObservableCollection<JpkFaktura>(),
                FakturaWiersz = new ObservableCollection<FakturaWiersz>(),
                Zamowienie = new ObservableCollection<Zamowienie>()
            };

            schemaFileName = @"Schemat_JPK_FA(3)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/";

            jpkModelUpdater = new JpkFa3ModelUpdater();
        }

        private Zamowienie selectedZamowienie;

        public Zamowienie SelectedZamowienie
        {
            get
            {
                return selectedZamowienie;
            }
            set
            {
                selectedZamowienie = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ChangeAdresType => new RelayCommand<string>(obj =>
        {
            if (obj == "0" && Jpk.Podmiot.Item is AdresZagranicznyV50)
                Jpk.Podmiot.Item = new AdresPolski1V50();
            
            if (obj == "1" && Jpk.Podmiot.Item is AdresPolski1V50)
                Jpk.Podmiot.Item = new AdresZagranicznyV50();
        });

        public async Task ImportFakturaFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<JpkFaktura>(fullFilePath);
                Jpk.Faktura = new ObservableCollection<JpkFaktura>(collection);
            });
        }

        public async Task ImportFakturaWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<FakturaWiersz>(fullFilePath);
                Jpk.FakturaWiersz = new ObservableCollection<FakturaWiersz>(collection);
            });
        }

        public async Task ImportZamowienieFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<Zamowienie>(fullFilePath);
                Jpk.Zamowienie = new ObservableCollection<Zamowienie>(collection);
            });
        }

        public async Task ImportZamowienieWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                if (selectedZamowienie == null) return;

                var collection = CsvImporter.GetCollectionFromCsv<ZamowienieWiersz>(fullFilePath);
                SelectedZamowienie.ZamowienieWiersz = new ObservableCollection<ZamowienieWiersz>(collection);
            });
        }
    }
}
