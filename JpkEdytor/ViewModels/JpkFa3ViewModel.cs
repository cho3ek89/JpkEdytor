namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using Helpers.CsvImporter;
    using Framework;
    using Models.Common;
    using Models.Fa3;

    public sealed class JpkFa3ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkFa3ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new JpkNaglowek(),
                Podmiot = new Podmiot()
                {
                    Item = new AdresPolski1V50(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznej1V50(),
                },
                Faktura = new ObservableCollection<JpkFaktura>(),
                FakturaWiersz = new ObservableCollection<FakturaWiersz>(),
                Zamowienie = new ObservableCollection<Zamowienie>()
            };

            schemaFileName = @"Schemat_JPK_FA(3)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/";
        }

        protected override void UpdateBeforeSerialization()
        {
            UpdatePodmiot();
            UpdateFaktura();
            UpdateFakturaWiersz();
            UpdateZamowienie();
            UpdateCrtls();
        }

        private void UpdatePodmiot()
        {
            if (Jpk.Podmiot.Item is AdresZagranicznyV50 adresZagraniczny)
            {
                adresZagraniczny.KodPocztowySpecified = !IsDefaultValue(adresZagraniczny.KodPocztowy);
                adresZagraniczny.UlicaSpecified = !IsDefaultValue(adresZagraniczny.Ulica);
                adresZagraniczny.NrDomuSpecified = !IsDefaultValue(adresZagraniczny.NrDomu);
                adresZagraniczny.NrLokaluSpecified = !IsDefaultValue(adresZagraniczny.NrLokalu);
            }

            if (Jpk.Podmiot.Item is AdresPolski1V50 adresPolski)
            {
                adresPolski.UlicaSpecified = !IsDefaultValue(adresPolski.Ulica);
                adresPolski.NrLokaluSpecified = !IsDefaultValue(adresPolski.NrLokalu);
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
                var areP22Specified = faktura.P22;
                var areFaKorSpecified = faktura.RodzajFaktury == RodzajFaktury.Korekta;

                faktura.P3ASpecified = !IsDefaultValue(faktura.P3A);
                faktura.P3BSpecified = !IsDefaultValue(faktura.P3B);
                faktura.P4ASpecified = !IsDefaultValue(faktura.P4A);
                faktura.P4BSpecified = !IsDefaultValue(faktura.P4B);
                faktura.P5ASpecified = !IsDefaultValue(faktura.P5A);
                faktura.P5BSpecified = !IsDefaultValue(faktura.P5B);
                faktura.P6Specified = !IsDefaultValue(faktura.P6);

                faktura.P13_1Specified = areP13P14Specified;
                faktura.P14_1Specified = areP13P14Specified;
                faktura.P14_1WSpecified = areP13P14Specified && faktura.KodWaluty != KodWalutyV30.PLN;

                faktura.P13_2Specified = areP13P14Specified;
                faktura.P14_2Specified = areP13P14Specified;
                faktura.P14_2WSpecified = areP13P14Specified && faktura.KodWaluty != KodWalutyV30.PLN;

                faktura.P13_3Specified = areP13P14Specified;
                faktura.P14_3Specified = areP13P14Specified;
                faktura.P14_3WSpecified = areP13P14Specified && faktura.KodWaluty != KodWalutyV30.PLN;

                faktura.P13_4Specified = areP13P14Specified;
                faktura.P14_4Specified = areP13P14Specified;
                faktura.P14_4WSpecified = areP13P14Specified && faktura.KodWaluty != KodWalutyV30.PLN;

                faktura.P13_5Specified = !IsDefaultValue(faktura.P13_5);
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

                faktura.NrFaZaliczkowejSpecified = faktura.RodzajFaktury == RodzajFaktury.Zal && !IsDefaultValue(faktura.NrFaZaliczkowej);
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

        private void UpdateZamowienie()
        {
            foreach (var zamowienie in Jpk?.Zamowienie)
            {
                if (zamowienie.ZamowienieWiersz == null) continue;

                foreach (var zamowienieWiersz in zamowienie.ZamowienieWiersz)
                {
                    zamowienieWiersz.P7ZSpecified = !IsDefaultValue(zamowienieWiersz.P7Z);
                    zamowienieWiersz.P8AZSpecified = !IsDefaultValue(zamowienieWiersz.P8AZ);
                    zamowienieWiersz.P8BZSpecified = !IsDefaultValue(zamowienieWiersz.P8BZ);
                    zamowienieWiersz.P9AZSpecified = !IsDefaultValue(zamowienieWiersz.P9AZ);
                    zamowienieWiersz.P11NettoZSpecified = !IsDefaultValue(zamowienieWiersz.P11NettoZ);
                    zamowienieWiersz.P11VatZSpecified = !IsDefaultValue(zamowienieWiersz.P11VatZ);
                    zamowienieWiersz.P12ZSpecified = !IsDefaultValue(zamowienieWiersz.P12Z);
                }
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
                    WartoscWierszyFaktur = Jpk.FakturaWiersz.Sum(s => s.P11)
                };
            }

            if (Jpk.Zamowienie == null || Jpk.Zamowienie.Count == 0)
                Jpk.ZamowienieCtrl = null;
            else
            {
                Jpk.ZamowienieCtrl = new ZamowienieCtrl
                {
                    LiczbaZamowien = Jpk.Zamowienie.Count.ToString(),
                    WartoscZamowien = Jpk.Zamowienie.Sum(s => s.WartoscZamowienia)
                };
            }
        }

        private Zamowienie selectedZamowienie;

        public Zamowienie SelectedZamowienie
        {
            get
            {
                return selectedZamowienie;
            }
            set
            {
                selectedZamowienie = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ChangeAdresType => new RelayCommand<string>(obj =>
        {
            if (obj == "0" && Jpk.Podmiot.Item is AdresZagranicznyV50)
                Jpk.Podmiot.Item = new AdresPolski1V50();
            
            if (obj == "1" && Jpk.Podmiot.Item is AdresPolski1V50)
                Jpk.Podmiot.Item = new AdresZagranicznyV50();
        });

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

        public async Task ImportZamowienieFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<Zamowienie>(fullFilePath);
                Jpk.Zamowienie = new ObservableCollection<Zamowienie>(collection);
            });
        }

        public async Task ImportZamowienieWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                if (selectedZamowienie == null) return;

                var collection = CsvImporter.GetCollectionFromCsv<ZamowienieWiersz>(fullFilePath);
                SelectedZamowienie.ZamowienieWiersz = new ObservableCollection<ZamowienieWiersz>(collection);
            });
        }
    }
}
