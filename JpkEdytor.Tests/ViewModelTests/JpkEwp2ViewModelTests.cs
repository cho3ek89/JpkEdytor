namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Ewp2;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkEwp2ViewModelTests
    {
        [TestMethod("JPK_EWP(2)")]
        [Description("Checks if JPK_EWP(2) files are generated properly.")]
        public async Task JpkEwp2FilesAreGeneratedProperly()
        {
            var vm = new JpkEwp2ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);

            AppendEwpWiersze(jpk);

            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual("TestFiles/jpk_ewp2_valid.xml", actualFullFilePath);

            File.Delete(actualFullFilePath);
        }

        private static void AppendNaglowekAndPodmiot(Jpk jpk)
        {
            jpk.Naglowek.DataWytworzeniaJpk = new DateTime(2021, 1, 31);
            jpk.Naglowek.DataOd = new DateTime(2021, 1, 1);
            jpk.Naglowek.DataDo = new DateTime(2021, 1, 31);
            jpk.Naglowek.DomyslnyKodWaluty = Models.Common.KodWalutyV30.PLN;
            jpk.Naglowek.KodUrzedu = Models.Common.KodUsV60.Us1014;

            jpk.Podmiot.AdresPodmiotu = TestHelper.GetAdresPolski1V60();
            jpk.Podmiot.IdentyfikatorPodmiotu = TestHelper.GetIdentyfikatorOsobyNiefizycznej1V60();
        }

        private static void AppendEwpWiersze(Jpk jpk)
        {
            var ewp = jpk.EwpWiersze;

            //row01: no K13
            var r01 = GetEwpWierszTemplate();

            //row02: with K13
            var r02 = GetEwpWierszTemplate();
            r02.K13 = "Uwagi...";

            ewp.Add(r01);
            ewp.Add(r02);
        }

        private static EwpWiersz GetEwpWierszTemplate()
        {
            var e = new EwpWiersz
            {
                K2 = new DateTime(2020, 1, 23),
                K3 = new DateTime(2020, 1, 24),
                K4 = "65/345672",
                K5 = (decimal)3725.04,
                K6 = (decimal)5257.23,
                K7 = (decimal)345.85,
                K8 = (decimal)526.23,
                K9 = (decimal)9541.89,
                K10 = (decimal)6727.14,
                K11 = (decimal)527.84,
                K12 = (decimal)26651.22,
            };

            return e;
        }
    }
}
