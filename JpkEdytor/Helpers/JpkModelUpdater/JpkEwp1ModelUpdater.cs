namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Collections.Generic;
    using System.Linq;

    using Models.Ewp1;

    public sealed class JpkEwp1ModelUpdater : JpkModelUpdater<Jpk>
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

            UpdateIdentyfikatorOsobyNiefizycznej(podmiot.IdentyfikatorPodmiotu);
            UpdateAdresPolski(podmiot.AdresPodmiotu);
        }

        private void UpdateEwpWiersze(IEnumerable<EwpWiersz> ewpWiersze)
        {
            if (ewpWiersze == null) return;

            var count = 1;
            foreach (var ewpWiersz in ewpWiersze)
            {
                ewpWiersz.K1 = count++.ToString();

                ewpWiersz.K12Specified = !IsDefaultValue(ewpWiersz.K12);
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
                    SumaPrzychodow = jpk.EwpWiersze.Sum(s => s.K10)
                };
            }
        }
    }
}
