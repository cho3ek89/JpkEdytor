namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using Framework;
    using Helpers.CsvImporter;
    using Helpers.JpkModelUpdater;
    using Models.V72.V7K;

    public sealed class JpkV7K2ViewModel : JpkV7ViewModelBase<Jpk>
    {
        public JpkV7K2ViewModel()
        {
            Jpk = new Jpk();

            schemaFileName = @"Schemat_JPK_V7K(2)_v1-0.xsd";
            etdNamespace = @"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2021/06/08/eD/DefinicjeTypy/";
            tnsNamespace = @"http://crd.gov.pl/wzor/2021/07/08/07082/";

            jpkModelUpdater = new JpkV7K2ModelUpdater();
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
