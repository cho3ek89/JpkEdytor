namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Collections.Generic;
    using System.Linq;

    using Models.FaRr1;

    public sealed class JpkFaRr1ModelUpdater : JpkModelUpdater<Jpk>
    {
        public override void UpdateJpk(Jpk jpk)
        {
            if (jpk == null) return;

            UpdatePodmiot(jpk.Podmiot);
            UpdateFakturaRr(jpk.FakturaRr);
            UpdateCrtls(jpk);
        }

        private void UpdatePodmiot(Podmiot podmiot)
        {
            if (podmiot == null) return;

            UpdateAdresPolski(podmiot.AdresPodmiotu);
        }

        private void UpdateFakturaRr(IEnumerable<FakturaRr> fakturyRr)
        {
            if (fakturyRr == null) return;

            foreach (var fakturaRr in fakturyRr)
            {
                var areFaKorSpecified = fakturaRr.RodzajFaktury == RodzajFaktury.Korekta;

                fakturaRr.PrzyczynaKorektySpecified = areFaKorSpecified;
                fakturaRr.NrFaKorygowanejSpecified = areFaKorSpecified;
                fakturaRr.OkresFaKorygowanejSpecified = areFaKorSpecified && !IsDefaultValue(fakturaRr.OkresFaKorygowanej);

                fakturaRr.DokumentSpecified = !IsDefaultValue(fakturaRr.Dokument);
            }
        }

        private void UpdateCrtls(Jpk jpk)
        {
            if (jpk.FakturaRr == null || jpk.FakturaRr.Count == 0)
                jpk.FakturaRrCtrl = null;
            else
            {
                jpk.FakturaRrCtrl = new FakturaRrCtrl
                {
                    LiczbaFakturRr = jpk.FakturaRr.Count.ToString(),
                    WartoscFakturRr = jpk.FakturaRr.Sum(s => s.P12_1)
                };
            }

            if (jpk.FakturaRrWiersz == null || jpk.FakturaRrWiersz.Count == 0)
                jpk.FakturaRrWierszCtrl = null;
            else
            {
                jpk.FakturaRrWierszCtrl = new FakturaRrWierszCtrl
                {
                    LiczbaWierszyFakturRr = jpk.FakturaRrWiersz.Count.ToString(),
                    WartoscWierszyFakturRr = jpk.FakturaRrWiersz.Sum(s => s.P8)
                };
            }

            if (jpk.Oswiadczenie == null || jpk.Oswiadczenie.Count == 0)
                jpk.OswiadczenieCtrl = null;
            else
            {
                jpk.OswiadczenieCtrl = new OswiadczenieCtrl
                {
                    LiczbaOswiadczen = jpk.Oswiadczenie.Count.ToString()
                };
            }
        }
    }
}
