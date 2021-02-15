namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Pkpir2;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkPkpir2ViewModelTests
    {
        [DataTestMethod]
        [DataRow(false, "TestFiles/jpk_pkpir2_valid_with_pkpir_wiersze_only.xml", DisplayName = "JPK_PKPIR(2) - Without Spis")]
        [DataRow(true, "TestFiles/jpk_pkpir2_valid_with_pkpir_wiersze_and_spis.xml", DisplayName = "JPK_PKPIR(2) - With Spis")]
        [Description("Checks if JPK_PKPIR(2) files are generated properly.")]
        public async Task JpkPkpir2FilesAreGeneratedProperly(bool appendSpis, string expectedFullFilePath)
        {
            var vm = new JpkPkpir2ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);
            AppendPkpirInfo(jpk);

            AppendPkpirWiersze(jpk);
            if (appendSpis) AppendSpis(jpk);

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

            jpk.Podmiot.AdresPodmiotu = GetAdres();
            jpk.Podmiot.IdentyfikatorPodmiotu = TestHelper.GetIdentyfikatorOsobyNiefizycznejV40();
        }

        private static void AppendPkpirInfo(Jpk jpk)
        {
            jpk.PkpirInfo = GetPkpirInfoTemplate();
        }

        private static void AppendPkpirWiersze(Jpk jpk)
        {
            var pkpirW = jpk.PkpirWiersze;

            //row01: no (K16A, K16B) pair, no K17
            var r01 = GetPkpirWierszTemplate();
            r01.K16B = (decimal)5252.87;

            //row02: no (K16A, K16B) pair, with K17
            var r02 = GetPkpirWierszTemplate();
            r02.K17 = "Uwagi";

            //row03: with (K16A, K16B) pair, no K17
            var r03 = GetPkpirWierszTemplate();
            r03.K16A = "Standardowy koszt";

            //row04: with (K16A, K16B) pair, with K17
            var r04 = GetPkpirWierszTemplate();
            r04.K16A = "Standardowy koszt";
            r04.K16B = (decimal)5252.87;
            r04.K17 = "Uwagi";

            pkpirW.Add(r01);
            pkpirW.Add(r02);
            pkpirW.Add(r03);
            pkpirW.Add(r04);
        }

        private static void AppendSpis(Jpk jpk)
        {
            jpk.PkpirSpis.Add(GetPkpirSpisTemplate());
        }

        private static Adres GetAdres(
            bool defineWojewodztwo = true,
            bool definePowiat = true,
            bool defineGmina = true,
            bool defineUlica = true,
            bool defineNrDomu = true,
            bool defineNrLokalu = true,
            bool defineKodPocztowy = true,
            bool definePoczta = true)
        {
            var adres = new Adres
            {
                Miejscowosc = "Wałbrzych",
            };

            if (defineWojewodztwo)
                adres.Wojewodztwo = "dolnośląskie";

            if (definePowiat)
                adres.Powiat = "wałbrzyski";

            if (defineGmina)
                adres.Gmina = "Wałbrzych";

            if (defineUlica)
                adres.Ulica = "Lipowa";

            if (defineNrDomu)
                adres.NrDomu = "1";

            if (defineNrLokalu)
                adres.NrLokalu = "8";

            if (defineKodPocztowy)
                adres.KodPocztowy = "58-302";

            if (definePoczta)
                adres.Poczta = "Urząd pocztowy";

            return adres;
        }

        private static PkpirInfo GetPkpirInfoTemplate()
        {
            var pi = new PkpirInfo
            {
                P1 = (decimal)1.01,
                P2 = (decimal)2.02,
                P3 = (decimal)3.03,
                P4 = (decimal)4.04,
            };

            return pi;
        }

        private static PkpirWiersz GetPkpirWierszTemplate()
        {
            var p = new PkpirWiersz
            {
                K2 = new DateTime(2020, 1, 1),
                K3 = "75/5446",
                K4 = "Firma krzak s.c.",
                K5 = "ul. Maślana 45/234, 56-123 Jagodnik",
                K6 = "Zdarzenie gospodarcze ???",
                K7 = (decimal)1234.52,
                K8 = (decimal)334.38,
                K9 = (decimal)3832.68,
                K10 = (decimal)8322.39,
                K11 = (decimal)1245475.71,
                K12 = (decimal)84563.44,
                K13 = (decimal)56362.02,
                K14 = (decimal)15.72,
                K15 = (decimal)943.34,
            };

            return p;
        }

        private static PkpirSpis GetPkpirSpisTemplate()
        {
            var p = new PkpirSpis 
            { 
                P5A = new DateTime(2020, 1, 13), 
                P5B = (decimal)123.45 
            };

            return p;
        }
    }
}