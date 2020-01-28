﻿namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Models.Common;
    using Models.FaRr1;

    public sealed class JpkFaRr1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkFaRr1ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new JpkNaglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolski1V50(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznej1V50(),
                },
                FakturaRr = new ObservableCollection<FakturaRr>(),
                FakturaRrWiersz = new ObservableCollection<FakturaRrWiersz>(),
                Oswiadczenie = new ObservableCollection<Oswiadczenie>(),
            };

            schemaFileName = @"Schemat_JPK_FA_RR(1)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/";
        }

        protected override void UpdateBeforeSerialization()
        {
            UpdatePodmiot();
            UpdateFakturaRr();
            UpdateCrtls();
        }

        private void UpdatePodmiot()
        {
            if (Jpk.Podmiot != null && Jpk.Podmiot.AdresPodmiotu != null)
            {
                Jpk.Podmiot.AdresPodmiotu.UlicaSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.Ulica);
                Jpk.Podmiot.AdresPodmiotu.NrLokaluSpecified = !IsDefaultValue(Jpk.Podmiot.AdresPodmiotu.NrLokalu);
            }
        }

        private void UpdateFakturaRr()
        {
            foreach (var fakturaRr in Jpk?.FakturaRr)
            {
                var areFaKorSpecified = fakturaRr.RodzajFaktury == RodzajFaktury.Korekta;

                fakturaRr.PrzyczynaKorektySpecified = areFaKorSpecified;
                fakturaRr.NrFaKorygowanejSpecified = areFaKorSpecified;
                fakturaRr.OkresFaKorygowanejSpecified = areFaKorSpecified && !IsDefaultValue(fakturaRr.OkresFaKorygowanej);

                fakturaRr.DokumentSpecified = !IsDefaultValue(fakturaRr.Dokument);
            }
        }

        private void UpdateCrtls()
        {
            if (Jpk.FakturaRr == null || Jpk.FakturaRr.Count == 0)
                Jpk.FakturaRrCtrl = null;
            else
            {
                Jpk.FakturaRrCtrl = new FakturaRrCtrl
                {
                    LiczbaFakturRr = Jpk.FakturaRr.Count.ToString(),
                    WartoscFakturRr = Jpk.FakturaRr.Sum(s => s.P12_1)
                };
            }

            if (Jpk.FakturaRrWiersz == null || Jpk.FakturaRrWiersz.Count == 0)
                Jpk.FakturaRrWierszCtrl = null;
            else
            {
                Jpk.FakturaRrWierszCtrl = new FakturaRrWierszCtrl
                {
                    LiczbaWierszyFakturRr = Jpk.FakturaRrWiersz.Count.ToString(),
                    WartoscWierszyFakturRr = Jpk.FakturaRrWiersz.Sum(s => s.P8)
                };
            }

            if (Jpk.Oswiadczenie == null || Jpk.Oswiadczenie.Count == 0)
                Jpk.OswiadczenieCtrl = null;
            else
            {
                Jpk.OswiadczenieCtrl = new OswiadczenieCtrl
                {
                    LiczbaOswiadczen = Jpk.Oswiadczenie.Count.ToString()
                };
            }
        }

        public async Task ImportFakturaRrFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<FakturaRr>(fullFilePath);
                Jpk.FakturaRr = new ObservableCollection<FakturaRr>(collection);
            });
        }

        public async Task ImportFakturaRrWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<FakturaRrWiersz>(fullFilePath);
                Jpk.FakturaRrWiersz = new ObservableCollection<FakturaRrWiersz>(collection);
            });
        }

        public async Task ImportOswiadczenieFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<Oswiadczenie>(fullFilePath);
                Jpk.Oswiadczenie = new ObservableCollection<Oswiadczenie>(collection);
            });
        }
    }
}
