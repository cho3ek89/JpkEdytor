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
        }

        protected override void UpdateCrtls()
        {
            if (Jpk.PkpirWiersze == null || Jpk.PkpirWiersze.Count == 0)
                Jpk.PkpirCtrl = null;
            else
            {
                var count = 1;
                foreach (var pkpirWiersz in Jpk.PkpirWiersze)
                    pkpirWiersz.K1 = count++.ToString();

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
