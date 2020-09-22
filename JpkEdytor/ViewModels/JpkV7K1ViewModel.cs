namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using Framework;
    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.V71.V7K;

    public sealed class JpkV7K1ViewModel : JpkV71ViewModelBase<Jpk>
    {
        public JpkV7K1ViewModel()
        {
            Jpk = new Jpk();

            schemaFileName = @"Schemat_JPK_V7K(1)_v1-2E.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2020/03/11/eD/DefinicjeTypy/";
            tnsNamespace = @"http://crd.gov.pl/wzor/2020/05/08/9394/";

            jpkModelUpdater = new JpkV7K1ModelUpdater();
        }

        public override ICommand ChangePodmiotType => new RelayCommand<string>(obj =>
        {
            if (obj == "0" && Jpk.Podmiot.Item is PodmiotDowolnyBezAdresuOsobaNiefizyczna)
                Jpk.Podmiot.Item = new PodmiotDowolnyBezAdresuOsobaFizyczna();

            if (obj == "1" && Jpk.Podmiot.Item is PodmiotDowolnyBezAdresuOsobaFizyczna)
                Jpk.Podmiot.Item = new PodmiotDowolnyBezAdresuOsobaNiefizyczna();
        });

        public override ICommand AddOrRemoveDeklaracja => new RelayCommand<bool>(obj =>
        {
            Jpk.Deklaracja = obj ? new Deklaracja() : null;
        });

        public override async Task ImportSprzedazFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<EwidencjaSprzedazWiersz>(fullFilePath);
                Jpk.Ewidencja.SprzedazWiersze = new ObservableCollection<EwidencjaSprzedazWiersz>(collection);
            });
        }

        public override async Task ImportZakupyFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<EwidencjaZakupWiersz>(fullFilePath);
                Jpk.Ewidencja.ZakupWiersze = new ObservableCollection<EwidencjaZakupWiersz>(collection);
            });
        }
    }
}
