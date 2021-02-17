namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Common;
    using Models.Ewp2;

    public sealed class JpkEwp2ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkEwp2ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolski1V60(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznej1V60(),
                },
                EwpWiersze = new ObservableCollection<EwpWiersz>(),
            };

            schemaFileName = @"Schemat_JPK_EWP(2)_v1-1.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2020/03/11/eD/DefinicjeTypy/";

            jpkModelUpdater = new JpkEwp2ModelUpdater();
        }

        public async Task ImportEwpFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<EwpWiersz>(fullFilePath);
                Jpk.EwpWiersze = new ObservableCollection<EwpWiersz>(collection);
            });
        }
    }
}
