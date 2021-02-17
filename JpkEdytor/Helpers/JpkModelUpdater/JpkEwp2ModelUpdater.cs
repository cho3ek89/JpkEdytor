namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Collections.Generic;
    using System.Linq;

    using Models.Ewp2;

    public sealed class JpkEwp2ModelUpdater : JpkModelUpdater<Jpk>
    {
        public override void UpdateJpk(Jpk jpk)
        {
            if (jpk == null) return;

            UpdatePodmiot(jpk.Podmiot);
            UpdateEwpWiersze(jpk.EwpWiersze);
            UpdateCrtl(jpk);
        }

        private void UpdatePodmiot(Podmiot podmiot)
        {
            if (podmiot == null) return;

            UpdateAdresPolski(podmiot.AdresPodmiotu);
        }

        private void UpdateEwpWiersze(IEnumerable<EwpWiersz> ewpWiersze)
        {
            if (ewpWiersze == null) return;

            var count = 1;
            foreach (var ewpWiersz in ewpWiersze)
            {
                ewpWiersz.K1 = count++.ToString();

                ewpWiersz.K13Specified = !IsDefaultValue(ewpWiersz.K13);
            }
        }

        private void UpdateCrtl(Jpk jpk)
        {
            if (jpk.EwpWiersze == null || jpk.EwpWiersze.Count == 0)
                jpk.EwpCtrl = null;
            else
            {
                jpk.EwpCtrl = new EwpCtrl
                {
                    LiczbaWierszy = jpk.EwpWiersze.Count.ToString(),
                    SumaPrzychodow = jpk.EwpWiersze.Sum(s => s.K12)
                };
            }
        }
    }
}
