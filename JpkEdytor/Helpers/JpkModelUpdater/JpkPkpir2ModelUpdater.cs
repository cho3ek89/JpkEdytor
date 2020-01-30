namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Collections.Generic;
    using System.Linq;

    using Models.Pkpir2;

    public sealed class JpkPkpir2ModelUpdater : JpkModelUpdater<Jpk>
    {
        public override void UpdateJpk(Jpk jpk)
        {
            if (jpk == null) return;

            UpdatePodmiot(jpk.Podmiot);
            UpdatePkpirWiersze(jpk.PkpirWiersze);
            UpdateCrtl(jpk);
        }

        private void UpdatePodmiot(Podmiot podmiot)
        {
            if (podmiot == null) return;

            UpdateIdentyfikatorOsobyNiefizycznej(podmiot.IdentyfikatorPodmiotu);
            UpdateAdres(podmiot.AdresPodmiotu);
        }

        private void UpdateAdres(Adres adres)
        {
            if (adres == null) return;

            adres.WojewodztwoSpecified = !IsDefaultValue(adres.Wojewodztwo);
            adres.PowiatSpecified = !IsDefaultValue(adres.Powiat);
            adres.GminaSpecified = !IsDefaultValue(adres.Gmina);
            adres.UlicaSpecified = !IsDefaultValue(adres.Ulica);
            adres.NrDomuSpecified = !IsDefaultValue(adres.NrDomu);
            adres.NrLokaluSpecified = !IsDefaultValue(adres.NrLokalu);
            adres.KodPocztowySpecified = !IsDefaultValue(adres.KodPocztowy);
            adres.PocztaSpecified = !IsDefaultValue(adres.Poczta);
        }

        private void UpdatePkpirWiersze(IEnumerable<PkpirWiersz> pkpirWiersze)
        {
            if (pkpirWiersze == null) return;

            var count = 1;
            foreach (var pkpirWiersz in pkpirWiersze)
            {
                pkpirWiersz.K1 = count++.ToString();

                var areK16AK16BSpecified = !IsDefaultValue(pkpirWiersz.K16A);

                pkpirWiersz.K16ASpecified = areK16AK16BSpecified;
                pkpirWiersz.K16BSpecified = areK16AK16BSpecified;
                pkpirWiersz.K17Specified = !IsDefaultValue(pkpirWiersz.K17);
            }
        }

        private void UpdateCrtl(Jpk jpk)
        {
            if (jpk.PkpirWiersze == null || jpk.PkpirWiersze.Count == 0)
                jpk.PkpirCtrl = null;
            else
            {
                jpk.PkpirCtrl = new PkpirCtrl
                {
                    LiczbaWierszy = jpk.PkpirWiersze.Count.ToString(),
                    SumaPrzychodow = jpk.PkpirWiersze.Sum(s => s.K9),
                };
            }
        }
    }
}
