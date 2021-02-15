namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Fa3;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkFa3ViewModelTests
    {
        [DataTestMethod]
        [DataRow(false, true, "TestFiles/jpk_fa3_valid_with_zamowienia_foreign_address.xml", DisplayName = "JPK_FA(3) - With Zamowienia, foreign address")]
        [DataRow(true, true, "TestFiles/jpk_fa3_valid_with_zamowienia_polish_address.xml", DisplayName = "JPK_FA(3) - With Zamowienia, polish address")]
        [DataRow(false, false, "TestFiles/jpk_fa3_valid_without_zamowienia_foreign_address.xml", DisplayName = "JPK_FA(3) - Without Zamowienia, foreign address")]
        [DataRow(true, false, "TestFiles/jpk_fa3_valid_without_zamowienia_polish_address.xml", DisplayName = "JPK_FA(3) - Without Zamowienia, polish address")]
        [Description("Checks if JPK_FA(3) files are generated properly.")]
        public async Task JpkFa3FilesAreGeneratedProperly(bool useAdresPolski, bool appendZamowienia, string expectedFullFilePath)
        {
            var vm = new JpkFa3ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk, useAdresPolski);

            AppendJpkFaktury(jpk);
            AppendFakturaWiersze(jpk);
            if (appendZamowienia) AppendZamowienia(jpk);

            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual(expectedFullFilePath, actualFullFilePath);

            File.Delete(actualFullFilePath);
        }

        private static void AppendNaglowekAndPodmiot(Jpk jpk, bool useAdresPolski = true)
        {
            jpk.Naglowek.DataWytworzeniaJpk = new DateTime(2020, 1, 31);
            jpk.Naglowek.DataOd = new DateTime(2020, 1, 1);
            jpk.Naglowek.DataDo = new DateTime(2020, 1, 31);
            jpk.Naglowek.KodUrzedu = Models.Common.KodUsV50.Us2434;

            if (useAdresPolski)
                jpk.Podmiot.Item = TestHelper.GetAdresPolski1V50();
            else
                jpk.Podmiot.Item = TestHelper.GetAdresZagranicznyV50();

            jpk.Podmiot.IdentyfikatorPodmiotu = TestHelper.GetIdentyfikatorOsobyNiefizycznej1V50();
        }

        private static void AppendJpkFaktury(Jpk jpk)
        {
            var fa = jpk.Faktura;

            //row01: no specified fields
            var r01 = GetJpkFakturaTemplate();
            r01.P19 = true;

            //row02: with P3A, P3B
            var r02 = GetJpkFakturaTemplate();
            r02.P3A = "Zenon Jackowiak";
            r02.P3B = "ul. Cicha 14, 52-125 Marciszów";

            //row03: with P4A, P4B
            var r03 = GetJpkFakturaTemplate();
            r03.P4A = Models.Common.KodKrajuUeV30.CZ;
            r03.P4B = "5252632498";

            //row04: with P5A, P5B, P6
            var r04 = GetJpkFakturaTemplate();
            r04.P5A = Models.Common.KodKrajuUeV30.BG;
            r04.P5B = "5357411057";
            r04.P6 = new DateTime(2020, 01, 30);

            //row05: with P13_1, P14_1, P13_2, P14_2, P13_3, P14_3, P13_4, P14_4
            var r05 = GetJpkFakturaTemplate();
            r05.P18 = true;
            r05.P106E2 = true;

            //row06: with P13_1, P14_1, P14_1W, P13_2, P14_2, P14_2W, P13_3, P14_3, P14_3W, P13_4, P14_4, P14_4W
            var r06 = GetJpkFakturaTemplate();
            r06.P18 = true;
            r06.P106E3 = true;
            r06.KodWaluty = Models.Common.KodWalutyV30.AFN;

            //row07: with P13_5, P13_6, P13_7
            var r07 = GetJpkFakturaTemplate();
            r07.P13_5 = (decimal)5435.85;
            r07.P13_6 = (decimal)3456.33;
            r07.P13_7 = (decimal)6345.82;

            //row08: with P19A
            var r08 = GetJpkFakturaTemplate();
            r08.P19 = true;
            r08.P19A = "jakaś tam ustawa";

            //row09: with P19B
            var r09 = GetJpkFakturaTemplate();
            r09.P19 = true;
            r09.P19B = "jakiś tam przepis dyrektywy";

            //row10: with P19C
            var r10 = GetJpkFakturaTemplate();
            r10.P19 = true;
            r10.P19C = "jakaś tam podstawa prawna";

            //row11: with P20A, P20B
            var r11 = GetJpkFakturaTemplate();
            r11.P20 = true;
            r11.P20A = "Biuro komornika w Tczewie";
            r11.P20B = "Biuro komornika w Rawiczu";

            //row12: with P21A, P21B, P21C
            var r12 = GetJpkFakturaTemplate();
            r12.P21 = true;
            r12.P21A = "Biuro komornika w Tczewie";
            r12.P21B = "ul. Legionów 1/56, 22-632 Tczew";
            r12.P21C = "1129685988";

            //row13: with P22A
            var r13 = GetJpkFakturaTemplate();
            r13.P22 = true;
            r13.P22A = new DateTime(1999, 05, 26);

            //row14: with P22A, P22B
            var r14 = GetJpkFakturaTemplate();
            r14.P22 = true;
            r14.P22A = new DateTime(1999, 05, 26);
            r14.P22B = "150000 km";

            //row15: with P22A, P22C
            var r15 = GetJpkFakturaTemplate();
            r15.P22 = true;
            r15.P22A = new DateTime(1999, 05, 26);
            r15.P22C = "1200";

            //row16: with P106E3A
            var r16 = GetJpkFakturaTemplate();
            r16.P106E3 = true;
            r16.P106E3A = "procedura marży - dzieła sztuki";

            //row17: with PrzyczynaKorekty, NrFaKorygowanejSpecified
            var r17 = GetJpkFakturaTemplate();
            r17.RodzajFaktury = RodzajFaktury.Korekta;
            r17.PrzyczynaKorekty = "błąd";
            r17.NrFaKorygowanej = "543/732456";

            //row18: with PrzyczynaKorekty, NrFaKorygowanejSpecified, OkresFaKorygowanej
            var r18 = GetJpkFakturaTemplate();
            r18.RodzajFaktury = RodzajFaktury.Korekta;
            r18.PrzyczynaKorekty = "błąd";
            r18.NrFaKorygowanej = "543/732456";
            r18.OkresFaKorygowanej = "styczeń 2019";

            //row19: with NrFaZaliczkowej
            var r19 = GetJpkFakturaTemplate();
            r19.RodzajFaktury = RodzajFaktury.Zal;
            r19.NrFaZaliczkowej = "235/7372";

            //row20: with all specified fields
            var r20 = GetJpkFakturaTemplate();
            r20.P3A = "Zenon Jackowiak";
            r20.P3B = "ul. Cicha 14, 52-125 Marciszów";
            r20.P4A = Models.Common.KodKrajuUeV30.CZ;
            r20.P4B = "5252632498";
            r20.P5A = Models.Common.KodKrajuUeV30.BG;
            r20.P5B = "5357411057";
            r20.P6 = new DateTime(2020, 01, 30);
            r20.P18 = true;
            r20.KodWaluty = Models.Common.KodWalutyV30.AFN;
            r20.P13_5 = (decimal)5435.85;
            r20.P13_6 = (decimal)3456.33;
            r20.P13_7 = (decimal)6345.82;
            r20.P19 = true;
            r20.P19A = "jakaś tam ustawa";
            r20.P19B = "jakiś tam przepis dyrektywy";
            r20.P19C = "jakaś tam podstawa prawna";
            r20.P20 = true;
            r20.P20A = "Biuro komornika w Tczewie";
            r20.P20B = "Biuro komornika w Rawiczu";
            r20.P21 = true;
            r20.P21A = "Biuro komornika w Tczewie";
            r20.P21B = "ul. Legionów 1/56, 22-632 Tczew";
            r20.P21C = "1129685988";
            r20.P22 = true;
            r20.P22A = new DateTime(1999, 05, 26);
            r20.P22B = "150000 km";
            r20.P22C = "1200";
            r20.P106E2 = true;
            r20.P106E3 = true;
            r20.P106E3A = "procedura marży - dzieła sztuki";
            r20.RodzajFaktury = RodzajFaktury.Korekta;
            r20.PrzyczynaKorekty = "błąd";
            r20.NrFaKorygowanej = "543/732456";
            r20.OkresFaKorygowanej = "styczeń 2019";

            fa.Add(r01);
            fa.Add(r02);
            fa.Add(r03);
            fa.Add(r04);
            fa.Add(r05);
            fa.Add(r06);
            fa.Add(r07);
            fa.Add(r08);
            fa.Add(r09);
            fa.Add(r10);
            fa.Add(r11);
            fa.Add(r12);
            fa.Add(r13);
            fa.Add(r14);
            fa.Add(r15);
            fa.Add(r16);
            fa.Add(r17);
            fa.Add(r18);
            fa.Add(r19);
            fa.Add(r20);
        }

        private static void AppendFakturaWiersze(Jpk jpk)
        {
            var fw = jpk.FakturaWiersz;

            //row01: with no specified fields
            var r01 = GetFakturaWierszTemplate();

            //row02: with P7
            var r02 = GetFakturaWierszTemplate();
            r02.P7 = "Zwykły towar";

            //row03: with P8A, P8B
            var r03 = GetFakturaWierszTemplate();
            r03.P8A = "kg";
            r03.P8B = (decimal)2000.00;

            //row04: with P9A, P9B
            var r04 = GetFakturaWierszTemplate();
            r04.P9A = (decimal)1900.03;
            r04.P9B = (decimal)2000.04;

            //row05: with P10
            var r05 = GetFakturaWierszTemplate();
            r05.P10 = (decimal)2345.85;

            //row06: with P11, P11A
            var r06 = GetFakturaWierszTemplate();
            r06.P11 = (decimal)2352.74;
            r06.P11A = (decimal)2345.84;

            //row07: with P12
            var r07 = GetFakturaWierszTemplate();
            r07.P12 = StawkaPodatkuFw.N08;

            var r08 = GetFakturaWierszTemplate();
            r08.P7 = "Zwykły towar";
            r08.P8A = "kg";
            r08.P8B = (decimal)2000.00;
            r08.P9A = (decimal)1900.03;
            r08.P9B = (decimal)2000.04;
            r08.P10 = (decimal)2345.85;
            r08.P11 = (decimal)2352.74;
            r08.P11A = (decimal)2345.84;
            r08.P12 = StawkaPodatkuFw.N08;

            fw.Add(r01);
            fw.Add(r02);
            fw.Add(r03);
            fw.Add(r04);
            fw.Add(r05);
            fw.Add(r06);
            fw.Add(r07);
            fw.Add(r08);
        }

        private static void AppendZamowienia(Jpk jpk)
        {
            var zamowienia = jpk.Zamowienie;

            var zam = new Zamowienie
            {
                P2AZ = "Piwa",
                WartoscZamowienia = (decimal)3.52
            };

            //row01: no specified fields
            var r01 = GetZamowienieWierszTemplate();

            //row02: with P7Z
            var r02 = GetZamowienieWierszTemplate();
            r02.P7Z = "Piwo";

            //row02: with P8AZ
            var r03 = GetZamowienieWierszTemplate();
            r03.P8AZ = "litr";

            //row04: with P8BZ
            var r04 = GetZamowienieWierszTemplate();
            r04.P8BZ = (decimal)524.50;

            //row05: with P9AZ
            var r05 = GetZamowienieWierszTemplate();
            r05.P9AZ = (decimal)3.52;

            //row06: with P11NettoZ
            var r06 = GetZamowienieWierszTemplate();
            r06.P11NettoZ = (decimal)3.12;

            //row07: with P11VatZ
            var r07 = GetZamowienieWierszTemplate();
            r07.P11VatZ = (decimal)0.40;

            //row08: with P12Z
            var r08 = GetZamowienieWierszTemplate();
            r08.P12Z = StawkaPodatkuZw.N08;

            //row09: with all specified fields
            var r09 = GetZamowienieWierszTemplate();
            r09.P7Z = "Piwo";
            r09.P8AZ = "litr";
            r09.P8BZ = (decimal)524.50;
            r09.P9AZ = (decimal)3.52;
            r09.P11NettoZ = (decimal)3.12;
            r09.P11VatZ = (decimal)0.40;
            r09.P12Z = StawkaPodatkuZw.N08;

            zam.ZamowienieWiersz.Add(r01);
            zam.ZamowienieWiersz.Add(r02);
            zam.ZamowienieWiersz.Add(r03);
            zam.ZamowienieWiersz.Add(r04);
            zam.ZamowienieWiersz.Add(r05);
            zam.ZamowienieWiersz.Add(r06);
            zam.ZamowienieWiersz.Add(r07);
            zam.ZamowienieWiersz.Add(r08);
            zam.ZamowienieWiersz.Add(r09);

            zamowienia.Add(zam);
            zamowienia.Add(zam);
        }

        private static JpkFaktura GetJpkFakturaTemplate()
        {
            var fa = new JpkFaktura
            {
                KodWaluty = Models.Common.KodWalutyV30.PLN,
                P1 = new DateTime(2020, 01, 26),
                P2A = "5234/234522",
                P3C = "Albert Wcisło",
                P3D = "ul. Łagiewnicka 14, 44-121 Łagiewniki",
                P15 = (decimal)1.01,
            };

            return fa;
        }

        private static FakturaWiersz GetFakturaWierszTemplate()
        {
            var fw = new FakturaWiersz
            {
                P2B = "5234/234522",
            };

            return fw;
        }

        private static ZamowienieWiersz GetZamowienieWierszTemplate()
        {
            var zw = new ZamowienieWiersz();

            return zw;
        }
    }
}
