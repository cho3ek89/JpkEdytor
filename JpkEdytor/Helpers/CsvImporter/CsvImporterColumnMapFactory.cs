namespace JpkEdytor.Helpers.CsvImporter
{
    using System;

    /// <summary>
    /// A factory producing CSV column mappings for certain JPK types.
    /// </summary>
    /// <seealso cref="CsvImporterColumnMap"/>
    public static class CsvImporterColumnMapFactory
    {
        /// <summary>
        /// Gets CSV column mappings for all JPK types.
        /// </summary>
        /// <returns>CSV column mappings.</returns>
        public static CsvImporterColumnMap GetCsvImporterColumnMap()
        {
            var map = new CsvImporterColumnMap();

            AddEwp1EwpWierszMapping(map);
            AddFa2JpkFakturaMapping(map);
            AddFa2FakturaWierszMapping(map);
            AddFaRr1FakturaRrMapping(map);
            AddFaRr1FakturaRrWierszMapping(map);
            AddFaRr1OswiadczenieMapping(map);
            AddKr1ZoisMapping(map);
            AddKr1DziennikMapping(map);
            AddKr1KontoZapisMapping(map);
            AddMag1PzWartoscMapping(map);
            AddMag1PzWierszMapping(map);
            AddMag1WzWartoscMapping(map);
            AddMag1WzWierszMapping(map);
            AddMag1RwWartoscMapping(map);
            AddMag1RwWierszMapping(map);
            AddMag1MmWartoscMapping(map);
            AddMag1MmWierszMapping(map);
            AddPkpir2PkpirSpisMapping(map);
            AddPkpir2PkpirWierszMapping(map);
            AddVat3SprzedazWierszMapping(map);
            AddVat3ZakupWierszMapping(map);
            AddWb1WyciagWierszMapping(map);

            return map;
        }

        /// <summary>
        /// Gets CSV column mappings for a given JPK type.
        /// </summary>
        /// <param name="type">A JPK type to get mappings for.</param>
        /// <returns>CSV column mappings.</returns>
        public static CsvImporterColumnMap GetCsvImporterColumnMap(Type type)
        {
            var map = new CsvImporterColumnMap();

            switch(type.Name)
            {
                case nameof(Models.Ewp1.EwpWiersz):
                    AddEwp1EwpWierszMapping(map);
                    break;
                case nameof(Models.Fa2.JpkFaktura):
                    AddFa2JpkFakturaMapping(map);
                    break;
                case nameof(Models.Fa2.FakturaWiersz):
                    AddFa2FakturaWierszMapping(map);
                    break;
                case nameof(Models.FaRr1.FakturaRr):
                    AddFaRr1FakturaRrMapping(map);
                    break;
                case nameof(Models.FaRr1.FakturaRrWiersz):
                    AddFaRr1FakturaRrWierszMapping(map);
                    break;
                case nameof(Models.FaRr1.Oswiadczenie):
                    AddFaRr1OswiadczenieMapping(map);
                    break;
                case nameof(Models.Kr1.Zois):
                    AddKr1ZoisMapping(map);
                    break;
                case nameof(Models.Kr1.Dziennik):
                    AddKr1DziennikMapping(map);
                    break;
                case nameof(Models.Kr1.KontoZapis):
                    AddKr1KontoZapisMapping(map);
                    break;
                case nameof(Models.Mag1.PzWartosc):
                    AddMag1PzWartoscMapping(map);
                    break;
                case nameof(Models.Mag1.PzWiersz):
                    AddMag1PzWierszMapping(map);
                    break;
                case nameof(Models.Mag1.WzWartosc):
                    AddMag1WzWartoscMapping(map);
                    break;
                case nameof(Models.Mag1.WzWiersz):
                    AddMag1WzWierszMapping(map);
                    break;
                case nameof(Models.Mag1.RwWartosc):
                    AddMag1RwWartoscMapping(map);
                    break;
                case nameof(Models.Mag1.RwWiersz):
                    AddMag1RwWierszMapping(map);
                    break;
                case nameof(Models.Mag1.MmWartosc):
                    AddMag1MmWartoscMapping(map);
                    break;
                case nameof(Models.Mag1.MmWiersz):
                    AddMag1MmWierszMapping(map);
                    break;
                case nameof(Models.Pkpir2.PkpirSpis):
                    AddPkpir2PkpirSpisMapping(map);
                    break;
                case nameof(Models.Pkpir2.PkpirWiersz):
                    AddPkpir2PkpirWierszMapping(map);
                    break;
                case nameof(Models.Vat3.SprzedazWiersz):
                    AddVat3SprzedazWierszMapping(map);
                    break;
                case nameof(Models.Vat3.ZakupWiersz):
                    AddVat3ZakupWierszMapping(map);
                    break;
                case nameof(Models.Wb1.WyciagWiersz):
                    AddWb1WyciagWierszMapping(map);
                    break;
            }

            return map;
        }

        /// <summary>
        /// Gets CSV column mappings for a given JPK type.
        /// </summary>
        /// <typeparam name="T">A JPK type to get mappings for.</typeparam>
        /// <returns>CSV column mappings.</returns>
        public static CsvImporterColumnMap GetCsvImporterColumnMap<T>()
        {
            return GetCsvImporterColumnMap(typeof(T));
        }

        private static void AddEwp1EwpWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K2);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K3);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K4);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K5);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K6);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K7);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K8);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K9);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K10);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K11);
            map.AddCsvColumnMapping((Models.Ewp1.EwpWiersz p) => p.K12);
        }

        private static void AddFa2JpkFakturaMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P1);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P2A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P3A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P3B);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P3C);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P3D);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P4A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P4B);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P5A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P5B);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P6);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P13_1);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P14_1);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P13_2);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P14_2);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P13_3);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P14_3);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P13_4);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P14_4);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P13_5);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P14_5);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P13_6);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P13_7);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P15);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P16);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P17);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P18);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P19);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P19A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P19B);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P19C);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P20);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P20A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P20B);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P21);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P21A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P21B);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P21C);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P22A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P22B);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P22C);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P23);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P106E2);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P106E3);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.P106E3A);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.RodzajFaktury);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.PrzyczynaKorekty);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.NrFaKorygowanej);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.OkresFaKorygowanej);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.ZalZaplata);
            map.AddCsvColumnMapping((Models.Fa2.JpkFaktura p) => p.ZalPodatek);
        }

        private static void AddFa2FakturaWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P2B);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P7);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P8A);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P8B);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P9A);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P9B);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P10);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P11);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P11A);
            map.AddCsvColumnMapping((Models.Fa2.FakturaWiersz p) => p.P12);
        }

        private static void AddFaRr1FakturaRrMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P1A);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P1B);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P1C);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P1D);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P2A);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P2B);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P3A.NumerSeryjny);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P3A.Wystawca);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P3A.Posiadacz);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P3B.NumerSeryjny);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P3B.Wystawca);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P3B.Posiadacz);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P4A);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P4B);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P4C1);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P11_1);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P11_2);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P12_1);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P12_2);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.P116_3);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.RodzajFaktury);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.PrzyczynaKorekty);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.NrFaKorygowanej);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.OkresFaKorygowanej);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRr p) => p.Dokument);
        }

        private static void AddFaRr1FakturaRrWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P4C2);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P5);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P6A);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P6B);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P6C);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P7);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P8);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P9);
            map.AddCsvColumnMapping((Models.FaRr1.FakturaRrWiersz p) => p.P10);
        }

        private static void AddFaRr1OswiadczenieMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P1A2);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P1B2);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P1C2);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P1D2);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P2A2);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P2B2);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P116_4_1);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P116_4_2);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P116_4_3);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P3A2.NumerSeryjny);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P3A2.Wystawca);
            map.AddCsvColumnMapping((Models.FaRr1.Oswiadczenie p) => p.P3A2.Posiadacz);
        }

        private static void AddKr1ZoisMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.KodKonta);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.OpisKonta);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.TypKonta);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.KodZespolu);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.OpisZespolu);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.KodKategorii);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.OpisKategorii);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.KodPodkategorii);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.OpisPodkategorii);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.BilansOtwarciaWinien);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.BilansOtwarciaMa);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.ObrotyWinien);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.ObrotyMa);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.ObrotyWinienNarast);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.ObrotyMaNarast);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.SaldoWinien);
            map.AddCsvColumnMapping((Models.Kr1.Zois p) => p.SaldoMa);
        }

        private static void AddKr1DziennikMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.NrZapisuDziennika);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.OpisDziennika);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.NrDowoduKsiegowego);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.RodzajDowodu);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.DataOperacji);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.DataDowodu);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.DataKsiegowania);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.KodOperatora);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.OpisOperacji);
            map.AddCsvColumnMapping((Models.Kr1.Dziennik p) => p.DziennikKwotaOperacji);
        }

        private static void AddKr1KontoZapisMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.NrZapisu);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.KodKontaWinien);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.KwotaWinien);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.KwotaWinienWaluta);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.KodWalutyWinien);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.OpisZapisuWinien);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.KodKontaMa);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.KwotaMa);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.KwotaMaWaluta);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.KodWalutyMa);
            map.AddCsvColumnMapping((Models.Kr1.KontoZapis p) => p.OpisZapisuMa);
        }

        private static void AddMag1PzWartoscMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Mag1.PzWartosc p) => p.Numer);
            map.AddCsvColumnMapping((Models.Mag1.PzWartosc p) => p.Data);
            map.AddCsvColumnMapping((Models.Mag1.PzWartosc p) => p.Wartosc);
            map.AddCsvColumnMapping((Models.Mag1.PzWartosc p) => p.DataOtrzymania);
            map.AddCsvColumnMapping((Models.Mag1.PzWartosc p) => p.Dostawca);
            map.AddCsvColumnMapping((Models.Mag1.PzWartosc p) => p.NumerFaktury);
            map.AddCsvColumnMapping((Models.Mag1.PzWartosc p) => p.DataFaktury);
        }

        private static void AddMag1PzWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Mag1.PzWiersz p) => p.Numer2);
            map.AddCsvColumnMapping((Models.Mag1.PzWiersz p) => p.KodTowaru);
            map.AddCsvColumnMapping((Models.Mag1.PzWiersz p) => p.NazwaTowaru);
            map.AddCsvColumnMapping((Models.Mag1.PzWiersz p) => p.IloscPrzyjeta);
            map.AddCsvColumnMapping((Models.Mag1.PzWiersz p) => p.JednostkaMiary);
            map.AddCsvColumnMapping((Models.Mag1.PzWiersz p) => p.CenaJednostkowa);
            map.AddCsvColumnMapping((Models.Mag1.PzWiersz p) => p.WartoscPozycji);
        }

        private static void AddMag1WzWartoscMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Mag1.WzWartosc p) => p.Numer);
            map.AddCsvColumnMapping((Models.Mag1.WzWartosc p) => p.Data);
            map.AddCsvColumnMapping((Models.Mag1.WzWartosc p) => p.Wartosc);
            map.AddCsvColumnMapping((Models.Mag1.WzWartosc p) => p.DataWydania);
            map.AddCsvColumnMapping((Models.Mag1.WzWartosc p) => p.Odbiorca);
            map.AddCsvColumnMapping((Models.Mag1.WzWartosc p) => p.NumerFaktury);
            map.AddCsvColumnMapping((Models.Mag1.WzWartosc p) => p.DataFaktury);
        }

        private static void AddMag1WzWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Mag1.WzWiersz p) => p.Numer2);
            map.AddCsvColumnMapping((Models.Mag1.WzWiersz p) => p.KodTowaru);
            map.AddCsvColumnMapping((Models.Mag1.WzWiersz p) => p.NazwaTowaru);
            map.AddCsvColumnMapping((Models.Mag1.WzWiersz p) => p.IloscWydana);
            map.AddCsvColumnMapping((Models.Mag1.WzWiersz p) => p.JednostkaMiary);
            map.AddCsvColumnMapping((Models.Mag1.WzWiersz p) => p.CenaJednostkowa);
            map.AddCsvColumnMapping((Models.Mag1.WzWiersz p) => p.WartoscPozycji);
        }

        private static void AddMag1RwWartoscMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Mag1.RwWartosc p) => p.Numer);
            map.AddCsvColumnMapping((Models.Mag1.RwWartosc p) => p.Data);
            map.AddCsvColumnMapping((Models.Mag1.RwWartosc p) => p.Wartosc);
            map.AddCsvColumnMapping((Models.Mag1.RwWartosc p) => p.DataWydania);
            map.AddCsvColumnMapping((Models.Mag1.RwWartosc p) => p.Skad);
            map.AddCsvColumnMapping((Models.Mag1.RwWartosc p) => p.Dokad);
        }

        private static void AddMag1RwWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Mag1.RwWiersz p) => p.Numer2);
            map.AddCsvColumnMapping((Models.Mag1.RwWiersz p) => p.KodTowaru);
            map.AddCsvColumnMapping((Models.Mag1.RwWiersz p) => p.NazwaTowaru);
            map.AddCsvColumnMapping((Models.Mag1.RwWiersz p) => p.IloscWydana);
            map.AddCsvColumnMapping((Models.Mag1.RwWiersz p) => p.JednostkaMiary);
            map.AddCsvColumnMapping((Models.Mag1.RwWiersz p) => p.CenaJednostkowa);
            map.AddCsvColumnMapping((Models.Mag1.RwWiersz p) => p.WartoscPozycji);
        }

        private static void AddMag1MmWartoscMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Mag1.MmWartosc p) => p.Numer);
            map.AddCsvColumnMapping((Models.Mag1.MmWartosc p) => p.Data);
            map.AddCsvColumnMapping((Models.Mag1.MmWartosc p) => p.Wartosc);
            map.AddCsvColumnMapping((Models.Mag1.MmWartosc p) => p.DataWydania);
            map.AddCsvColumnMapping((Models.Mag1.MmWartosc p) => p.Skad);
            map.AddCsvColumnMapping((Models.Mag1.MmWartosc p) => p.Dokad);
        }

        private static void AddMag1MmWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Mag1.MmWiersz p) => p.Numer2);
            map.AddCsvColumnMapping((Models.Mag1.MmWiersz p) => p.KodTowaru);
            map.AddCsvColumnMapping((Models.Mag1.MmWiersz p) => p.NazwaTowaru);
            map.AddCsvColumnMapping((Models.Mag1.MmWiersz p) => p.IloscWydana);
            map.AddCsvColumnMapping((Models.Mag1.MmWiersz p) => p.JednostkaMiary);
            map.AddCsvColumnMapping((Models.Mag1.MmWiersz p) => p.CenaJednostkowa);
            map.AddCsvColumnMapping((Models.Mag1.MmWiersz p) => p.WartoscPozycji);
        }

        private static void AddPkpir2PkpirSpisMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirSpis p) => p.P5A);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirSpis p) => p.P5B);
        }

        private static void AddPkpir2PkpirWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K2);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K3);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K4);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K5);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K6);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K7);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K8);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K9);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K10);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K11);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K12);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K13);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K14);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K15);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K16A);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K16B);
            map.AddCsvColumnMapping((Models.Pkpir2.PkpirWiersz p) => p.K17);
        }

        private static void AddVat3SprzedazWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.NrKontrahenta);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.NazwaKontrahenta);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.AdresKontrahenta);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.DowodSprzedazy);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.DataWystawienia);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.DataSprzedazy);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K10);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K11);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K12);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K13);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K14);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K15);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K16);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K17);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K18);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K19);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K20);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K21);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K22);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K23);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K24);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K25);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K26);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K27);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K28);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K29);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K30);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K31);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K32);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K33);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K34);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K35);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K36);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K37);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K38);
            map.AddCsvColumnMapping((Models.Vat3.SprzedazWiersz p) => p.K39);
        }

        private static void AddVat3ZakupWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.NrDostawcy);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.NazwaDostawcy);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.AdresDostawcy);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.DowodZakupu);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.DataZakupu);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.DataWplywu);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.K43);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.K44);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.K45);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.K46);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.K47);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.K48);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.K49);
            map.AddCsvColumnMapping((Models.Vat3.ZakupWiersz p) => p.K50);
        }

        private static void AddWb1WyciagWierszMapping(CsvImporterColumnMap map)
        {
            map.AddCsvColumnMapping((Models.Wb1.WyciagWiersz p) => p.DataOperacji);
            map.AddCsvColumnMapping((Models.Wb1.WyciagWiersz p) => p.NazwaPodmiotu);
            map.AddCsvColumnMapping((Models.Wb1.WyciagWiersz p) => p.OpisOperacji);
            map.AddCsvColumnMapping((Models.Wb1.WyciagWiersz p) => p.KwotaOperacji);
            map.AddCsvColumnMapping((Models.Wb1.WyciagWiersz p) => p.SaldoOperacji);
        }
    }
}
