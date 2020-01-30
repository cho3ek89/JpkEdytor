namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.Mag1;

    public sealed class JpkMag1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkMag1ViewModel()
        {
            Jpk = new Jpk();

            schemaFileName = @"Schemat_JPK_MAG(1)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/";

            jpkModelUpdater = new JpkMag1ModelUpdater();
        }

        public async Task ImportPzWartoscFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<PzWartosc>(fullFilePath);
                Jpk.Pz.PzWartosc = new ObservableCollection<PzWartosc>(collection);
            });
        }

        public async Task ImportPzWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<PzWiersz>(fullFilePath);
                Jpk.Pz.PzWiersz = new ObservableCollection<PzWiersz>(collection);
            });
        }

        public async Task ImportWzWartoscFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<WzWartosc>(fullFilePath);
                Jpk.Wz.WzWartosc = new ObservableCollection<WzWartosc>(collection);
            });
        }

        public async Task ImportWzWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<WzWiersz>(fullFilePath);
                Jpk.Wz.WzWiersz = new ObservableCollection<WzWiersz>(collection);
            });
        }

        public async Task ImportRwWartoscFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<RwWartosc>(fullFilePath);
                Jpk.Rw.RwWartosc = new ObservableCollection<RwWartosc>(collection);
            });
        }

        public async Task ImportRwWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<RwWiersz>(fullFilePath);
                Jpk.Rw.RwWiersz = new ObservableCollection<RwWiersz>(collection);
            });
        }

        public async Task ImportMmWartoscFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<MmWartosc>(fullFilePath);
                Jpk.Mm.MmWartosc = new ObservableCollection<MmWartosc>(collection);
            });
        }

        public async Task ImportMmWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<MmWiersz>(fullFilePath);
                Jpk.Mm.MmWiersz = new ObservableCollection<MmWiersz>(collection);
            });
        }
    }
}
