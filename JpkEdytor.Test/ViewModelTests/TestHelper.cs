namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using JpkEdytor.Models.Common;
    using System.IO;
    using System.Security.Cryptography;

    public static class TestHelper
    {
        public static void AreMd5HashesEqual(string expectedFullFilePath, string actualFullFilePath)
        {
            CollectionAssert.AreEqual(
                GetFileMd5Hash(expectedFullFilePath),
                GetFileMd5Hash(actualFullFilePath),
                "Actual xml file is not the same as an expected one (MD5 hash mishmash).");
        }

        public static byte[] GetFileMd5Hash(string fullFilePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fullFilePath))
                {
                    return md5.ComputeHash(stream);
                }
            }
        }

        public static AdresPolskiV40 GetAdresPolskiV40(bool defineUlica = true, bool defineNrLokalu = true)
        {
            var adres = new AdresPolskiV40
            {
                Wojewodztwo = "dolnośląskie",
                Powiat = "wałbrzyski",
                Gmina = "Wałbrzych",
                NrDomu = "1",
                Miejscowosc = "Wałbrzych",
                KodPocztowy = "58-302",
                Poczta = "Urząd pocztowy"
            };

            if (defineUlica) 
                adres.Ulica = "Lipowa";

            if (defineNrLokalu) 
                adres.NrLokalu = "8";

            return adres;
        }

        public static AdresPolskiV50 GetAdresPolskiV50(bool defineUlica = true, bool defineNrLokalu = true)
        {
            var adres = new AdresPolskiV50
            {
                Wojewodztwo = "dolnośląskie",
                Powiat = "wałbrzyski",
                Gmina = "Wałbrzych",
                NrDomu = "1",
                Miejscowosc = "Wałbrzych",
                KodPocztowy = "58-302",
                Poczta = "Urząd pocztowy"
            };

            if (defineUlica)
                adres.Ulica = "Lipowa";

            if (defineNrLokalu)
                adres.NrLokalu = "8";

            return adres;
        }

        public static AdresZagranicznyV50 GetAdresZagranicznyV50(bool defineKodPocztowy = true, bool defineUlica = true, bool nrDomu = true, bool defineNrLokalu = true)
        {
            var adres = new AdresZagranicznyV50
            {
                KodKraju = KodKrajuV50.ES,
                Miejscowosc = "Wałbrzych",
            };

            if (defineKodPocztowy)
                adres.KodPocztowy = "28001";

            if (defineUlica)
                adres.Ulica = "Gran Vía";

            if (nrDomu)
                adres.NrDomu = "1";

            if (defineNrLokalu)
                adres.NrLokalu = "8";

            return adres;
        }

        public static AdresPolski1V50 GetAdresPolski1V50(bool defineUlica = true, bool defineNrLokalu = true)
        {
            var adres = new AdresPolski1V50
            {
                Wojewodztwo = "dolnośląskie",
                Powiat = "wałbrzyski",
                Gmina = "Wałbrzych",
                NrDomu = "1",
                Miejscowosc = "Wałbrzych",
                KodPocztowy = "58-302",
            };

            if (defineUlica)
                adres.Ulica = "Lipowa";

            if (defineNrLokalu)
                adres.NrLokalu = "8";

            return adres;
        }

        public static IdentyfikatorOsobyNiefizycznejV40 GetIdentyfikatorOsobyNiefizycznejV40(bool defineRegon = true)
        {
            var id = new IdentyfikatorOsobyNiefizycznejV40
            {
                Nip = "8117960116",
                PelnaNazwa = "Zwyczajna Firma s.c."
            };

            if(defineRegon)
                id.Regon = "357359470";

            return id;
        }

        public static IdentyfikatorOsobyNiefizycznejV50 GetIdentyfikatorOsobyNiefizycznejV50(bool defineRegon = true)
        {
            var id = new IdentyfikatorOsobyNiefizycznejV50
            {
                Nip = "8117960116",
                PelnaNazwa = "Zwyczajna Firma s.c."
            };

            if (defineRegon)
                id.Regon = "357359470";

            return id;
        }

        public static IdentyfikatorOsobyNiefizycznej1V50 GetIdentyfikatorOsobyNiefizycznej1V50()
        {
            var id = new IdentyfikatorOsobyNiefizycznej1V50
            {
                Nip = "8117960116",
                PelnaNazwa = "Zwyczajna Firma s.c."
            };

            return id;
        }
    }
}
