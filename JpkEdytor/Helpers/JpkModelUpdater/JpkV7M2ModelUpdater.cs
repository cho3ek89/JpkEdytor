namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Linq;

    using Models.V72.V7M;

    public sealed class JpkV7M2ModelUpdater : JpkV72ModelUpdater<Jpk>
    {
        public override void UpdateJpk(Jpk jpk)
        {
            if (jpk == null) return;

            UpdatePodmiot(jpk.Podmiot);

            if (jpk.Deklaracja == null)
                jpk.DeklaracjaSpecified = false;
            else
            {
                UpdateDeklaracjaPozycjeSzczegolowe(jpk.Deklaracja.PozycjeSzczegolowe);
                jpk.DeklaracjaSpecified = true;
            }

            if (jpk.Ewidencja == null)
            {
                jpk.Ewidencja = new Ewidencja();
                jpk.EwidencjaSpecified = false;
            }
            else
            {
                UpdateSprzedazWiersze(jpk.Ewidencja.SprzedazWiersze);
                UpdateZakupWiersze(jpk.Ewidencja.ZakupWiersze);

                UpdateCrtls(jpk.Ewidencja);

                jpk.EwidencjaSpecified =
                    (jpk.Ewidencja.SprzedazWiersze != null && jpk.Ewidencja.SprzedazWiersze.Count() > 0) ||
                    (jpk.Ewidencja.ZakupWiersze != null && jpk.Ewidencja.ZakupWiersze.Count() > 0);
            }
        }

        private void UpdateCrtls(Ewidencja ewidencja)
        {
            ewidencja.SprzedazCtrl.LiczbaWierszySprzedazy = ewidencja.SprzedazWiersze.Count().ToString();
            ewidencja.SprzedazCtrl.PodatekNalezny = GetPodatekNalezny(ewidencja.SprzedazWiersze);

            ewidencja.ZakupCtrl.LiczbaWierszyZakupow = ewidencja.ZakupWiersze.Count().ToString();
            ewidencja.ZakupCtrl.PodatekNaliczony = GetPodatekNaliczony(ewidencja.ZakupWiersze);
        }

        private void UpdatePodmiot(Podmiot podmiot)
        {
            if (podmiot == null) return;

            if (podmiot.Item is PodmiotDowolnyBezAdresuOsobaFizyczna osobaFizyczna)
                osobaFizyczna.TelefonSpecified = !IsDefaultValue(osobaFizyczna.Telefon);

            if (podmiot.Item is PodmiotDowolnyBezAdresuOsobaNiefizyczna osobaNiefizyczna)
                osobaNiefizyczna.TelefonSpecified = !IsDefaultValue(osobaNiefizyczna.Telefon);
        }
    }
}
