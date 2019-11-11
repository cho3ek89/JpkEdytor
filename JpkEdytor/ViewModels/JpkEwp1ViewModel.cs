﻿namespace JpkEdytor.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using Helpers.CsvImporter;
    using Models.Common;
    using Models.Ewp1;

    public sealed class JpkEwp1ViewModel : JpkViewModelBase<Jpk>
    {
        public JpkEwp1ViewModel()
        {
            Jpk = new Jpk
            {
                Naglowek = new Naglowek(),
                Podmiot = new Podmiot()
                {
                    AdresPodmiotu = new AdresPolskiV40(),
                    IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
                },
                EwpWiersze = new ObservableCollection<EwpWiersz>(),
            };

            schemaFileName = @"Schemat_JPK_EWP_v1-0.xsd";
        }

        protected override void UpdateCrtls()
        {
            if (Jpk.EwpWiersze == null || Jpk.EwpWiersze.Count == 0)
                Jpk.EwpCtrl = null;
            else
            {
                var count = 1;
                foreach (var ewpWiersz in Jpk.EwpWiersze)
                    ewpWiersz.K1 = count++.ToString();

                Jpk.EwpCtrl = new EwpCtrl
                {
                    LiczbaWierszy = Jpk.EwpWiersze.Count.ToString(),
                    SumaPrzychodow = Jpk.EwpWiersze.Sum(s => s.K10)
                };
            }
        }

        public async Task ImportEwpFromCsv(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var collection = CsvImporter.GetCollectionFromCsv<EwpWiersz>(fullFilePath);
                Jpk.EwpWiersze = new ObservableCollection<EwpWiersz>(collection);
            });
        }
    }
}
