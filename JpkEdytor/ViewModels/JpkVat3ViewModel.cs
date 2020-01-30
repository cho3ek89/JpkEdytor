namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Vat3;

    public sealed class JpkVat3ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkVat3ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot(),
                SprzedazWiersz = new ObservableCollection<SprzedazWiersz>(),
                ZakupWiersz = new ObservableCollection<ZakupWiersz>(),
            };

            schemaFileName = @"Schemat_JPK_VAT(3)_v1-1.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/";

            jpkModelUpdater = new JpkVat3ModelUpdater();
        }

        public async Task ImportSprzedazFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<SprzedazWiersz>(fullFilePath);
                Jpk.SprzedazWiersz = new ObservableCollection<SprzedazWiersz>(collection);
            });
        }

        public async Task ImportZakupyFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<ZakupWiersz>(fullFilePath);
                Jpk.ZakupWiersz = new ObservableCollection<ZakupWiersz>(collection);
            });
        }
    }
}
