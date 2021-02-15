namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Fa2;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkFa2ViewModelTests
    {
        [TestMethod("JPK_FA(2)")]
        [Description("Checks if JPK_FA(2) files are generated properly.")]
        public async Task JpkFa2FilesAreGeneratedProperly()
        {
            var vm = new JpkFa2ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);
            AppendStawkiPodatku(jpk);

            AppendJpkFaktury(jpk);
            AppendFakturaWiersze(jpk);

            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual("TestFiles/jpk_fa2_valid.xml", actualFullFilePath);

            File.Delete(actualFullFilePath);
        }

        private static void AppendNaglowekAndPodmiot(Jpk jpk)
        {
            jpk.Naglowek.DataWytworzeniaJpk = new DateTime(2020, 1, 31);
            jpk.Naglowek.DataOd = new DateTime(2020, 1, 1);
            jpk.Naglowek.DataDo = new DateTime(2020, 1, 31);
            jpk.Naglowek.DomyslnyKodWaluty = Models.Common.KodWalutyV30.PLN;
            jpk.Naglowek.KodUrzedu = Models.Common.KodUsV50.Us2434;

            jpk.Podmiot.AdresPodmiotu = TestHelper.GetAdresPolskiV50();
            jpk.Podmiot.IdentyfikatorPodmiotu = TestHelper.GetIdentyfikatorOsobyNiefizycznejV50();
        }

        private static void AppendStawkiPodatku(Jpk jpk)
        {
            jpk.StawkiPodatku = new StawkiPodatku();
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

            //row05: with P13_1, P14_1, P13_2, P14_2, P13_3, P14_3, P13_4, P14_4, P13_5, P14_5
            var r05 = GetJpkFakturaTemplate();
            r05.P18 = true;
            r05.P106E2 = true;

            //row06: with P13_6, P13_7
            var r06 = GetJpkFakturaTemplate();
            r06.P13_6 = (decimal)3456.33;
            r06.P13_7 = (decimal)6345.82;

            //row07: with P19A
            var r07 = GetJpkFakturaTemplate();
            r07.P19 = true;
            r07.P19A = "jakaś tam ustawa";

            //row08: with P19B
            var r08 = GetJpkFakturaTemplate();
            r08.P19 = true;
            r08.P19B = "jakiś tam przepis dyrektywy";

            //row09: with P19C
            var r09 = GetJpkFakturaTemplate();
            r09.P19 = true;
            r09.P19C = "jakaś tam podstawa prawna";

            //row10: with P20A, P20B
            var r10 = GetJpkFakturaTemplate();
            r10.P20 = true;
            r10.P20A = "Biuro komornika w Tczewie";
            r10.P20B = "Biuro komornika w Rawiczu";

            //row11: with P21A, P21B, P21C
            var r11 = GetJpkFakturaTemplate();
            r11.P21 = true;
            r11.P21A = "Biuro komornika w Tczewie";
            r11.P21B = "ul. Legionów 1/56, 22-632 Tczew";
            r11.P21C = "1129685988";

            //row12: with P22A
            var r12 = GetJpkFakturaTemplate();
            r12.P22A = new DateTime(1999, 05, 26);

            //row13: with P22A, P22B
            var r13 = GetJpkFakturaTemplate();
            r13.P22A = new DateTime(1999, 05, 26);
            r13.P22B = "150000 km";

            //row14: with P22A, P22C
            var r14 = GetJpkFakturaTemplate();
            r14.P22A = new DateTime(1999, 05, 26);
            r14.P22C = "1200";

            //row15: with P106E3A
            var r15 = GetJpkFakturaTemplate();
            r15.P106E3 = true;
            r15.P106E3A = "procedura marży - dzieła sztuki";

            //row16: with PrzyczynaKorekty, NrFaKorygowanejSpecified
            var r16 = GetJpkFakturaTemplate();
            r16.RodzajFaktury = RodzajFaktury.Korekta;
            r16.PrzyczynaKorekty = "błąd";
            r16.NrFaKorygowanej = "543/732456";

            //row17: with PrzyczynaKorekty, NrFaKorygowanejSpecified, OkresFaKorygowanej
            var r17 = GetJpkFakturaTemplate();
            r17.RodzajFaktury = RodzajFaktury.Korekta;
            r17.PrzyczynaKorekty = "błąd";
            r17.NrFaKorygowanej = "543/732456";
            r17.OkresFaKorygowanej = "styczeń 2019";

            //row18: with ZalZaplata, ZalPodatek
            var r18 = GetJpkFakturaTemplate();
            r18.RodzajFaktury = RodzajFaktury.Zal;
            r18.ZalZaplata = (decimal)1341.65;
            r18.ZalPodatek = (decimal)255.74;

            //row19: with all specified fields
            var r19 = GetJpkFakturaTemplate();
            r19.P3A = "Zenon Jackowiak";
            r19.P3B = "ul. Cicha 14, 52-125 Marciszów";
            r19.P4A = Models.Common.KodKrajuUeV30.CZ;
            r19.P4B = "5252632498";
            r19.P5A = Models.Common.KodKrajuUeV30.BG;
            r19.P5B = "5357411057";
            r19.P6 = new DateTime(2020, 01, 30);
            r19.P18 = true;
            r19.P13_5 = (decimal)5435.85;
            r19.P13_6 = (decimal)3456.33;
            r19.P13_7 = (decimal)6345.82;
            r19.P19 = true;
            r19.P19A = "jakaś tam ustawa";
            r19.P19B = "jakiś tam przepis dyrektywy";
            r19.P19C = "jakaś tam podstawa prawna";
            r19.P20 = true;
            r19.P20A = "Biuro komornika w Tczewie";
            r19.P20B = "Biuro komornika w Rawiczu";
            r19.P21 = true;
            r19.P21A = "Biuro komornika w Tczewie";
            r19.P21B = "ul. Legionów 1/56, 22-632 Tczew";
            r19.P21C = "1129685988";
            r19.P22A = new DateTime(1999, 05, 26);
            r19.P22B = "150000 km";
            r19.P22C = "1200";
            r19.P106E2 = true;
            r19.P106E3 = true;
            r19.P106E3A = "procedura marży - dzieła sztuki";
            r19.RodzajFaktury = RodzajFaktury.Korekta;
            r19.PrzyczynaKorekty = "błąd";
            r19.NrFaKorygowanej = "543/732456";
            r19.OkresFaKorygowanej = "styczeń 2019";

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
            r07.P12 = StawkaPodatku.N08;

            var r08 = GetFakturaWierszTemplate();
            r08.P7 = "Zwykły towar";
            r08.P8A = "kg";
            r08.P8B = (decimal)2000.00;
            r08.P9A = (decimal)1900.03;
            r08.P9B = (decimal)2000.04;
            r08.P10 = (decimal)2345.85;
            r08.P11 = (decimal)2352.74;
            r08.P11A = (decimal)2345.84;
            r08.P12 = StawkaPodatku.N08;

            fw.Add(r01);
            fw.Add(r02);
            fw.Add(r03);
            fw.Add(r04);
            fw.Add(r05);
            fw.Add(r06);
            fw.Add(r07);
            fw.Add(r08);
        }

        private static JpkFaktura GetJpkFakturaTemplate()
        {
            var fa = new JpkFaktura
            {
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
    }
}
