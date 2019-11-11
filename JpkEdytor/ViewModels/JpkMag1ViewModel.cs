namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Models.Common;
    using Models.Mag1;

    public sealed class JpkMag1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkMag1ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolskiV40(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
                },
                Pz = new Pz
                {
                    PzWartosc = new ObservableCollection<PzWartosc>(),
                    PzWiersz = new ObservableCollection<PzWiersz>(),
                },
                Wz = new Wz
                {
                    WzWartosc = new ObservableCollection<WzWartosc>(),
                    WzWiersz = new ObservableCollection<WzWiersz>(),
                },
                Rw = new Rw
                {
                    RwWartosc = new ObservableCollection<RwWartosc>(),
                    RwWiersz = new ObservableCollection<RwWiersz>(),
                },
                Mm = new Mm
                {
                    MmWartosc = new ObservableCollection<MmWartosc>(),
                    MmWiersz = new ObservableCollection<MmWiersz>(),
                },
            };

            schemaFileName = @"Schemat_JPK_MAG(1)_v1-0.xsd";
        }

        protected override void UpdateCrtls()
        {
            if (Jpk.Pz.PzWartosc == null || Jpk.Pz.PzWartosc.Count == 0)
                Jpk.Pz.PzCtrl = null;
            else
            {
                Jpk.Pz.PzCtrl = new PzCtrl
                {
                    Liczba = Jpk.Pz.PzWartosc.Count.ToString(),
                    Suma = Jpk.Pz.PzWartosc.Sum(s => s.Wartosc),
                };
            }

            if (Jpk.Wz.WzWartosc == null || Jpk.Wz.WzWartosc.Count == 0)
                Jpk.Wz.WzCtrl = null;
            else
            {
                Jpk.Wz.WzCtrl = new WzCtrl
                {
                    Liczba = Jpk.Wz.WzWartosc.Count.ToString(),
                    Suma = Jpk.Wz.WzWartosc.Sum(s => s.Wartosc),
                };
            }

            if (Jpk.Rw.RwWartosc == null || Jpk.Rw.RwWartosc.Count == 0)
                Jpk.Rw.RwCtrl = null;
            else
            {
                Jpk.Rw.RwCtrl = new RwCtrl
                {
                    Liczba = Jpk.Rw.RwWartosc.Count.ToString(),
                    Suma = Jpk.Rw.RwWartosc.Sum(s => s.Wartosc),
                };
            }

            if (Jpk.Mm.MmWartosc == null || Jpk.Mm.MmWartosc.Count == 0)
                Jpk.Mm.MmCtrl = null;
            else
            {
                Jpk.Mm.MmCtrl = new MmCtrl
                {
                    Liczba = Jpk.Mm.MmWartosc.Count.ToString(),
                    Suma = Jpk.Mm.MmWartosc.Sum(s => s.Wartosc),
                };
            }
        }

        public async Task ImportPzWartoscFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<PzWartosc>(fullFilePath);
                Jpk.Pz.PzWartosc = new ObservableCollection<PzWartosc>(collection);
            });
        }

        public async Task ImportPzWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<PzWiersz>(fullFilePath);
                Jpk.Pz.PzWiersz = new ObservableCollection<PzWiersz>(collection);
            });
        }

        public async Task ImportWzWartoscFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<WzWartosc>(fullFilePath);
                Jpk.Wz.WzWartosc = new ObservableCollection<WzWartosc>(collection);
            });
        }

        public async Task ImportWzWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<WzWiersz>(fullFilePath);
                Jpk.Wz.WzWiersz = new ObservableCollection<WzWiersz>(collection);
            });
        }

        public async Task ImportRwWartoscFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<RwWartosc>(fullFilePath);
                Jpk.Rw.RwWartosc = new ObservableCollection<RwWartosc>(collection);
            });
        }

        public async Task ImportRwWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<RwWiersz>(fullFilePath);
                Jpk.Rw.RwWiersz = new ObservableCollection<RwWiersz>(collection);
            });
        }

        public async Task ImportMmWartoscFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<MmWartosc>(fullFilePath);
                Jpk.Mm.MmWartosc = new ObservableCollection<MmWartosc>(collection);
            });
        }

        public async Task ImportMmWierszFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<MmWiersz>(fullFilePath);
                Jpk.Mm.MmWiersz = new ObservableCollection<MmWiersz>(collection);
            });
        }
    }
}
