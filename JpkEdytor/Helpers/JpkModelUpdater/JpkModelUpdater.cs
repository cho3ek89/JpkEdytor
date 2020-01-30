namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using Models;
    using Models.Common;

    public abstract class JpkModelUpdater<T> : IJpkModelUpdater<T> where T : IJpk
    {
        public abstract void UpdateJpk(T jpk);

        protected void UpdateIdentyfikatorOsobyNiefizycznej(IdentyfikatorOsobyNiefizycznejV40 idOsoby)
        {
            if (idOsoby == null) return;

            idOsoby.RegonSpecified = !IsDefaultValue(idOsoby.Regon);
        }

        protected void UpdateIdentyfikatorOsobyNiefizycznej(IdentyfikatorOsobyNiefizycznejV50 idOsoby)
        {
            if (idOsoby == null) return;

            idOsoby.RegonSpecified = !IsDefaultValue(idOsoby.Regon);
        }

        protected void UpdateAdresPolski(AdresPolskiV40 adres)
        {
            if (adres == null) return;

            adres.UlicaSpecified = !IsDefaultValue(adres.Ulica);
            adres.NrLokaluSpecified = !IsDefaultValue(adres.NrLokalu);
        }

        protected void UpdateAdresPolski(AdresPolskiV50 adres)
        {
            if (adres == null) return;

            adres.UlicaSpecified = !IsDefaultValue(adres.Ulica);
            adres.NrLokaluSpecified = !IsDefaultValue(adres.NrLokalu);
        }

        protected void UpdateAdresPolski(AdresPolski1V50 adres)
        {
            if (adres == null) return;

            adres.UlicaSpecified = !IsDefaultValue(adres.Ulica);
            adres.NrLokaluSpecified = !IsDefaultValue(adres.NrLokalu);
        }

        protected void UpdateAdresZagraniczny(AdresZagranicznyV50 adres)
        {
            if (adres == null) return;

            adres.KodPocztowySpecified = !IsDefaultValue(adres.KodPocztowy);
            adres.UlicaSpecified = !IsDefaultValue(adres.Ulica);
            adres.NrDomuSpecified = !IsDefaultValue(adres.NrDomu);
            adres.NrLokaluSpecified = !IsDefaultValue(adres.NrLokalu);
        }

        protected static bool IsDefaultValue<Type>(Type obj)
        {
            if (typeof(Type) == typeof(string))
                return string.IsNullOrEmpty(obj?.ToString());

            return obj.Equals(default(Type));
        }
    }
}
