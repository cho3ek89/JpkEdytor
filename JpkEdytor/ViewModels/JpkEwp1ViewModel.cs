namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
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
        }

        protected override void UpdateBeforeSerialization()
        {
            UpdatePodmiot();
            UpdateEwpWiersze();
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

        private void UpdateEwpWiersze()
        {
            var count = 1;
            foreach (var ewpWiersz in Jpk?.EwpWiersze)
            {
                ewpWiersz.K1 = count++.ToString();

                ewpWiersz.K12Specified = !IsDefaultValue(ewpWiersz.K12);
            }
        }

        private void UpdateCrtls()
        {
            if (Jpk.EwpWiersze == null || Jpk.EwpWiersze.Count == 0)
                Jpk.EwpCtrl = null;
            else
            {
                Jpk.EwpCtrl = new EwpCtrl
                {
                    LiczbaWierszy = Jpk.EwpWiersze.Count.ToString(),
                    SumaPrzychodow = Jpk.EwpWiersze.Sum(s => s.K10)
                };
            }
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
