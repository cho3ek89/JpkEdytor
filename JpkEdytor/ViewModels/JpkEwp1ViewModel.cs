namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Common;
    using Models.Ewp1;

    public sealed class JpkEwp1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkEwp1ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolskiV40(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
                },
                EwpWiersze = new ObservableCollection<EwpWiersz>(),
            };

            schemaFileName = @"Schemat_JPK_EWP_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/";
            
            jpkModelUpdater = new JpkEwp1ModelUpdater();
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
