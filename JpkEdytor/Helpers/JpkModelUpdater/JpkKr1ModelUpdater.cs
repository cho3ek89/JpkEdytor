namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Collections.Generic;
    using System.Linq;

    using Models.Common;
    using Models.Kr1;

    public sealed class JpkKr1ModelUpdater : JpkModelUpdater<Jpk>
    {
        public override void UpdateJpk(Jpk jpk)
        {
            if (jpk == null) return;

            UpdatePodmiot(jpk.Podmiot);
            UpdateDziennik(jpk.Dziennik);
            UpdateKontoZapis(jpk.KontoZapis);
            UpdateZois(jpk.Zois);
            UpdateCrtls(jpk);
        }

        private void UpdatePodmiot(Podmiot podmiot)
        {
            if (podmiot == null) return;

            UpdateIdentyfikatorOsobyNiefizycznej(podmiot.IdentyfikatorPodmiotu);
            UpdateAdresPolski(podmiot.AdresPodmiotu);
        }

        private void UpdateDziennik(IEnumerable<Dziennik> dziennik)
        {
            if (dziennik == null) return;

            var count = 1;
            foreach (var dziennikWpis in dziennik)
                dziennikWpis.LpZapisuDziennika = count++.ToString();
        }

        private void UpdateKontoZapis(IEnumerable<KontoZapis> kontoZapisy)
        {
            if (kontoZapisy == null) return;

            var count = 1;
            foreach (var kontoZapis in kontoZapisy)
            {
                kontoZapis.LpZapisu = count++.ToString();

                kontoZapis.KwotaWinienWalutaSpecified = kontoZapis.KodWalutyWinien != KodWalutyV30.PLN;
                kontoZapis.KodWalutyWinienSpecified = kontoZapis.KodWalutyWinien != KodWalutyV30.PLN;
                kontoZapis.OpisZapisuWinienSpecified = !IsDefaultValue(kontoZapis.OpisZapisuWinien);
                kontoZapis.KwotaMaWalutaSpecified = kontoZapis.KodWalutyMa != KodWalutyV30.PLN;
                kontoZapis.KodWalutyMaSpecified = kontoZapis.KodWalutyMa != KodWalutyV30.PLN;
                kontoZapis.OpisZapisuMaSpecified = !IsDefaultValue(kontoZapis.OpisZapisuMa);
            }
        }

        private void UpdateZois(IEnumerable<Zois> zois)
        {
            if (zois == null) return;

            foreach (var zoisWpis in zois)
            {
                zoisWpis.KodPodkategoriiSpecified = !IsDefaultValue(zoisWpis.KodPodkategorii);
                zoisWpis.OpisPodkategoriiSpecified = !IsDefaultValue(zoisWpis.OpisPodkategorii);
            }
        }

        private void UpdateCrtls(Jpk jpk)
        {
            if (jpk.Dziennik == null || jpk.Dziennik.Count == 0)
                jpk.DziennikCtrl = null;
            else
            {
                jpk.DziennikCtrl = new DziennikCtrl
                {
                    LiczbaWierszyDziennika = jpk.Dziennik.Count.ToString(),
                    SumaKwotOperacji = jpk.Dziennik.Sum(s => s.DziennikKwotaOperacji)
                };
            }

            if (jpk.KontoZapis == null || jpk.KontoZapis.Count == 0)
                jpk.KontoZapisCtrl = null;
            else
            {
                jpk.KontoZapisCtrl = new KontoZapisCtrl
                {
                    LiczbaWierszyKontoZapisu = jpk.KontoZapis.Count.ToString(),
                    SumaWinien = jpk.KontoZapis.Sum(s => s.KwotaWinien),
                    SumaMa = jpk.KontoZapis.Sum(s => s.KwotaMa),
                };
            }
        }
    }
}
