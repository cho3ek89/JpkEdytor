namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Linq;

    using Models.Mag1;

    public sealed class JpkMag1ModelUpdater : JpkModelUpdater<Jpk>
    {
        public override void UpdateJpk(Jpk jpk)
        {
            if (jpk == null) return;

            UpdatePodmiot(jpk.Podmiot);
            UpdatePz(jpk);
            UpdateWz(jpk);
            UpdateRw(jpk);
            UpdateMm(jpk);
        }

        private void UpdatePodmiot(Podmiot podmiot)
        {
            if (podmiot == null) return;

            UpdateIdentyfikatorOsobyNiefizycznej(podmiot.IdentyfikatorPodmiotu);
            UpdateAdresPolski(podmiot.AdresPodmiotu);
        }

        private void UpdatePz(Jpk jpk)
        {
            if (jpk.Pz == null)
            {
                jpk.PzSpecified = false;
                return;
            }

            var anyPzWartosc = jpk.Pz.PzWartosc != null && jpk.Pz.PzWartosc.Count != 0;
            var anyPzWiersz = jpk.Pz.PzWiersz != null && jpk.Pz.PzWiersz.Count != 0;

            jpk.PzSpecified = anyPzWartosc || anyPzWiersz;

            if (anyPzWartosc)
            {
                foreach (var pzWartosc in jpk.Pz.PzWartosc)
                {
                    pzWartosc.NumerFakturySpecified = !IsDefaultValue(pzWartosc.NumerFaktury);
                    pzWartosc.DataFakturySpecified = !IsDefaultValue(pzWartosc.DataFaktury);
                }
            }

            if (anyPzWiersz)
            {
                foreach (var pzWiersz in jpk.Pz.PzWiersz)
                    pzWiersz.KodTowaruSpecified = !IsDefaultValue(pzWiersz.KodTowaru);
            }

            if (anyPzWartosc)
            {
                jpk.Pz.PzCtrl = new PzCtrl
                {
                    Liczba = jpk.Pz.PzWartosc.Count.ToString(),
                    Suma = jpk.Pz.PzWartosc.Sum(s => s.Wartosc),
                };
            }
            else
                jpk.Pz.PzCtrl = null;
        }

        private void UpdateWz(Jpk jpk)
        {
            if (jpk.Wz == null)
            {
                jpk.WzSpecified = false;
                return;
            }

            var anyWzWartosc = jpk.Wz.WzWartosc != null && jpk.Wz.WzWartosc.Count != 0;
            var anyWzWiersz = jpk.Wz.WzWiersz != null && jpk.Wz.WzWiersz.Count != 0;

            jpk.WzSpecified = anyWzWartosc || anyWzWiersz;

            if (anyWzWartosc)
            {
                foreach (var wzWartosc in jpk.Wz.WzWartosc)
                {
                    wzWartosc.NumerFakturySpecified = !IsDefaultValue(wzWartosc.NumerFaktury);
                    wzWartosc.DataFakturySpecified = !IsDefaultValue(wzWartosc.DataFaktury);
                }
            }

            if (anyWzWiersz)
            {
                foreach (var wzWiersz in jpk.Wz.WzWiersz)
                    wzWiersz.KodTowaruSpecified = !IsDefaultValue(wzWiersz.KodTowaru);
            }

            if (anyWzWartosc)
            {
                jpk.Wz.WzCtrl = new WzCtrl
                {
                    Liczba = jpk.Wz.WzWartosc.Count.ToString(),
                    Suma = jpk.Wz.WzWartosc.Sum(s => s.Wartosc),
                };
            }
            else
                jpk.Wz.WzCtrl = null;
        }

        private void UpdateRw(Jpk jpk)
        {
            if (jpk.Rw == null)
            {
                jpk.RwSpecified = false;
                return;
            }

            var anyRwWartosc = jpk.Rw.RwWartosc != null && jpk.Rw.RwWartosc.Count != 0;
            var anyRwWiersz = jpk.Rw.RwWiersz != null && jpk.Rw.RwWiersz.Count != 0;

            jpk.RwSpecified = anyRwWartosc || anyRwWiersz;

            if (anyRwWartosc)
            {
                foreach (var rwWartosc in jpk.Rw.RwWartosc)
                {
                    rwWartosc.SkadSpecified = !IsDefaultValue(rwWartosc.Skad);
                    rwWartosc.DokadSpecified = !IsDefaultValue(rwWartosc.Dokad);
                }
            }

            if (anyRwWiersz)
            {
                foreach (var rwWiersz in jpk.Rw.RwWiersz)
                    rwWiersz.KodTowaruSpecified = !IsDefaultValue(rwWiersz.KodTowaru);
            }

            if (anyRwWartosc)
            {
                jpk.Rw.RwCtrl = new RwCtrl
                {
                    Liczba = jpk.Rw.RwWartosc.Count.ToString(),
                    Suma = jpk.Rw.RwWartosc.Sum(s => s.Wartosc),
                };
            }
            else
                jpk.Rw.RwCtrl = null;
        }

        private void UpdateMm(Jpk jpk)
        {
            if (jpk.Mm == null)
            {
                jpk.MmSpecified = false;
                return;
            }

            var anyMmWartosc = jpk.Mm.MmWartosc != null && jpk.Mm.MmWartosc.Count != 0;
            var anyMmWiersz = jpk.Mm.MmWiersz != null && jpk.Mm.MmWiersz.Count != 0;

            jpk.MmSpecified = anyMmWartosc || anyMmWiersz;

            if (anyMmWartosc)
            {
                foreach (var mmWartosc in jpk.Mm.MmWartosc)
                {
                    mmWartosc.SkadSpecified = !IsDefaultValue(mmWartosc.Skad);
                    mmWartosc.DokadSpecified = !IsDefaultValue(mmWartosc.Dokad);
                }
            }

            if (anyMmWiersz)
            {
                foreach (var mmWiersz in jpk.Mm.MmWiersz)
                    mmWiersz.KodTowaruSpecified = !IsDefaultValue(mmWiersz.KodTowaru);
            }

            if (anyMmWartosc)
            {
                jpk.Mm.MmCtrl = new MmCtrl
                {
                    Liczba = jpk.Mm.MmWartosc.Count.ToString(),
                    Suma = jpk.Mm.MmWartosc.Sum(s => s.Wartosc),
                };
            }
            else
                jpk.Mm.MmCtrl = null;
        }
    }
}
