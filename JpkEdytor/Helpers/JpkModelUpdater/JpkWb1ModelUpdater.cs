namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Collections.Generic;
    using System.Linq;

    using Models.Wb1;

    public sealed class JpkWb1ModelUpdater : JpkModelUpdater<Jpk>
    {
        public override void UpdateJpk(Jpk jpk)
        {
            if (jpk == null) return;

            UpdatePodmiot(jpk.Podmiot);
            UpdateWyciagWiersze(jpk.WyciagWiersze);
            UpdateCrtl(jpk);
        }

        private void UpdatePodmiot(Podmiot podmiot)
        {
            if (podmiot == null) return;

            UpdateIdentyfikatorOsobyNiefizycznej(podmiot.IdentyfikatorPodmiotu);
            UpdateAdresPolski(podmiot.AdresPodmiotu);
        }

        private void UpdateWyciagWiersze(IEnumerable<WyciagWiersz> wyciagWiersze)
        {
            if (wyciagWiersze == null) return;

            var count = 1;
            foreach (var wyciagWiersz in wyciagWiersze)
                wyciagWiersz.NumerWiersza = count++.ToString();
        }

        private void UpdateCrtl(Jpk jpk)
        {
            if (jpk.WyciagWiersze == null || jpk.WyciagWiersze.Count == 0)
                jpk.WyciagCtrl = null;
            else
            {
                jpk.WyciagCtrl = new WyciagCtrl
                {
                    LiczbaWierszy = jpk.WyciagWiersze.Count.ToString(),
                    SumaObciazen = jpk.WyciagWiersze.Sum(s => s.KwotaOperacji),
                    SumaUznan = jpk.WyciagWiersze.Sum(s => s.SaldoOperacji)
                };
            }
        }
    }
}
