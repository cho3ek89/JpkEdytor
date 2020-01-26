namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Models.Mag1;

    public sealed class JpkMag1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkMag1ViewModel()
        {
            Jpk = new Jpk();

            schemaFileName = @"Schemat_JPK_MAG(1)_v1-0.xsd";
        }

        protected override void UpdateBeforeSerialization()
        {
            UpdatePodmiot();

            UpdatePz();
            UpdateWz();
            UpdateRw();
            UpdateMm();
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

        private void UpdatePz()
        {
            if (Jpk.Pz == null)
            {
                Jpk.PzSpecified = false;
                return;
            }

            var anyPzWartosc = Jpk.Pz.PzWartosc != null && Jpk.Pz.PzWartosc.Count != 0;
            var anyPzWiersz = Jpk.Pz.PzWiersz != null && Jpk.Pz.PzWiersz.Count != 0;

            Jpk.PzSpecified = anyPzWartosc || anyPzWiersz;

            if (anyPzWartosc)
            {
                foreach (var pzWartosc in Jpk.Pz.PzWartosc)
                {
                    pzWartosc.NumerFakturySpecified = !IsDefaultValue(pzWartosc.NumerFaktury);
                    pzWartosc.DataFakturySpecified = !IsDefaultValue(pzWartosc.DataFaktury);
                }
            }

            if (anyPzWiersz)
            {
                foreach (var pzWiersz in Jpk.Pz.PzWiersz)
                    pzWiersz.KodTowaruSpecified = !IsDefaultValue(pzWiersz.KodTowaru);
            }

            if (anyPzWartosc)
            {
                Jpk.Pz.PzCtrl = new PzCtrl
                {
                    Liczba = Jpk.Pz.PzWartosc.Count.ToString(),
                    Suma = Jpk.Pz.PzWartosc.Sum(s => s.Wartosc),
                };
            }
            else
                Jpk.Pz.PzCtrl = null;
        }

        private void UpdateWz()
        {
            if (Jpk.Wz == null)
            {
                Jpk.WzSpecified = false;
                return;
            }

            var anyWzWartosc = Jpk.Wz.WzWartosc != null && Jpk.Wz.WzWartosc.Count != 0;
            var anyWzWiersz = Jpk.Wz.WzWiersz != null && Jpk.Wz.WzWiersz.Count != 0;

            Jpk.WzSpecified = anyWzWartosc || anyWzWiersz;

            if (anyWzWartosc)
            {
                foreach (var wzWartosc in Jpk.Wz.WzWartosc)
                {
                    wzWartosc.NumerFakturySpecified = !IsDefaultValue(wzWartosc.NumerFaktury);
                    wzWartosc.DataFakturySpecified = !IsDefaultValue(wzWartosc.DataFaktury);
                }
            }

            if(anyWzWiersz)
            {
                foreach (var wzWiersz in Jpk.Wz.WzWiersz)
                    wzWiersz.KodTowaruSpecified = !IsDefaultValue(wzWiersz.KodTowaru);
            }

            if (anyWzWartosc)
            {
                Jpk.Wz.WzCtrl = new WzCtrl
                {
                    Liczba = Jpk.Wz.WzWartosc.Count.ToString(),
                    Suma = Jpk.Wz.WzWartosc.Sum(s => s.Wartosc),
                };
            }
            else
                Jpk.Wz.WzCtrl = null;
        }

        private void UpdateRw()
        {
            if (Jpk.Rw == null)
            {
                Jpk.RwSpecified = false;
                return;
            }

            var anyRwWartosc = Jpk.Rw.RwWartosc != null && Jpk.Rw.RwWartosc.Count != 0;
            var anyRwWiersz = Jpk.Rw.RwWiersz != null && Jpk.Rw.RwWiersz.Count != 0;

            Jpk.RwSpecified = anyRwWartosc || anyRwWiersz;

            if (anyRwWartosc)
            {
                foreach (var rwWartosc in Jpk.Rw.RwWartosc)
                {
                    rwWartosc.SkadSpecified = !IsDefaultValue(rwWartosc.Skad);
                    rwWartosc.DokadSpecified = !IsDefaultValue(rwWartosc.Dokad);
                }
            }

            if (anyRwWiersz)
            {
                foreach (var rwWiersz in Jpk.Rw.RwWiersz)
                    rwWiersz.KodTowaruSpecified = !IsDefaultValue(rwWiersz.KodTowaru);
            }

            if (anyRwWartosc)
            {
                Jpk.Rw.RwCtrl = new RwCtrl
                {
                    Liczba = Jpk.Rw.RwWartosc.Count.ToString(),
                    Suma = Jpk.Rw.RwWartosc.Sum(s => s.Wartosc),
                };
            }
            else
                Jpk.Rw.RwCtrl = null;
        }

        private void UpdateMm()
        {
            if (Jpk.Mm == null)
            {
                Jpk.MmSpecified = false;
                return;
            }

            var anyMmWartosc = Jpk.Mm.MmWartosc != null && Jpk.Mm.MmWartosc.Count != 0;
            var anyMmWiersz = Jpk.Mm.MmWiersz != null && Jpk.Mm.MmWiersz.Count != 0;

            Jpk.MmSpecified = anyMmWartosc || anyMmWiersz;

            if (anyMmWartosc)
            {
                foreach (var mmWartosc in Jpk.Mm.MmWartosc)
                {
                    mmWartosc.SkadSpecified = !IsDefaultValue(mmWartosc.Skad);
                    mmWartosc.DokadSpecified = !IsDefaultValue(mmWartosc.Dokad);
                }
            }

            if (anyMmWiersz)
            {
                foreach (var mmWiersz in Jpk.Mm.MmWiersz)
                    mmWiersz.KodTowaruSpecified = !IsDefaultValue(mmWiersz.KodTowaru);
            }

            if (anyMmWartosc)
            {
                Jpk.Mm.MmCtrl = new MmCtrl
                {
                    Liczba = Jpk.Mm.MmWartosc.Count.ToString(),
                    Suma = Jpk.Mm.MmWartosc.Sum(s => s.Wartosc),
                };
            }
            else
                Jpk.Mm.MmCtrl = null;
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
