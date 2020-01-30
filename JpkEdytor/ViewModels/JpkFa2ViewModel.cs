namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Common;
    using Models.Fa2;

    public sealed class JpkFa2ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkFa2ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new JpkNaglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolskiV50(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV50(),
                },
                Faktura = new ObservableCollection<JpkFaktura>(),
                StawkiPodatku = new StawkiPodatku(),
                FakturaWiersz = new ObservableCollection<FakturaWiersz>()
            };

            schemaFileName = @"Schemat_JPK_FA(2)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/";
            
            jpkModelUpdater = new JpkFa2ModelUpdater();
        }

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
    }
}
