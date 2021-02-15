namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Kr1;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkKr1ViewModelTests
    {
        [TestMethod("JPK_KR(1)")]
        [Description("Checks if JPK_KR(1) files are generated properly.")]
        public async Task JpkKr1FilesAreGeneratedProperly()
        {
            var vm = new JpkKr1ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);

            AppendZois(jpk);
            AppendDziennik(jpk);
            AppendKontoZapisy(jpk);

            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual("TestFiles/jpk_kr1_valid.xml", actualFullFilePath);

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

        private static void AppendZois(Jpk jpk)
        {
            var zois = jpk.Zois;

            //row01: no KodPodkategorii, no OpisPodkategorii
            var r01 = GetZoisTemplate();

            //row02: with KodPodkategorii, no OpisPodkategorii
            var r02 = GetZoisTemplate();
            r02.KodPodkategorii = "362/834724";

            //row03: no KodPodkategorii, with OpisPodkategorii
            var r03 = GetZoisTemplate();
            r03.KodPodkategorii = string.Empty;
            r03.OpisPodkategorii = "73457/236260";

            //row04: with KodPodkategorii, with OpisPodkategorii
            var r04 = GetZoisTemplate();
            r04.KodPodkategorii = "362/834724";
            r04.OpisPodkategorii = "73457/236260";

            zois.Add(r01);
            zois.Add(r02);
            zois.Add(r03);
            zois.Add(r04);
        }

        private static void AppendDziennik(Jpk jpk)
        {
            jpk.Dziennik.Add(GetDziennikTemplate());
            jpk.Dziennik.Add(GetDziennikTemplate());
        }

        private static void AppendKontoZapisy(Jpk jpk)
        {
            var kz = jpk.KontoZapis;

            //row01: no specified fields
            var r01 = GetKontoZapisTemplate();

            //row02: with KwotaWinienWaluta, KodWalutyWinien, OpisZapisuMa
            var r02 = GetKontoZapisTemplate();
            r02.KwotaWinienWaluta = (decimal)21000.33;
            r02.KodWalutyWinien = Models.Common.KodWalutyV30.AUD;
            r02.OpisZapisuMa = "Jakiś tam zapis po stronie 'ma'";

            //row03: with KwotaMaWaluta, KodWalutyMa, OpisZapisuWinien
            var r03 = GetKontoZapisTemplate();
            r03.KwotaMaWaluta = (decimal)15000.33;
            r03.KodWalutyMa = Models.Common.KodWalutyV30.USD;
            r03.OpisZapisuWinien = "Jakiś tam zapis po stronie 'winien'";

            //row04: all specified fields
            var r04 = GetKontoZapisTemplate();
            r04.KwotaWinienWaluta = (decimal)21000.33;
            r04.KodWalutyWinien = Models.Common.KodWalutyV30.AUD;
            r04.OpisZapisuMa = "Jakiś tam zapis po stronie 'ma'";
            r04.KwotaMaWaluta = (decimal)15000.33;
            r04.KodWalutyMa = Models.Common.KodWalutyV30.USD;
            r04.OpisZapisuWinien = "Jakiś tam zapis po stronie 'winien'";

            kz.Add(r01);
            kz.Add(r02);
            kz.Add(r03);
            kz.Add(r04);
        }

        private static Zois GetZoisTemplate()
        {
            var z = new Zois
            {
                KodKonta = "34/24222",
                OpisKonta = "Konto firmowe",
                TypKonta = "Oszczędnościowe",
                KodZespolu = "65/9858",
                OpisZespolu = "Zwykły opis",
                KodKategorii = "235/67332",
                OpisKategorii = "Kategoria ABC",
                BilansOtwarciaWinien = (decimal)12345.72,
                BilansOtwarciaMa = (decimal)3462.47,
                ObrotyWinien = (decimal)32623.56,
                ObrotyMa = (decimal)2458.94,
                ObrotyWinienNarast = (decimal)364769.83,
                ObrotyMaNarast = (decimal)134733.43,
                SaldoWinien = (decimal)94373.84,
                SaldoMa = (decimal)456679.34,
            };

            return z;
        }

        private static Dziennik GetDziennikTemplate()
        {
            var d = new Dziennik
            {
                NrZapisuDziennika = "45/4252",
                OpisDziennika = "Zwykły dziennik",
                NrDowoduKsiegowego = "65/23622",
                RodzajDowodu = "Faktura",
                DataOperacji = new DateTime(2020, 1, 25),
                DataDowodu = new DateTime(2020, 1, 26),
                DataKsiegowania = new DateTime(2020, 1, 27),
                KodOperatora = "xf5G3bi",
                OpisOperacji = "Zwykła operacja",
                DziennikKwotaOperacji = (decimal)63463.84,
            };

            return d;
        }

        private static KontoZapis GetKontoZapisTemplate()
        {
            var k = new KontoZapis
            {
                NrZapisu = "235/23572",
                KodKontaWinien = "214123411234",
                KwotaWinien = (decimal)52354.63,
                KodKontaMa = "6235462475",
                KwotaMa = (decimal)3456.74,
            };

            return k;
        }
    }
}
