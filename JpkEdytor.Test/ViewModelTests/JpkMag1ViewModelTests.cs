namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Mag1;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkMag1ViewModelTests
    {
        [DataTestMethod]
        [DataRow(false, false, false, false, "TestFiles/jpk_mag1_valid_empty.xml", DisplayName = "Empty")]
        [DataRow(false, false, false, true, "TestFiles/jpk_mag1_valid_mm.xml", DisplayName = "MM")]
        [DataRow(false, false, true, false, "TestFiles/jpk_mag1_valid_rw.xml", DisplayName = "RW")]
        [DataRow(false, false, true, true, "TestFiles/jpk_mag1_valid_rw_mm.xml", DisplayName = "RM, MM")]
        [DataRow(false, true, false, false, "TestFiles/jpk_mag1_valid_wz.xml", DisplayName = "WZ")]
        [DataRow(false, true, false, true, "TestFiles/jpk_mag1_valid_wz_mm.xml", DisplayName = "WZ, MM")]
        [DataRow(false, true, true, false, "TestFiles/jpk_mag1_valid_wz_rw.xml", DisplayName = "WZ, RW")]
        [DataRow(false, true, true, true, "TestFiles/jpk_mag1_valid_wz_rw_mm.xml", DisplayName = "WZ, RW, MM")]
        [DataRow(true, false, false, false, "TestFiles/jpk_mag1_valid_pz.xml", DisplayName = "PZ")]
        [DataRow(true, false, false, true, "TestFiles/jpk_mag1_valid_pz_mm.xml", DisplayName = "PZ, MM")]
        [DataRow(true, false, true, false, "TestFiles/jpk_mag1_valid_pz_rw.xml", DisplayName = "PZ, RW")]
        [DataRow(true, false, true, true, "TestFiles/jpk_mag1_valid_pz_rw_mm.xml", DisplayName = "PZ, RW, MM")]
        [DataRow(true, true, false, false, "TestFiles/jpk_mag1_valid_pz_wz.xml", DisplayName = "PZ, WZ")]
        [DataRow(true, true, false, true, "TestFiles/jpk_mag1_valid_pz_wz_mm.xml", DisplayName = "PZ, WZ, MM")]
        [DataRow(true, true, true, false, "TestFiles/jpk_mag1_valid_pz_wz_rw.xml", DisplayName = "PZ, WZ, RW")]
        [DataRow(true, true, true, true, "TestFiles/jpk_mag1_valid_pz_wz_rw_mm.xml", DisplayName = "PZ, WZ, RW, MM")]
        [Description("Checks if jpk_mag1 files are generated properly.")]
        public async Task JpkMag1FilesAreGeneratedProperly(bool appendPz, bool appendWz, bool appendRw, bool appendMm, string expectedFullFilePath)
        {
            var vm = new JpkMag1ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);
            AppendMagazyn(jpk);

            if (appendPz) AppendPz(vm);
            if (appendWz) AppendWz(vm);
            if (appendRw) AppendRw(vm);
            if (appendMm) AppendMm(vm);

            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual(expectedFullFilePath, actualFullFilePath);

            File.Delete(actualFullFilePath);
        }

        private static void AppendNaglowekAndPodmiot(Jpk jpk)
        {
            jpk.Naglowek.DataWytworzeniaJpk = new DateTime(2020, 1, 31);
            jpk.Naglowek.DataOd = new DateTime(2020, 1, 1);
            jpk.Naglowek.DataDo = new DateTime(2020, 1, 31);
            jpk.Naglowek.DomyslnyKodWaluty = Models.Common.KodWalutyV30.PLN;
            jpk.Naglowek.KodUrzedu = Models.Common.KodUsV40.Us2434;

            jpk.Podmiot.AdresPodmiotu = TestHelper.GetAdresPolskiV40();
            jpk.Podmiot.IdentyfikatorPodmiotu = TestHelper.GetIdentyfikatorOsobyNiefizycznejV40();
        }

        private static void AppendMagazyn(Jpk jpk)
        {
            jpk.Magazyn = "Magazyn nr 14351";
        }

        private static void AppendPz(JpkMag1ViewModel vm)
        {
            var pzWartosci = vm.Jpk.Pz.PzWartosc;

            //row01: no specified fields
            var r01a = GetPzWartoscTemplate();

            //row02: with NumerFaktury
            var r02a = GetPzWartoscTemplate();
            r02a.NumerFaktury = "123414/73432";

            //row03: with DataFaktury
            var r03a = GetPzWartoscTemplate();
            r03a.DataFaktury = new DateTime(2020, 1, 17);

            //row04: with all specified fields
            var r04a = GetPzWartoscTemplate();
            r04a.NumerFaktury = "123414/73432";
            r04a.DataFaktury = new DateTime(2020, 1, 17);

            pzWartosci.Add(r01a);
            pzWartosci.Add(r02a);
            pzWartosci.Add(r03a);
            pzWartosci.Add(r04a);

            var pzWiersze = vm.Jpk.Pz.PzWiersz;

            //row01: no NazwaTowaru
            var r01b = GetPzWierszTemplate();

            //row02: with NazwaTowaru
            var r02b = GetPzWierszTemplate();
            r02b.KodTowaru = "2345233";

            pzWiersze.Add(r01b);
            pzWiersze.Add(r02b);
        }

        private static void AppendWz(JpkMag1ViewModel vm)
        {
            var wzWartosci = vm.Jpk.Wz.WzWartosc;

            //row01: no specified fields
            var r01a = GetWzWartoscTemplate();

            //row02: with NumerFaktury
            var r02a = GetWzWartoscTemplate();
            r02a.NumerFaktury = "123414/73432";

            //row03: with DataFaktury
            var r03a = GetWzWartoscTemplate();
            r03a.DataFaktury = new DateTime(2020, 1, 17);

            //row04: with all specified fields
            var r04a = GetWzWartoscTemplate();
            r04a.NumerFaktury = "123414/73432";
            r04a.DataFaktury = new DateTime(2020, 1, 17);

            wzWartosci.Add(r01a);
            wzWartosci.Add(r02a);
            wzWartosci.Add(r03a);
            wzWartosci.Add(r04a);

            var wzWiersze = vm.Jpk.Wz.WzWiersz;

            //row01: no NazwaTowaru
            var r01b = GetWzWierszTemplate();

            //row02: with NazwaTowaru
            var r02b = GetWzWierszTemplate();
            r02b.KodTowaru = "2345233";

            wzWiersze.Add(r01b);
            wzWiersze.Add(r02b);
        }

        private static void AppendRw(JpkMag1ViewModel vm)
        {
            var rwWartosci = vm.Jpk.Rw.RwWartosc;

            //row01: no specified fields
            var r01a = GetRwWartoscTemplate();

            //row02: with Skad
            var r02a = GetRwWartoscTemplate();
            r02a.Skad = "Sanok";

            //row03: with Dokad
            var r03a = GetRwWartoscTemplate();
            r03a.Dokad = "Rawicz";

            //row04: with all specified fields
            var r04a = GetRwWartoscTemplate();
            r04a.Skad = "Sanok";
            r04a.Dokad = "Rawicz";

            rwWartosci.Add(r01a);
            rwWartosci.Add(r02a);
            rwWartosci.Add(r03a);
            rwWartosci.Add(r04a);

            var rwWiersze = vm.Jpk.Rw.RwWiersz;

            //row01: no NazwaTowaru
            var r01b = GetRwWierszTemplate();

            //row02: with NazwaTowaru
            var r02b = GetRwWierszTemplate();
            r02b.KodTowaru = "2345233";

            rwWiersze.Add(r01b);
            rwWiersze.Add(r02b);
        }

        private static void AppendMm(JpkMag1ViewModel vm)
        {
            var mmWartosci = vm.Jpk.Mm.MmWartosc;

            //row01: no specified fields
            var r01a = GetMmWartoscTemplate();

            //row02: with Skad
            var r02a = GetMmWartoscTemplate();
            r02a.Skad = "Sanok";

            //row03: with Dokad
            var r03a = GetMmWartoscTemplate();
            r03a.Dokad = "Rawicz";

            //row04: with all specified fields
            var r04a = GetMmWartoscTemplate();
            r04a.Skad = "Sanok";
            r04a.Dokad = "Rawicz";

            mmWartosci.Add(r01a);
            mmWartosci.Add(r02a);
            mmWartosci.Add(r03a);
            mmWartosci.Add(r04a);

            var mmWiersze = vm.Jpk.Mm.MmWiersz;

            //row01: no NazwaTowaru
            var r01b = GetMmWierszTemplate();

            //row02: with NazwaTowaru
            var r02b = GetMmWierszTemplate();
            r02b.KodTowaru = "2345233";

            mmWiersze.Add(r01b);
            mmWiersze.Add(r02b);
        }

        private static PzWartosc GetPzWartoscTemplate()
        {
            var p = new PzWartosc
            {
                Numer = "23451/15114",
                Data = new DateTime(2020, 1, 13),
                Wartosc = (decimal)42352.84,
                DataOtrzymania = new DateTime(2020, 1, 15),
                Dostawca = "Firma ABC s.c."
            };

            return p;
        }

        private static PzWiersz GetPzWierszTemplate()
        {
            var p = new PzWiersz
            {
                Numer2 = "23451/15114",
                NazwaTowaru = "piwo",
                IloscPrzyjeta = (decimal)4145.71,
                JednostkaMiary = "litr",
                CenaJednostkowa = (decimal)3.52,
                WartoscPozycji = (decimal)0.36
            };

            return p;
        }

        private static WzWartosc GetWzWartoscTemplate()
        {
            var w = new WzWartosc
            {
                Numer = "23451/15114",
                Data = new DateTime(2020, 1, 13),
                Wartosc = (decimal)42352.84,
                DataWydania = new DateTime(2020, 1, 15),
                Odbiorca = "Firma ABC s.c."
            };

            return w;
        }

        private static WzWiersz GetWzWierszTemplate()
        {
            var p = new WzWiersz
            {
                Numer2 = "23451/15114",
                NazwaTowaru = "piwo",
                IloscWydana = (decimal)4145.71,
                JednostkaMiary = "litr",
                CenaJednostkowa = (decimal)3.52,
                WartoscPozycji = (decimal)0.36
            };

            return p;
        }

        private static RwWartosc GetRwWartoscTemplate()
        {
            var r = new RwWartosc
            {
                Numer = "23451/15114",
                Data = new DateTime(2020, 1, 13),
                Wartosc = (decimal)42352.84,
                DataWydania = new DateTime(2020, 1, 15)
            };

            return r;
        }

        private static RwWiersz GetRwWierszTemplate()
        {
            var r = new RwWiersz
            {
                Numer2 = "23451/15114",
                NazwaTowaru = "piwo",
                IloscWydana = (decimal)4145.71,
                JednostkaMiary = "litr",
                CenaJednostkowa = (decimal)3.52,
                WartoscPozycji = (decimal)0.36
            };

            return r;
        }

        private static MmWartosc GetMmWartoscTemplate()
        {
            var m = new MmWartosc
            {
                Numer = "23451/15114",
                Data = new DateTime(2020, 1, 13),
                Wartosc = (decimal)42352.84,
                DataWydania = new DateTime(2020, 1, 15)
            };

            return m;
        }

        private static MmWiersz GetMmWierszTemplate()
        {
            var m = new MmWiersz
            {
                Numer2 = "23451/15114",
                NazwaTowaru = "piwo",
                IloscWydana = (decimal)4145.71,
                JednostkaMiary = "litr",
                CenaJednostkowa = (decimal)3.52,
                WartoscPozycji = (decimal)0.36
            };

            return m;
        }
    }
}
