namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Common;
    using Models.Pkpir2;

    public sealed class JpkPkpir2ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkPkpir2ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new Adres(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
                },
                PkpirInfo = new PkpirInfo(),
                PkpirSpis = new ObservableCollection<PkpirSpis>(),
                PkpirWiersze = new ObservableCollection<PkpirWiersz>(),
            };

            schemaFileName = @"Schemat_JPK_PKPIR(2)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/";

            jpkModelUpdater = new JpkPkpir2ModelUpdater();
        }

        public async Task ImportSpisFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<PkpirSpis>(fullFilePath);
                Jpk.PkpirSpis = new ObservableCollection<PkpirSpis>(collection);
            });
        }

        public async Task ImportWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<PkpirWiersz>(fullFilePath);
                Jpk.PkpirWiersze = new ObservableCollection<PkpirWiersz>(collection);
            });
        }
    }
}
