namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;
    using System.Threading.Tasks;

    using JpkEdytor.Models.Ewp1;
    using JpkEdytor.ViewModels;

    [TestClass]
    public class JpkEwp1ViewModelTests
    {
        [TestMethod]
        [Description("Checks if jpk_ewp1 files are generated properly.")]
        public async Task JpkEwp1FilesAreGeneratedProperly()
        {
            var vm = new JpkEwp1ViewModel();
            var jpk = vm.Jpk;

            AppendNaglowekAndPodmiot(jpk);

            AppendEwpWiersze(jpk);

            Assert.AreEqual(string.Empty, await vm.Validate());

            var actualFullFilePath = Path.GetTempFileName();
            await vm.SaveToFile(actualFullFilePath);

            TestHelper.AreMd5HashesEqual("TestFiles/jpk_ewp1_valid.xml", actualFullFilePath);

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

        private static void AppendEwpWiersze(Jpk jpk)
        {
            var ewp = jpk.EwpWiersze;

            //row01: no K12
            var r01 = GetEwpWierszTemplate();

            //row02: with K12
            var r02 = GetEwpWierszTemplate();
            r02.K12 = new DateTime(2020, 1, 25);

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
                K5 = (decimal)5125.64,
                K6 = (decimal)52345.83,
                K7 = (decimal)345.85,
                K8 = (decimal)336.73,
                K9 = (decimal)9439.88,
                K10 = (decimal)1548.94,
                K11 = (decimal)5222.84,
            };

            return e;
        }
    }
}
