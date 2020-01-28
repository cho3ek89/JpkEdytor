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
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/";
        }

        protected override void UpdateBeforeSerialization()
        {
            UpdatePodmiot();
            UpdateWyciagWiersze();
            UpdateCrtls();
        }

        private void UpdatePodmiot()
        {
            if (Jpk.Podmiot == null) return;

            if (Jpk.Podmiot.IdentyfikatorPodmiotu != null)
                Jpk.Podmiot.IdentyfikatorPodmiotu.RegonSpecified = !IsDefaultValue(Jpk.Podmiot.IdentyfikatorPodmiotu.Regon);

            if (Jpk.Podmiot.AdresPodmiotu != null)
            {
                Jpk.Podmiot.AdresPodmiotu.UlicaSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.Ulica);
                Jpk.Podmiot.AdresPodmiotu.NrLokaluSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.NrLokalu);
            }
        }

        private void UpdateWyciagWiersze()
        {
            var count = 1;
            foreach (var wyciagWiersz in Jpk?.WyciagWiersze)
                wyciagWiersz.NumerWiersza = count++.ToString();
        }

        private void UpdateCrtls()
        {
            if (Jpk.WyciagWiersze == null || Jpk.WyciagWiersze.Count == 0)
                Jpk.WyciagCtrl = null;
            else
            {
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
