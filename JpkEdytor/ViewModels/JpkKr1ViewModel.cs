namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Common;
    using Models.Kr1;

    public sealed class JpkKr1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkKr1ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolskiV40(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
                },
                Dziennik = new ObservableCollection<Dziennik>(),
                KontoZapis = new ObservableCollection<KontoZapis>(),
                Zois = new ObservableCollection<Zois>(),
            };

            schemaFileName = @"Schemat_JPK_KR(1)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/";

            jpkModelUpdater = new JpkKr1ModelUpdater();
        }

        public async Task ImportZoisFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<Zois>(fullFilePath);
                Jpk.Zois = new ObservableCollection<Zois>(collection);
            });
        }

        public async Task ImportDziennikFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<Dziennik>(fullFilePath);
                Jpk.Dziennik = new ObservableCollection<Dziennik>(collection);
            });
        }

        public async Task ImportKontoZapisFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<KontoZapis>(fullFilePath);
                Jpk.KontoZapis = new ObservableCollection<KontoZapis>(collection);
            });
        }
    }
}
