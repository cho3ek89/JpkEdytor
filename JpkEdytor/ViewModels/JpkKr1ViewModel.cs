namespace JpkEdytor.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers;
    using Models.Common;
    using Models.Kr1;

    public sealed class JpkKr1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkKr1ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolskiV40(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
                },
                Dziennik = new ObservableCollection<Dziennik>(),
                KontoZapis = new ObservableCollection<KontoZapis>(),
                Zois = new ObservableCollection<Zois>(),
            };

            schemaFileName = @"Schemat_JPK_KR(1)_v1-0.xsd";
        }

        protected override void UpdateCrtls()
        {
            if (Jpk.Dziennik == null || Jpk.Dziennik.Count == 0)
                Jpk.DziennikCtrl = null;
            else
            {
                var count = 1;
                foreach (var dziennikWpis in Jpk.Dziennik)
                    dziennikWpis.LpZapisuDziennika = count++.ToString();

                Jpk.DziennikCtrl = new DziennikCtrl
                {
                    LiczbaWierszyDziennika = Jpk.Dziennik.Count.ToString(),
                    SumaKwotOperacji = Jpk.Dziennik.Sum(s => s.DziennikKwotaOperacji)
                };
            }

            if (Jpk.KontoZapis == null || Jpk.KontoZapis.Count == 0)
                Jpk.KontoZapisCtrl = null;
            else
            {
                var count = 1;
                foreach (var kontoZapis in Jpk.KontoZapis)
                    kontoZapis.LpZapisu = count++.ToString();

                Jpk.KontoZapisCtrl = new KontoZapisCtrl
                {
                    LiczbaWierszyKontoZapisu = Jpk.KontoZapis.Count.ToString(),
                    SumaWinien = Jpk.KontoZapis.Sum(s => s.KwotaWinien),
                    SumaMa = Jpk.KontoZapis.Sum(s => s.KwotaMa),
                };
            }
        }

        public async Task ImportZoisFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<Zois>(fullFilePath);
                Jpk.Zois = new ObservableCollection<Zois>(collection);
            });
        }

        public async Task ImportDziennikFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<Dziennik>(fullFilePath);
                Jpk.Dziennik = new ObservableCollection<Dziennik>(collection);
            });
        }

        public async Task ImportKontoZapisFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<KontoZapis>(fullFilePath);
                Jpk.KontoZapis = new ObservableCollection<KontoZapis>(collection);
            });
        }
    }
}
