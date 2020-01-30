namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Common;
    using Models.Wb1;

    public sealed class JpkWb1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkWb1ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolskiV40(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
                },
                Salda = new Salda(),
                WyciagWiersze = new ObservableCollection<WyciagWiersz>(),
                WyciagCtrl = new WyciagCtrl()
            };

            schemaFileName = @"Schemat_JPK_WB(1)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/";

            jpkModelUpdater = new JpkWb1ModelUpdater();
        }

        public async Task ImportWyciagFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<WyciagWiersz>(fullFilePath);
                Jpk.WyciagWiersze = new ObservableCollection<WyciagWiersz>(collection);
            });
        }
    }
}
