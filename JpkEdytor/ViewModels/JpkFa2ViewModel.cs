namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
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
        }

        protected override void UpdateCrtls()
        {
            if (Jpk.Faktura == null || Jpk.Faktura.Count == 0)
                Jpk.FakturaCtrl = null;
            else
            {
                Jpk.FakturaCtrl = new FakturaCtrl
                {
                    LiczbaFaktur = Jpk.Faktura.Count.ToString(),
                    WartoscFaktur = Jpk.Faktura.Sum(s => s.P15)
                };
            }

            if (Jpk.FakturaWiersz == null || Jpk.FakturaWiersz.Count == 0)
                Jpk.FakturaWierszCtrl = null;
            else
            {
                Jpk.FakturaWierszCtrl = new FakturaWierszCtrl
                {
                    LiczbaWierszyFaktur = Jpk.FakturaWiersz.Count.ToString(),
                    WartoscWierszyFaktur = Jpk.FakturaWiersz.Sum(s => s.P11),
                };
            }
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
