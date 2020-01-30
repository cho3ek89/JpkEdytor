namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Common;
    using Models.FaRr1;

    public sealed class JpkFaRr1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkFaRr1ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new JpkNaglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolski1V50(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznej1V50(),
                },
                FakturaRr = new ObservableCollection<FakturaRr>(),
                FakturaRrWiersz = new ObservableCollection<FakturaRrWiersz>(),
                Oswiadczenie = new ObservableCollection<Oswiadczenie>(),
            };

            schemaFileName = @"Schemat_JPK_FA_RR(1)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/";

            jpkModelUpdater = new JpkFaRr1ModelUpdater();
        }

        public async Task ImportFakturaRrFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<FakturaRr>(fullFilePath);
                Jpk.FakturaRr = new ObservableCollection<FakturaRr>(collection);
            });
        }

        public async Task ImportFakturaRrWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<FakturaRrWiersz>(fullFilePath);
                Jpk.FakturaRrWiersz = new ObservableCollection<FakturaRrWiersz>(collection);
            });
        }

        public async Task ImportOswiadczenieFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<Oswiadczenie>(fullFilePath);
                Jpk.Oswiadczenie = new ObservableCollection<Oswiadczenie>(collection);
            });
        }
    }
}
