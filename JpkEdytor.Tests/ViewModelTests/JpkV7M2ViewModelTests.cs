namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.V72.Common;
    using JpkEdytor.Models.V72.V7M;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkV7M2ViewModelTests
    {
        [DataTestMethod]
        [DataRow(false, false, false, false, "TestFiles/jpk_v7m2_valid_empty_osoba_niefizyczna.xml", DisplayName = "JPK_V7M(2) - Empty; osoba niefizyczna")]
        [DataRow(true, false, false, false, "TestFiles/jpk_v7m2_valid_empty_osoba_fizyczna.xml", DisplayName = "JPK_V7M(2) - Empty; osoba fizyczna")]
        [DataRow(false, true, false, false, "TestFiles/jpk_v7m2_valid_deklaracja_osoba_niefizyczna.xml", DisplayName = "JPK_V7M(2) - With deklaracja; osoba niefizyczna")]
        [DataRow(true, true, false, false, "TestFiles/jpk_v7m2_valid_deklaracja_osoba_fizyczna.xml", DisplayName = "JPK_V7M(2) - With deklaracja; osoba fizyczna")]
        [DataRow(false, false, true, false, "TestFiles/jpk_v7m2_valid_sprzedaz_osoba_niefizyczna.xml", DisplayName = "JPK_V7M(2) - With sprzedaz; osoba niefizyczna")]
        [DataRow(true, false, true, false, "TestFiles/jpk_v7m2_valid_sprzedaz_osoba_fizyczna.xml", DisplayName = "JPK_V7M(2) - With sprzedaz; osoba fizyczna")]
        [DataRow(false, true, true, false, "TestFiles/jpk_v7m2_valid_deklaracja_sprzedaz_osoba_niefizyczna.xml", DisplayName = "JPK_V7M(2) - With deklaracja, sprzedaz; osoba niefizyczna")]
        [DataRow(true, true, true, false, "TestFiles/jpk_v7m2_valid_deklaracja_sprzedaz_osoba_fizyczna.xml", DisplayName = "JPK_V7M(2) - With deklaracja, sprzedaz; osoba fizyczna")]
        [DataRow(false, false, false, true, "TestFiles/jpk_v7m2_valid_zakupy_osoba_niefizyczna.xml", DisplayName = "JPK_V7M(2) - With zakupy; osoba niefizyczna")]
        [DataRow(true, false, false, true, "TestFiles/jpk_v7m2_valid_zakupy_osoba_fizyczna.xml", DisplayName = "JPK_V7M(2) - With zakupy; osoba fizyczna")]
        [DataRow(false, true, false, true, "TestFiles/jpk_v7m2_valid_deklaracja_zakupy_osoba_niefizyczna.xml", DisplayName = "JPK_V7M(2) - With deklaracja, zakupy; osoba niefizyczna")]
        [DataRow(true, true, false, true, "TestFiles/jpk_v7m2_valid_deklaracja_zakupy_osoba_fizyczna.xml", DisplayName = "JPK_V7M(2) - With deklaracja, zakupy; osoba fizyczna")]
        [DataRow(false, false, true, true, "TestFiles/jpk_v7m2_valid_sprzedaz_zakupy_osoba_niefizyczna.xml", DisplayName = "JPK_V7M(2) - With sprzedaz, zakupy; osoba niefizyczna")]
        [DataRow(true, false, true, true, "TestFiles/jpk_v7m2_valid_sprzedaz_zakupy_osoba_fizyczna.xml", DisplayName = "JPK_V7M(2) - With sprzedaz, zakupy; osoba fizyczna")]
        [DataRow(false, true, true, true, "TestFiles/jpk_v7m2_valid_deklaracja_sprzedaz_zakupy_osoba_niefizyczna.xml", DisplayName = "JPK_V7M(2) - With deklaracja, sprzedaz, zakupy; osoba niefizyczna")]
        [DataRow(true, true, true, true, "TestFiles/jpk_v7m2_valid_deklaracja_sprzedaz_zakupy_osoba_fizyczna.xml", DisplayName = "JPK_V7M(2) - With deklaracja, sprzedaz, zakupy; osoba fizyczna")]
        [Description("Checks if JPK_V7M(2) files are generated properly.")]
        public async Task JpkV7M2FilesAreGeneratedProperly(bool osobaFizyczna, bool appendDeklaracja, bool appendSprzedaz, bool appendZakupy, string expectedFullFilePath)
        {
            var vm = new JpkV7M2ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowek(jpk);
            AppendPodmiot(jpk, osobaFizyczna);

            if (appendDeklaracja) AppendDeklaracja(jpk);
            if (appendSprzedaz) AppendSprzedaz(jpk);
            if (appendZakupy) AppendZakupy(jpk);

            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual(expectedFullFilePath, actualFullFilePath);

            File.Delete(actualFullFilePath);
        }

        private void AppendNaglowek(Jpk jpk)
        {
            jpk.Naglowek.DataWytworzeniaJpk = new DateTime(2022, 2, 21);
            jpk.Naglowek.NazwaSystemu = "JpkEdytor";
            jpk.Naglowek.Rok = "2022";
            jpk.Naglowek.Miesiac = 2;
        }

        private void AppendPodmiot(Jpk jpk, bool osobaFizyczna)
        {
            if (osobaFizyczna)
                jpk.Podmiot.Item = GetPodmiotOsobaFizyczna();
            else
                jpk.Podmiot.Item = GetPodmiotOsobaNiefizyczna();
        }

        private void AppendDeklaracja(Jpk jpk)
        {
            if (jpk.Deklaracja == null)
                jpk.Deklaracja = new Deklaracja();

            jpk.Deklaracja.PozycjeSzczegolowe.P38 = "5133";
            jpk.Deklaracja.PozycjeSzczegolowe.P51 = "124";
        }

        private void AppendSprzedaz(Jpk jpk)
        {
            var sprzedazWiersze = jpk.Ewidencja.SprzedazWiersze;

            //row01: no specified fields
            var r01 = GetSprzedazWierszTemplate();

            //row02: with KodKrajuNadaniaTin, DataSprzedazy, TypDokumentu
            var r02 = GetSprzedazWierszTemplate();
            r02.KodKrajuNadaniaTin = "PL";
            r02.DataSprzedazy = new DateTime(2020, 4, 25);
            r02.TypDokumentu = TypDokumentu.Ro;

            //row03: with odd GTU's
            var r03 = GetSprzedazWierszTemplate();
            r03.Gtu01 = 1;
            r03.Gtu03 = 1;
            r03.Gtu05 = 1;
            r03.Gtu07 = 1;
            r03.Gtu09 = 1;
            r03.Gtu11 = 1;
            r03.Gtu13 = 1;

            //row04: with even GTU's
            var r04 = GetSprzedazWierszTemplate();
            r04.Gtu02 = 1;
            r04.Gtu04 = 1;
            r04.Gtu06 = 1;
            r04.Gtu08 = 1;
            r04.Gtu10 = 1;
            r04.Gtu12 = 1;

            //row05: with WstoEe, Ied, Tp
            var r05 = GetSprzedazWierszTemplate();
            r05.WstoEe = 1;
            r05.Ied = 1;
            r05.Tp = 1;

            //row06: with TtWnt, TtD, MrT
            var r06 = GetSprzedazWierszTemplate();
            r06.TtWnt = 1;
            r06.TtD = 1;
            r06.MrT = 1;

            //row07: with MrUz, I42, I63
            var r07 = GetSprzedazWierszTemplate();
            r07.MrUz = 1;
            r07.I42 = 1;
            r07.I63 = 1;

            //row08: with BSpv, BSpvDostawa, BMpvProwizja
            var r08 = GetSprzedazWierszTemplate();
            r08.BSpv = 1;
            r08.BSpvDostawa = 1;
            r08.BMpvProwizja = 1;

            //row09: with KorektaPodstawyOpodatkowania, DataKorekty
            var r09 = GetSprzedazWierszTemplate();
            r09.KorektaPodstawyOpodatkowania = 1;
            r09.DataKorekty = new DateTime(2022, 4, 2);

            //row10: with K10
            var r10 = GetSprzedazWierszTemplate();
            r10.K10 = (decimal)150.10;

            //row11: with K11
            var r11 = GetSprzedazWierszTemplate();
            r11.K11 = (decimal)150.11;

            //row12: with K12
            var r12 = GetSprzedazWierszTemplate();
            r12.K12 = (decimal)150.12;

            //row13: with K13
            var r13 = GetSprzedazWierszTemplate();
            r13.K13 = (decimal)150.13;

            //row14: with K14
            var r14 = GetSprzedazWierszTemplate();
            r14.K14 = (decimal)150.14;

            //row15: with K15, K16
            var r15 = GetSprzedazWierszTemplate();
            r15.K15 = (decimal)150.15;

            //row16: with K15, K16
            var r16 = GetSprzedazWierszTemplate();
            r16.K16 = (decimal)150.16;

            //row17: with K17, K18
            var r17 = GetSprzedazWierszTemplate();
            r17.K17 = (decimal)150.17;

            //row18: with K17, K18
            var r18 = GetSprzedazWierszTemplate();
            r18.K18 = (decimal)150.18;

            //row19: with K19, K20
            var r19 = GetSprzedazWierszTemplate();
            r19.K19 = (decimal)150.19;

            //row20: with K19, K20
            var r20 = GetSprzedazWierszTemplate();
            r20.K20 = (decimal)150.20;

            //row21: with K21
            var r21 = GetSprzedazWierszTemplate();
            r21.K21 = (decimal)150.21;

            //row22: with K22
            var r22 = GetSprzedazWierszTemplate();
            r22.K22 = (decimal)150.22;

            //row23: with K23, K24
            var r23 = GetSprzedazWierszTemplate();
            r23.K23 = (decimal)150.23;

            //row24: with K23, K24
            var r24 = GetSprzedazWierszTemplate();
            r24.K24 = (decimal)150.24;

            //row25: with K25, K26
            var r25 = GetSprzedazWierszTemplate();
            r25.K25 = (decimal)150.25;

            //row26: with K25, K26
            var r26 = GetSprzedazWierszTemplate();
            r26.K26 = (decimal)150.26;

            //row27: with K27, K28
            var r27 = GetSprzedazWierszTemplate();
            r27.K27 = (decimal)150.27;

            //row28: with K27, K28
            var r28 = GetSprzedazWierszTemplate();
            r28.K28 = (decimal)150.28;

            //row29: with K29, K30
            var r29 = GetSprzedazWierszTemplate();
            r29.K29 = (decimal)150.29;

            //row30: with K29, K30
            var r30 = GetSprzedazWierszTemplate();
            r30.K30 = (decimal)150.30;

            //row31: with K31, K32
            var r31 = GetSprzedazWierszTemplate();
            r31.K31 = (decimal)150.31;

            //row32: with K31, K32
            var r32 = GetSprzedazWierszTemplate();
            r32.K32 = (decimal)150.32;

            //row33: with K33
            var r33 = GetSprzedazWierszTemplate();
            r33.K33 = (decimal)150.33;

            //row34: with K34
            var r34 = GetSprzedazWierszTemplate();
            r34.K34 = (decimal)150.34;

            //row35: with K35
            var r35 = GetSprzedazWierszTemplate();
            r35.K35 = (decimal)150.35;

            //row36: with K36
            var r36 = GetSprzedazWierszTemplate();
            r36.K36 = (decimal)150.36;

            //row37: with SprzedazVatMarza
            var r37 = GetSprzedazWierszTemplate();
            r37.SprzedazVatMarza = (decimal)150.37;

            //row38: with all specified fields
            var r38 = GetSprzedazWierszTemplate();
            r38.KodKrajuNadaniaTin = "PL";
            r38.DataSprzedazy = new DateTime(2020, 4, 25);
            r38.TypDokumentu = TypDokumentu.Ro;
            r38.Gtu01 = 1;
            r38.Gtu02 = 1;
            r38.Gtu03 = 1;
            r38.Gtu04 = 1;
            r38.Gtu05 = 1;
            r38.Gtu06 = 1;
            r38.Gtu07 = 1;
            r38.Gtu08 = 1;
            r38.Gtu09 = 1;
            r38.Gtu10 = 1;
            r38.Gtu11 = 1;
            r38.Gtu12 = 1;
            r38.Gtu13 = 1;
            r38.WstoEe = 1;
            r38.Ied = 1;
            r38.Tp = 1;
            r38.TtWnt = 1;
            r38.TtD = 1;
            r38.MrT = 1;
            r38.MrUz = 1;
            r38.I42 = 1;
            r38.I63 = 1;
            r38.BSpv = 1;
            r38.BSpvDostawa = 1;
            r38.BMpvProwizja = 1;
            r38.KorektaPodstawyOpodatkowania = 1;
            r38.DataKorekty = new DateTime(2022, 3, 26);
            r38.K10 = (decimal)123.45;
            r38.K11 = (decimal)123.45;
            r38.K12 = (decimal)123.45;
            r38.K13 = (decimal)123.45;
            r38.K14 = (decimal)123.45;
            r38.K15 = (decimal)123.45;
            r38.K16 = (decimal)123.45;
            r38.K17 = (decimal)123.45;
            r38.K18 = (decimal)123.45;
            r38.K19 = (decimal)123.45;
            r38.K20 = (decimal)123.45;
            r38.K21 = (decimal)123.45;
            r38.K22 = (decimal)123.45;
            r38.K23 = (decimal)123.45;
            r38.K24 = (decimal)123.45;
            r38.K25 = (decimal)123.45;
            r38.K26 = (decimal)123.45;
            r38.K27 = (decimal)123.45;
            r38.K28 = (decimal)123.45;
            r38.K29 = (decimal)123.45;
            r38.K30 = (decimal)123.45;
            r38.K31 = (decimal)123.45;
            r38.K32 = (decimal)123.45;
            r38.K33 = (decimal)123.45;
            r38.K34 = (decimal)123.45;
            r38.K35 = (decimal)123.45;
            r38.K36 = (decimal)123.45;
            r38.SprzedazVatMarza = (decimal)123.45;

            sprzedazWiersze.Add(r01);
            sprzedazWiersze.Add(r02);
            sprzedazWiersze.Add(r03);
            sprzedazWiersze.Add(r04);
            sprzedazWiersze.Add(r05);
            sprzedazWiersze.Add(r06);
            sprzedazWiersze.Add(r07);
            sprzedazWiersze.Add(r08);
            sprzedazWiersze.Add(r09);
            sprzedazWiersze.Add(r10);
            sprzedazWiersze.Add(r11);
            sprzedazWiersze.Add(r12);
            sprzedazWiersze.Add(r13);
            sprzedazWiersze.Add(r14);
            sprzedazWiersze.Add(r15);
            sprzedazWiersze.Add(r16);
            sprzedazWiersze.Add(r17);
            sprzedazWiersze.Add(r18);
            sprzedazWiersze.Add(r19);
            sprzedazWiersze.Add(r20);
            sprzedazWiersze.Add(r21);
            sprzedazWiersze.Add(r22);
            sprzedazWiersze.Add(r23);
            sprzedazWiersze.Add(r24);
            sprzedazWiersze.Add(r25);
            sprzedazWiersze.Add(r26);
            sprzedazWiersze.Add(r27);
            sprzedazWiersze.Add(r28);
            sprzedazWiersze.Add(r29);
            sprzedazWiersze.Add(r30);
            sprzedazWiersze.Add(r31);
            sprzedazWiersze.Add(r32);
            sprzedazWiersze.Add(r33);
            sprzedazWiersze.Add(r34);
            sprzedazWiersze.Add(r35);
            sprzedazWiersze.Add(r36);
            sprzedazWiersze.Add(r37);
            sprzedazWiersze.Add(r38);
        }

        private void AppendZakupy(Jpk jpk)
        {
            var zakupWiersze = jpk.Ewidencja.ZakupWiersze;

            //row01: no specified fields
            var r01 = GetZakupWierszTemplate();

            //row02: with KodKrajuNadaniaTin
            var r02 = GetZakupWierszTemplate();
            r02.KodKrajuNadaniaTin = "PL";

            //row03: with DataWplywu
            var r03 = GetZakupWierszTemplate();
            r03.DataWplywu = new DateTime(2022, 4, 28);

            //row04: with DokumentZakupu
            var r04 = GetZakupWierszTemplate();
            r04.DokumentZakupu = DokumentZakupu.VatRr;

            //row05: with Mpp
            var r05 = GetZakupWierszTemplate();
            r05.Imp = 1;

            //row06: with K40, K41
            var r06 = GetZakupWierszTemplate();
            r06.K40 = (decimal)167.07;

            //row07: with K40, K41
            var r07 = GetZakupWierszTemplate();
            r07.K41 = (decimal)167.08;

            //row08: with K42, K43
            var r08 = GetZakupWierszTemplate();
            r08.K42 = (decimal)167.09;

            //row09: with K42, K43
            var r09 = GetZakupWierszTemplate();
            r09.K43 = (decimal)167.10;

            //row10: with K44
            var r10 = GetZakupWierszTemplate();
            r10.K44 = (decimal)167.11;

            //row11: with K45
            var r11 = GetZakupWierszTemplate();
            r11.K45 = (decimal)167.12;

            //row12: with K46
            var r12 = GetZakupWierszTemplate();
            r12.K46 = (decimal)167.13;

            //row13: with ZakupVatMarza
            var r13 = GetZakupWierszTemplate();
            r13.K47 = (decimal)167.14;

            //row14: with K47
            var r14 = GetZakupWierszTemplate();
            r14.ZakupVatMarza = (decimal)167.15;

            //row15: with all specified fields
            var r15 = GetZakupWierszTemplate();
            r15.KodKrajuNadaniaTin = "PL";
            r15.DataWplywu = new DateTime(2022, 4, 28);
            r15.DokumentZakupu = DokumentZakupu.VatRr;
            r15.Imp = 1;
            r15.K40 = (decimal)167.16;
            r15.K41 = (decimal)167.16;
            r15.K42 = (decimal)167.16;
            r15.K43 = (decimal)167.16;
            r15.K44 = (decimal)167.16;
            r15.K45 = (decimal)167.16;
            r15.K46 = (decimal)167.16;
            r15.K47 = (decimal)167.16;
            r15.ZakupVatMarza = (decimal)167.16;

            zakupWiersze.Add(r01);
            zakupWiersze.Add(r02);
            zakupWiersze.Add(r03);
            zakupWiersze.Add(r04);
            zakupWiersze.Add(r05);
            zakupWiersze.Add(r06);
            zakupWiersze.Add(r07);
            zakupWiersze.Add(r08);
            zakupWiersze.Add(r09);
            zakupWiersze.Add(r10);
            zakupWiersze.Add(r11);
            zakupWiersze.Add(r12);
            zakupWiersze.Add(r13);
            zakupWiersze.Add(r14);
            zakupWiersze.Add(r15);
        }

        private EwidencjaSprzedazWiersz GetSprzedazWierszTemplate()
        {
            var sprzedazWiersz = new EwidencjaSprzedazWiersz
            {
                NrKontrahenta = "9527765432",
                NazwaKontrahenta = "Fabryka piwa s.a.",
                DowodSprzedazy = "523/67272",
                DataWystawienia = new DateTime(2022, 4, 23),
            };

            return sprzedazWiersz;
        }

        private EwidencjaZakupWiersz GetZakupWierszTemplate()
        {
            var zakupWiersz = new EwidencjaZakupWiersz
            {
                NrDostawcy = "3897424335",
                NazwaDostawcy = "Magazyn chmielu s.c.",
                DowodZakupu = "386/52672",
                DataZakupu = new DateTime(2022, 5, 17),
            };

            return zakupWiersz;
        }

        private PodmiotDowolnyBezAdresuOsobaFizyczna GetPodmiotOsobaFizyczna(bool defineTelefon = true)
        {
            var podmiot = new PodmiotDowolnyBezAdresuOsobaFizyczna
            {
                Nip = "7018631981",
                ImiePierwsze = "Jan",
                Nazwisko = "Kowaski",
                DataUrodzenia = new DateTime(1979, 8, 13),
                Email = "jan.kowalski@mail.com,"

            };

            if (defineTelefon)
                podmiot.Telefon = "566871429";

            return podmiot;
        }

        private PodmiotDowolnyBezAdresuOsobaNiefizyczna GetPodmiotOsobaNiefizyczna(bool defineTelefon = true)
        {
            var podmiot = new PodmiotDowolnyBezAdresuOsobaNiefizyczna
            {
                Nip = "7018631981",
                PelnaNazwa = "Firma rodzinna s.c.",
                Email = "jan.kowalski@mail.com,"
            };

            if (defineTelefon)
                podmiot.Telefon = "566871429";

            return podmiot;
        }
    }
}
