namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Models.Common;
    using Models.Pkpir2;

    public sealed class JpkPkpir2ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkPkpir2ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new Adres(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
                },
                PkpirInfo = new PkpirInfo(),
                PkpirSpis = new ObservableCollection<PkpirSpis>(),
                PkpirWiersze = new ObservableCollection<PkpirWiersz>(),
            };

            schemaFileName = @"Schemat_JPK_PKPIR(2)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/";
        }

        protected override void UpdateBeforeSerialization()
        {
            UpdatePodmiot();
            UpdatePkpirWiersze();
            UpdateCrtls();
        }

        private void UpdatePodmiot()
        {
            if (Jpk.Podmiot == null) return;

            if (Jpk.Podmiot.IdentyfikatorPodmiotu != null)
                Jpk.Podmiot.IdentyfikatorPodmiotu.RegonSpecified = !IsDefaultValue(Jpk.Podmiot.IdentyfikatorPodmiotu.Regon);

            if (Jpk.Podmiot.AdresPodmiotu != null)
            {
                Jpk.Podmiot.AdresPodmiotu.WojewodztwoSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.Wojewodztwo);
                Jpk.Podmiot.AdresPodmiotu.PowiatSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.Powiat);
                Jpk.Podmiot.AdresPodmiotu.GminaSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.Gmina);
                Jpk.Podmiot.AdresPodmiotu.UlicaSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.Ulica);
                Jpk.Podmiot.AdresPodmiotu.NrDomuSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.NrDomu);
                Jpk.Podmiot.AdresPodmiotu.NrLokaluSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.NrLokalu);
                Jpk.Podmiot.AdresPodmiotu.KodPocztowySpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.KodPocztowy);
                Jpk.Podmiot.AdresPodmiotu.PocztaSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.Poczta);
            }
        }

        private void UpdatePkpirWiersze()
        {
            var count = 1;
            foreach (var pkpirWiersz in Jpk?.PkpirWiersze)
            {
                pkpirWiersz.K1 = count++.ToString();

                var areK16AK16BSpecified = !IsDefaultValue(pkpirWiersz.K16A);

                pkpirWiersz.K16ASpecified = areK16AK16BSpecified;
                pkpirWiersz.K16BSpecified = areK16AK16BSpecified;
                pkpirWiersz.K17Specified = !IsDefaultValue(pkpirWiersz.K17);
            }
        }

        private void UpdateCrtls()
        {
            if (Jpk.PkpirWiersze == null || Jpk.PkpirWiersze.Count == 0)
                Jpk.PkpirCtrl = null;
            else
            {
                Jpk.PkpirCtrl = new PkpirCtrl
                {
                    LiczbaWierszy = Jpk.PkpirWiersze.Count.ToString(),
                    SumaPrzychodow = Jpk.PkpirWiersze.Sum(s => s.K9),
                };
            }
        }

        public async Task ImportSpisFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<PkpirSpis>(fullFilePath);
                Jpk.PkpirSpis = new ObservableCollection<PkpirSpis>(collection);
            });
        }

        public async Task ImportWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<PkpirWiersz>(fullFilePath);
                Jpk.PkpirWiersze = new ObservableCollection<PkpirWiersz>(collection);
            });
        }
    }
}
