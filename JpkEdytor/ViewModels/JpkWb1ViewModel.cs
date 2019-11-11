namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
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
        }

        protected override void UpdateCrtls()
        {
            if (Jpk.WyciagWiersze == null || Jpk.WyciagWiersze.Count == 0)
                Jpk.WyciagCtrl = null;
            else
            {
                var count = 1;
                foreach (var wyciagWiersz in Jpk.WyciagWiersze)
                    wyciagWiersz.NumerWiersza = count++.ToString();

                Jpk.WyciagCtrl = new WyciagCtrl
                {
                    LiczbaWierszy = Jpk.WyciagWiersze.Count.ToString(),
                    SumaObciazen = Jpk.WyciagWiersze.Sum(s => s.KwotaOperacji),
                    SumaUznan = Jpk.WyciagWiersze.Sum(s => s.SaldoOperacji)
                };
            }
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
