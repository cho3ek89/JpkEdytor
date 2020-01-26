namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.FaRr1;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkFaRr1ViewModelTests
    {
        [DataTestMethod]
        [DataRow(false, "TestFiles/jpk_farr1_valid_without_oswiadczenia.xml", DisplayName = "Without Oswiadczenia")]
        [DataRow(true, "TestFiles/jpk_farr1_valid_with_oswiadczenia.xml", DisplayName = "With Oswiadczenia")]
        [Description("Checks if jpk_farr1 files are generated properly.")]
        public async Task JpkFaRr1FilesAreGeneratedProperly(bool appendOswiadczenia, string expectedFullFilePath)
        {
            var vm = new JpkFaRr1ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);

            AppendFakturyRr(jpk);
            AppendFakturyRrWiersze(jpk);
            if (appendOswiadczenia) AppendOswiadczenia(jpk);

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
            jpk.Naglowek.KodUrzedu = Models.Common.KodUsV50.Us2434;

            jpk.Podmiot.AdresPodmiotu = TestHelper.GetAdresPolski1V50();
            jpk.Podmiot.IdentyfikatorPodmiotu = TestHelper.GetIdentyfikatorOsobyNiefizycznej1V50();
        }

        private static void AppendFakturyRr(Jpk jpk)
        {
            var faRr = jpk.FakturaRr;

            //row01: no specified fields
            var r01 = GetFakturaRrTemplate();

            //row02: with PrzyczynaKorekty, NrFaKorygowanej
            var r02 = GetFakturaRrTemplate();
            r02.RodzajFaktury = RodzajFaktury.Korekta;
            r02.PrzyczynaKorekty = "błąd";
            r02.NrFaKorygowanej = "2441/515";

            //row03: with PrzyczynaKorekty, NrFaKorygowanej
            var r03 = GetFakturaRrTemplate();
            r03.RodzajFaktury = RodzajFaktury.Korekta;
            r03.PrzyczynaKorekty = "błąd";
            r03.NrFaKorygowanej = "2441/515";
            r03.OkresFaKorygowanej = "styczeń";

            //row04: with Dokument
            var r04 = GetFakturaRrTemplate();
            r04.Dokument = "23542/62411642";

            //row05: with all specified fields
            var r05 = GetFakturaRrTemplate();
            r05.RodzajFaktury = RodzajFaktury.Korekta;
            r05.PrzyczynaKorekty = "błąd";
            r05.NrFaKorygowanej = "2441/515";
            r05.OkresFaKorygowanej = "styczeń";
            r05.Dokument = "23542/62411642";

            faRr.Add(r01);
            faRr.Add(r02);
            faRr.Add(r03);
            faRr.Add(r04);
            faRr.Add(r05);
        }

        private static void AppendFakturyRrWiersze(Jpk jpk)
        {
            var faRrW = jpk.FakturaRrWiersz;

            var r01 = GetFakturaRrWierszTemplate();

            faRrW.Add(r01);
        }

        private static void AppendOswiadczenia(Jpk jpk)
        {
            var osw = jpk.Oswiadczenie;

            var r01 = GetOswiadczenieTemplate();

            osw.Add(r01);
        }

        private static FakturaRr GetFakturaRrTemplate()
        {
            var fa = new FakturaRr
            {
                P1A = "Zenon Piskorski",
                P1B = "ul. Cicha 5, 56-756 Młode Rumunki",
                P1C = "Zbigniew Marcinkowski",
                P1D = "ul. Cicha 2, 56-756 Młode Rumunki",
                P2A = "5244331440",
                P2B = "3553405359",
                P3A = new Podpis
                    {
                        NumerSeryjny = "524234567",
                        Posiadacz = "Zenon Piskorski",
                        Wystawca = "CERT factory s.c."
                    },
                P3B = new Podpis
                    {
                        NumerSeryjny = "635623463",
                        Posiadacz = "Zbigniew Marcinkowski",
                        Wystawca = "CERT union s.a."
                    },
                P4A = new DateTime(2020, 1, 6),
                P4B = new DateTime(2020, 1, 5),
                P4C1 = "14123/653",
                P11_1 = (decimal)41451.53,
                P11_2 = (decimal)252.74,
                P12_1 = (decimal)525.65,
                P12_2 = "pięćset dwadzieścia pięć złotych i sześćdziesiąt pięć groszy",
                P116_3 = true,
                RodzajFaktury = RodzajFaktury.Vat
            };

            return fa;
        }

        private static FakturaRrWiersz GetFakturaRrWierszTemplate()
        {
            var fa = new FakturaRrWiersz
            {
                P4C2 = "14123/653",
                P5 = "pszenica",
                P6A = "kg",
                P6B = (decimal)23542.51,
                P6C = "pierwsza",
                P7 = (decimal)34.65,
                P8 = (decimal)634.74,
                P9 = (decimal)63.85,
                P10 = (decimal)6354.84
            };

            return fa;
        }

        private static Oswiadczenie GetOswiadczenieTemplate()
        {
            var o = new Oswiadczenie
            {
                P1A2 = "Zenon Piskorski",
                P1B2 = "ul. Cicha 5, 56-756 Młode Rumunki",
                P1C2 = "Zbigniew Marcinkowski",
                P1D2 = "ul. Cicha 2, 56-756 Młode Rumunki",
                P2A2 = "5244331440",
                P2B2 = "3553405359",
                P116_4_1 = new DateTime(2020, 1, 6),
                P116_4_2 = "pszenica",
                P116_4_3 = new DateTime(2020, 1, 5),
                P3A2 = new Podpis
                {
                    NumerSeryjny = "524234567",
                    Posiadacz = "Zenon Piskorski",
                    Wystawca = "CERT factory s.c."
                }
            };

            return o;
        }
    }
}
