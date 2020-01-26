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

        protected override void UpdateBeforeSerialization()
        {
            UpdatePodmiot();
            UpdateFaktura();
            UpdateFakturaWiersz();
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

        private void UpdateFaktura()
        {
            foreach (var faktura in Jpk?.Faktura)
            {
                var areP13P14Specified = faktura.P18 && (faktura.P106E2 || faktura.P106E3);
                var areP19Specified = faktura.P19;
                var areP20Specified = faktura.P20;
                var areP21Specified = faktura.P21;
                var areP22Specified = !IsDefaultValue(faktura.P22A);
                var areFaKorSpecified = faktura.RodzajFaktury == RodzajFaktury.Korekta;
                var areFaZalSpecified = faktura.RodzajFaktury == RodzajFaktury.Zal;

                faktura.P3ASpecified = !IsDefaultValue(faktura.P3A);
                faktura.P3BSpecified = !IsDefaultValue(faktura.P3B);
                faktura.P4ASpecified = !IsDefaultValue(faktura.P4A);
                faktura.P4BSpecified = !IsDefaultValue(faktura.P4B);
                faktura.P5ASpecified = !IsDefaultValue(faktura.P5A);
                faktura.P5BSpecified = !IsDefaultValue(faktura.P5B);
                faktura.P6Specified = !IsDefaultValue(faktura.P6);

                faktura.P13_1Specified = areP13P14Specified;
                faktura.P14_1Specified = areP13P14Specified;

                faktura.P13_2Specified = areP13P14Specified;
                faktura.P14_2Specified = areP13P14Specified;

                faktura.P13_3Specified = areP13P14Specified;
                faktura.P14_3Specified = areP13P14Specified;

                faktura.P13_4Specified = areP13P14Specified;
                faktura.P14_4Specified = areP13P14Specified;

                faktura.P13_5Specified = areP13P14Specified;
                faktura.P14_5Specified = areP13P14Specified;

                faktura.P13_6Specified = !IsDefaultValue(faktura.P13_6);
                faktura.P13_7Specified = !IsDefaultValue(faktura.P13_7);

                faktura.P19ASpecified = areP19Specified && !IsDefaultValue(faktura.P19A);
                faktura.P19BSpecified = areP19Specified && !IsDefaultValue(faktura.P19B);
                faktura.P19CSpecified = areP19Specified && !IsDefaultValue(faktura.P19C);

                faktura.P20ASpecified = areP20Specified;
                faktura.P20BSpecified = areP20Specified;

                faktura.P21ASpecified = areP21Specified;
                faktura.P21BSpecified = areP21Specified;
                faktura.P21CSpecified = areP21Specified;

                faktura.P22ASpecified = areP22Specified;
                faktura.P22BSpecified = areP22Specified && !IsDefaultValue(faktura.P22B);
                faktura.P22CSpecified = areP22Specified && !IsDefaultValue(faktura.P22C);

                faktura.P106E3ASpecified = faktura.P106E3 && !IsDefaultValue(faktura.P106E3A);

                faktura.PrzyczynaKorektySpecified = areFaKorSpecified;
                faktura.NrFaKorygowanejSpecified = areFaKorSpecified;
                faktura.OkresFaKorygowanejSpecified = areFaKorSpecified && !IsDefaultValue(faktura.OkresFaKorygowanej);

                faktura.ZalZaplataSpecified = areFaZalSpecified;
                faktura.ZalPodatekSpecified = areFaZalSpecified;
            }
        }

        private void UpdateFakturaWiersz()
        {
            foreach (var fakturaWiersz in Jpk?.FakturaWiersz)
            {
                fakturaWiersz.P7Specified = !IsDefaultValue(fakturaWiersz.P7);
                fakturaWiersz.P8ASpecified = !IsDefaultValue(fakturaWiersz.P8A);
                fakturaWiersz.P8BSpecified = !IsDefaultValue(fakturaWiersz.P8B);
                fakturaWiersz.P9ASpecified = !IsDefaultValue(fakturaWiersz.P9A);
                fakturaWiersz.P9BSpecified = !IsDefaultValue(fakturaWiersz.P9B);
                fakturaWiersz.P10Specified = !IsDefaultValue(fakturaWiersz.P10);
                fakturaWiersz.P11Specified = !IsDefaultValue(fakturaWiersz.P11);
                fakturaWiersz.P11ASpecified = !IsDefaultValue(fakturaWiersz.P11A);
                fakturaWiersz.P12Specified = !IsDefaultValue(fakturaWiersz.P12);
            }
        }

        private void UpdateCrtls()
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
