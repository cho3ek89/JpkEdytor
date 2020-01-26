﻿namespace JpkEdytor.ViewModels
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

        protected override void UpdateBeforeSerialization()
        {
            UpdatePodmiot();
            UpdateSprzedazWiersz();
            UpdateZakupWiersz();
            UpdateCrtls();
        }

        private void UpdatePodmiot()
        {
            if (Jpk.Podmiot != null)
                Jpk.Podmiot.EmailSpecified = !IsDefaultValue(Jpk.Podmiot.Email);
        }

        private void UpdateSprzedazWiersz()
        {
            var count = 1;
            foreach (var sprzedazWiersz in Jpk?.SprzedazWiersz)
            {
                sprzedazWiersz.LpSprzedazy = count++.ToString();

                var areK15K16Specified = !IsDefaultValue(sprzedazWiersz.K15) || !IsDefaultValue(sprzedazWiersz.K16);
                var areK17K18Specified = !IsDefaultValue(sprzedazWiersz.K17) || !IsDefaultValue(sprzedazWiersz.K18);
                var areK19K20Specified = !IsDefaultValue(sprzedazWiersz.K19) || !IsDefaultValue(sprzedazWiersz.K20);
                var areK23K24Specified = !IsDefaultValue(sprzedazWiersz.K23) || !IsDefaultValue(sprzedazWiersz.K24);
                var areK25K26Specified = !IsDefaultValue(sprzedazWiersz.K25) || !IsDefaultValue(sprzedazWiersz.K26);
                var areK27K28Specified = !IsDefaultValue(sprzedazWiersz.K27) || !IsDefaultValue(sprzedazWiersz.K28);
                var areK29K30Specified = !IsDefaultValue(sprzedazWiersz.K29) || !IsDefaultValue(sprzedazWiersz.K30);
                var areK32K33Specified = !IsDefaultValue(sprzedazWiersz.K32) || !IsDefaultValue(sprzedazWiersz.K33);
                var areK34K35Specified = !IsDefaultValue(sprzedazWiersz.K34) || !IsDefaultValue(sprzedazWiersz.K35);

                sprzedazWiersz.DataSprzedazySpecified = !IsDefaultValue(sprzedazWiersz.DataSprzedazy);
                sprzedazWiersz.K10Specified = !IsDefaultValue(sprzedazWiersz.K10);
                sprzedazWiersz.K11Specified = !IsDefaultValue(sprzedazWiersz.K11);
                sprzedazWiersz.K12Specified = !IsDefaultValue(sprzedazWiersz.K12);
                sprzedazWiersz.K13Specified = !IsDefaultValue(sprzedazWiersz.K13);
                sprzedazWiersz.K14Specified = !IsDefaultValue(sprzedazWiersz.K14);
                sprzedazWiersz.K15Specified = areK15K16Specified;
                sprzedazWiersz.K16Specified = areK15K16Specified;
                sprzedazWiersz.K17Specified = areK17K18Specified;
                sprzedazWiersz.K18Specified = areK17K18Specified;
                sprzedazWiersz.K19Specified = areK19K20Specified;
                sprzedazWiersz.K20Specified = areK19K20Specified;
                sprzedazWiersz.K21Specified = !IsDefaultValue(sprzedazWiersz.K21);
                sprzedazWiersz.K22Specified = !IsDefaultValue(sprzedazWiersz.K22);
                sprzedazWiersz.K23Specified = areK23K24Specified;
                sprzedazWiersz.K24Specified = areK23K24Specified;
                sprzedazWiersz.K25Specified = areK25K26Specified;
                sprzedazWiersz.K26Specified = areK25K26Specified;
                sprzedazWiersz.K27Specified = areK27K28Specified;
                sprzedazWiersz.K28Specified = areK27K28Specified;
                sprzedazWiersz.K29Specified = areK29K30Specified;
                sprzedazWiersz.K30Specified = areK29K30Specified;
                sprzedazWiersz.K31Specified = !IsDefaultValue(sprzedazWiersz.K31);
                sprzedazWiersz.K32Specified = areK32K33Specified;
                sprzedazWiersz.K33Specified = areK32K33Specified;
                sprzedazWiersz.K34Specified = areK34K35Specified;
                sprzedazWiersz.K35Specified = areK34K35Specified;
                sprzedazWiersz.K36Specified = !IsDefaultValue(sprzedazWiersz.K36);
                sprzedazWiersz.K37Specified = !IsDefaultValue(sprzedazWiersz.K37);
                sprzedazWiersz.K38Specified = !IsDefaultValue(sprzedazWiersz.K38);
                sprzedazWiersz.K39Specified = !IsDefaultValue(sprzedazWiersz.K39);
            }
        }

        private void UpdateZakupWiersz()
        {
            var count = 1;
            foreach (var zakupWiersz in Jpk?.ZakupWiersz)
            {
                zakupWiersz.LpZakupu = count++.ToString();

                var areK43K44Specified = !IsDefaultValue(zakupWiersz.K43) || !IsDefaultValue(zakupWiersz.K44);
                var areK45K46Specified = !IsDefaultValue(zakupWiersz.K45) || !IsDefaultValue(zakupWiersz.K46);

                zakupWiersz.DataWplywuSpecified = !IsDefaultValue(zakupWiersz.DataWplywu);
                zakupWiersz.K43Specified = areK43K44Specified;
                zakupWiersz.K44Specified = areK43K44Specified;
                zakupWiersz.K45Specified = areK45K46Specified;
                zakupWiersz.K46Specified = areK45K46Specified;
                zakupWiersz.K47Specified = !IsDefaultValue(zakupWiersz.K47);
                zakupWiersz.K48Specified = !IsDefaultValue(zakupWiersz.K48);
                zakupWiersz.K49Specified = !IsDefaultValue(zakupWiersz.K49);
                zakupWiersz.K50Specified = !IsDefaultValue(zakupWiersz.K50);
            }
        }

        private void UpdateCrtls()
        {
            if (Jpk.SprzedazWiersz == null || Jpk.SprzedazWiersz.Count == 0)
                Jpk.SprzedazCtrl = null;
            else
            {
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
