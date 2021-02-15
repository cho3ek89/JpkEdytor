namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Vat3;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkVat3ViewModelTests
    {
        [DataTestMethod]
        [DataRow(false, false, "TestFiles/jpk_vat3_valid_empty.xml", DisplayName = "JPK_VAT(3) - Empty")]
        [DataRow(true, false, "TestFiles/jpk_vat3_valid_sprzedaz_only.xml", DisplayName = "JPK_VAT(3) - With Sprzedaz")]
        [DataRow(false, true, "TestFiles/jpk_vat3_valid_zakupy_only.xml", DisplayName = "JPK_VAT(3) - With Zakupy")]
        [DataRow(true, true, "TestFiles/jpk_vat3_valid_sprzedaz_and_zakupy.xml", DisplayName = "JPK_VAT(3) - With Sprzedaz and Zakupy")]
        [Description("Checks if JPK_VAT(3) files are generated properly.")]
        public async Task JpkVat3FilesAreGeneratedProperly(bool appendSprzedaz, bool appendZakupy, string expectedFullFilePath)
        {
            var vm = new JpkVat3ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);

            if (appendSprzedaz) AppendSprzedaz(jpk);
            if (appendZakupy) AppendZakupy(jpk);
            
            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual(expectedFullFilePath, actualFullFilePath);

            File.Delete(actualFullFilePath);
        }

        private static void AppendNaglowekAndPodmiot(Jpk jpk, bool defineEmail = true)
        {
            jpk.Naglowek.DataWytworzeniaJpk = new DateTime(2020, 1, 31);
            jpk.Naglowek.DataOd = new DateTime(2020, 1, 1);
            jpk.Naglowek.DataDo = new DateTime(2020, 1, 31);
            jpk.Naglowek.NazwaSystemu = "JpkEdytor";

            jpk.Podmiot.Nip = "8117960116";
            jpk.Podmiot.PelnaNazwa = "Zwyczajna Firma s.c.";
            if(defineEmail)
                jpk.Podmiot.Email = "firma@.mail.com";
        }

        private static void AppendSprzedaz(Jpk jpk)
        {
            var sprzedaz = jpk.SprzedazWiersz;

            //row01: no K values
            var r01 = GetSprzedazWierszTemplate();

            //row02: (K15, K16) pair
            var r02 = GetSprzedazWierszTemplate(false);
            r02.K10 = (decimal)1.00;
            r02.K15 = (decimal)1.00;

            //row03: K11, (K15, K16) pair
            var r03 = GetSprzedazWierszTemplate();
            r03.K11 = (decimal)1.00;
            r03.K16 = (decimal)1.00;

            //row04: K12, (K17, K18) pair
            var r04 = GetSprzedazWierszTemplate();
            r04.K12 = (decimal)1.00;
            r04.K17 = (decimal)1.00;

            //row05: K13, (K17, K18) pair
            var r05 = GetSprzedazWierszTemplate();
            r05.K13 = (decimal)1.00;
            r05.K18 = (decimal)1.00;

            //row06: K14, (K19, K20) pair
            var r06 = GetSprzedazWierszTemplate();
            r06.K14 = (decimal)1.00;
            r06.K19 = (decimal)1.00;

            //row07: K21, (K19, K20) pair
            var r07 = GetSprzedazWierszTemplate();
            r07.K20 = (decimal)1.00;
            r07.K21 = (decimal)1.00;

            //row08: K22, (K23, K24) pair
            var r08 = GetSprzedazWierszTemplate(false);
            r08.K22 = (decimal)1.00;
            r08.K23 = (decimal)1.00;

            //row09: (K23, K24) pair
            var r09 = GetSprzedazWierszTemplate();
            r09.K24 = (decimal)1.00;

            //row10: (K25, K26) pair
            var r10 = GetSprzedazWierszTemplate();
            r10.K25 = (decimal)1.00;

            //row11: (K25, K26) pair
            var r11 = GetSprzedazWierszTemplate();
            r11.K26 = (decimal)1.00;

            //row12: (K27, K28) pair, K31
            var r12 = GetSprzedazWierszTemplate(false);
            r12.K27 = (decimal)1.00;
            r12.K31 = (decimal)1.00;

            //row13: (K27, K28) pair , K36
            var r13 = GetSprzedazWierszTemplate();
            r13.K28 = (decimal)1.00;
            r13.K36 = (decimal)1.00;

            //row14: (K29, K30) pair, K37
            var r14 = GetSprzedazWierszTemplate();
            r14.K29 = (decimal)1.00;
            r14.K37 = (decimal)1.00;

            //row15: (K29, K30) pair, K38
            var r15 = GetSprzedazWierszTemplate();
            r15.K30 = (decimal)1.00;
            r15.K38 = (decimal)1.00;

            //row16: (K32, K33) pair, K39
            var r16 = GetSprzedazWierszTemplate(false);
            r16.K32 = (decimal)1.00;
            r16.K39 = (decimal)1.00;

            //row17: (K32, K33) pair
            var r17 = GetSprzedazWierszTemplate(false);
            r17.K33 = (decimal)1.00;

            //row18: (K34, K35) pair
            var r18 = GetSprzedazWierszTemplate(false);
            r18.K34 = (decimal)1.00;

            //row19: (K34, K35) pair
            var r19 = GetSprzedazWierszTemplate(false);
            r19.K35 = (decimal)1.00;

            //row20: everything
            var r20 = GetSprzedazWierszTemplate();
            r20.K10 = r20.K11 = r20.K12 = r20.K13 = r20.K14 = r20.K15 = r20.K16 = r20.K17 = r20.K18 = r20.K19 =
            r20.K20 = r20.K21 = r20.K22 = r20.K23 = r20.K24 = r20.K25 = r20.K26 = r20.K27 = r20.K28 = r20.K29 =
            r20.K30 = r20.K31 = r20.K32 = r20.K33 = r20.K34 = r20.K35 = r20.K36 = r20.K37 = r20.K38 = r20.K39 =
                (decimal)1.01;

            sprzedaz.Add(r01);
            sprzedaz.Add(r02);
            sprzedaz.Add(r03);
            sprzedaz.Add(r04);
            sprzedaz.Add(r05);
            sprzedaz.Add(r06);
            sprzedaz.Add(r07);
            sprzedaz.Add(r08);
            sprzedaz.Add(r09);
            sprzedaz.Add(r10);
            sprzedaz.Add(r11);
            sprzedaz.Add(r12);
            sprzedaz.Add(r13);
            sprzedaz.Add(r14);
            sprzedaz.Add(r15);
            sprzedaz.Add(r16);
            sprzedaz.Add(r17);
            sprzedaz.Add(r18);
            sprzedaz.Add(r19);
            sprzedaz.Add(r20);
        }

        private static void AppendZakupy(Jpk jpk)
        {
            var zakupy = jpk.ZakupWiersz;

            //row01: no K values
            var r01 = GetZakupWierszTemplate();

            //row02: (K43, K44) pair, K47
            var r02 = GetZakupWierszTemplate(false);
            r02.K43 = (decimal)1.00;
            r02.K47 = (decimal)1.00;

            //row03: (K43, K44) pair, K48
            var r03 = GetZakupWierszTemplate();
            r03.K44 = (decimal)1.00;
            r03.K48 = (decimal)1.00;

            //row04: (K45, K46) pair, K49
            var r04 = GetZakupWierszTemplate(false);
            r04.K45 = (decimal)1.00;
            r04.K49 = (decimal)1.00;

            //row05: (K45, K46) pair, K50
            var r05 = GetZakupWierszTemplate();
            r05.K46 = (decimal)1.00;
            r05.K50 = (decimal)1.00;

            //row06: everything
            var r06 = GetZakupWierszTemplate();
            r06.K43 = r06.K44 = r06.K45 = r06.K46 = r06.K47 = r06.K48 = r06.K49 = r06.K50 = (decimal)1.01;

            zakupy.Add(r01);
            zakupy.Add(r02);
            zakupy.Add(r03);
            zakupy.Add(r04);
            zakupy.Add(r05);
            zakupy.Add(r06);
        }

        private static SprzedazWiersz GetSprzedazWierszTemplate(bool defineDataSprzedazy = true)
        {
            var s = new SprzedazWiersz
            {
                NrKontrahenta = "7766756174",
                NazwaKontrahenta = "Jakaś tam firemka s.a.",
                AdresKontrahenta = "ul. Łazarska 67, 34-123 Pcim dolny",
                DowodSprzedazy = "45/63456",
                DataWystawienia = new DateTime(2020, 1, 15)
            };

            if(defineDataSprzedazy)
                s.DataSprzedazy = new DateTime(2020, 1, 16);

            return s;
        }

        private static ZakupWiersz GetZakupWierszTemplate(bool defineDataWplywu = true)
        {
            var s = new ZakupWiersz
            {
                NrDostawcy = "7766756174",
                NazwaDostawcy = "Jakaś tam firemka s.a.",
                AdresDostawcy = "ul. Łazarska 67, 34-123 Pcim dolny",
                DowodZakupu = "45/63456",
                DataZakupu = new DateTime(2020, 1, 15)
            };

            if (defineDataWplywu)
                s.DataWplywu = new DateTime(2020, 1, 16);

            return s;
        }
    }
}
