namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Wb1;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkWb1ViewModelTests
    {
        [TestMethod("JPK_WB(1)")]
        [Description("Checks if JPK_WB(1) files are generated properly.")]
        public async Task JpkWb1FilesAreGeneratedProperly()
        {
            var vm = new JpkWb1ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);
            AppendNumerRachunkuAndSalda(jpk);

            AppendWyciagWiersze(jpk);

            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual("TestFiles/jpk_wb1_valid.xml", actualFullFilePath);

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

        private static void AppendNumerRachunkuAndSalda(Jpk jpk)
        {
            jpk.NumerRachunku = "PL68105000024795086358395003";

            jpk.Salda.SaldoPoczatkowe = (decimal)23453456.62;
            jpk.Salda.SaldoKoncowe = (decimal)13123414.32;
        }

        private static void AppendWyciagWiersze(Jpk jpk)
        {
            var wyciagWiersze = jpk.WyciagWiersze;

            wyciagWiersze.Add(GetWyciagWierszTemplate());
            wyciagWiersze.Add(GetWyciagWierszTemplate());
            wyciagWiersze.Add(GetWyciagWierszTemplate());
        }

        private static WyciagWiersz GetWyciagWierszTemplate()
        {
            var w = new WyciagWiersz
            {
                DataOperacji = new DateTime(2020, 1, 2),
                NazwaPodmiotu = "Firma A",
                OpisOperacji = "Zapłata za towar.",
                KwotaOperacji = (decimal)100.54,
                SaldoOperacji = (decimal)1003.54
            };

            return w;
        }
    }
}
