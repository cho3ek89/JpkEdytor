namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
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
        }

        protected override void UpdateCrtls()
        {
            if (Jpk.SprzedazWiersz == null || Jpk.SprzedazWiersz.Count == 0)
                Jpk.SprzedazCtrl = null;
            else
            {
                var count = 1;
                foreach (var sprzedazWiersz in Jpk.SprzedazWiersz)
                    sprzedazWiersz.LpSprzedazy = count++.ToString();

                Jpk.SprzedazCtrl = new SprzedazCtrl
                {
                    LiczbaWierszySprzedazy = Jpk.SprzedazWiersz.Count.ToString(),
                    PodatekNalezny = Jpk.SprzedazWiersz.Sum(s => 
                        s.K16 + s.K18 + s.K20 + s.K24 + s.K26 + s.K28 + s.K30 + s.K33 + s.K35 + s.K36 + s.K37 - s.K38 - s.K39)
                };
            }

            if (Jpk.ZakupWiersz == null || Jpk.ZakupWiersz.Count == 0)
                Jpk.ZakupCtrl = null;
            else
            {
                var count = 1;
                foreach (var zakupWiersz in Jpk.ZakupWiersz)
                    zakupWiersz.LpZakupu = count++.ToString();

                Jpk.ZakupCtrl = new ZakupCtrl
                {
                    LiczbaWierszyZakupow = Jpk.ZakupWiersz.Count.ToString(),
                    PodatekNaliczony = Jpk.ZakupWiersz.Sum(s => 
                        s.K44 + s.K46 + s.K47 + s.K48 + s.K49 + s.K50)
                };
            }
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
