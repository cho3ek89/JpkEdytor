namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using System.Collections.Generic;
    using System.Linq;

    using Models.V72;
    using Models.V72.Common;

    public abstract class JpkV72ModelUpdater<T> : JpkModelUpdater<T> where T : IJpkV72
    {
        protected virtual void UpdateDeklaracjaPozycjeSzczegolowe(DeklaracjaPozycjeSzczegoloweBase pozycjeSzczegolowe)
        {
            if (pozycjeSzczegolowe == null) return;

            var areP15P16Specified = !IsDefaultValue(pozycjeSzczegolowe.P15) || !IsDefaultValue(pozycjeSzczegolowe.P16);
            var areP17P18Specified = !IsDefaultValue(pozycjeSzczegolowe.P17) || !IsDefaultValue(pozycjeSzczegolowe.P18);
            var areP19P20Specified = !IsDefaultValue(pozycjeSzczegolowe.P19) || !IsDefaultValue(pozycjeSzczegolowe.P20);
            var areP23P24Specified = !IsDefaultValue(pozycjeSzczegolowe.P23) || !IsDefaultValue(pozycjeSzczegolowe.P24);
            var areP25P26Specified = !IsDefaultValue(pozycjeSzczegolowe.P25) || !IsDefaultValue(pozycjeSzczegolowe.P26);
            var areP27P28Specified = !IsDefaultValue(pozycjeSzczegolowe.P27) || !IsDefaultValue(pozycjeSzczegolowe.P28);
            var areP29P30Specified = !IsDefaultValue(pozycjeSzczegolowe.P29) || !IsDefaultValue(pozycjeSzczegolowe.P30);
            var areP31P32Specified = !IsDefaultValue(pozycjeSzczegolowe.P31) || !IsDefaultValue(pozycjeSzczegolowe.P32);
            var areP40P41Specified = !IsDefaultValue(pozycjeSzczegolowe.P40) || !IsDefaultValue(pozycjeSzczegolowe.P41);
            var areP42P43Specified = !IsDefaultValue(pozycjeSzczegolowe.P42) || !IsDefaultValue(pozycjeSzczegolowe.P43);
            var areP54KwotaZwrotuSpecified = !IsDefaultValue(pozycjeSzczegolowe.P54) || !IsDefaultValue(pozycjeSzczegolowe.KwotaZwrotu);
            var areP59P60P61Specified = areP54KwotaZwrotuSpecified &&
                (!IsDefaultValue(pozycjeSzczegolowe.P59) || !IsDefaultValue(pozycjeSzczegolowe.P60) || !IsDefaultValue(pozycjeSzczegolowe.P61));
            var areP68P69Specified = !IsDefaultValue(pozycjeSzczegolowe.P68) || !IsDefaultValue(pozycjeSzczegolowe.P69);

            pozycjeSzczegolowe.P10Specified = !IsDefaultValue(pozycjeSzczegolowe.P10);
            pozycjeSzczegolowe.P11Specified = !IsDefaultValue(pozycjeSzczegolowe.P11);
            pozycjeSzczegolowe.P12Specified = !IsDefaultValue(pozycjeSzczegolowe.P11) && !IsDefaultValue(pozycjeSzczegolowe.P12);
            pozycjeSzczegolowe.P13Specified = !IsDefaultValue(pozycjeSzczegolowe.P13);
            pozycjeSzczegolowe.P14Specified = !IsDefaultValue(pozycjeSzczegolowe.P13) && !IsDefaultValue(pozycjeSzczegolowe.P14);
            pozycjeSzczegolowe.P15Specified = areP15P16Specified;
            pozycjeSzczegolowe.P16Specified = areP15P16Specified;
            pozycjeSzczegolowe.P17Specified = areP17P18Specified;
            pozycjeSzczegolowe.P18Specified = areP17P18Specified;
            pozycjeSzczegolowe.P19Specified = areP19P20Specified;
            pozycjeSzczegolowe.P20Specified = areP19P20Specified;
            pozycjeSzczegolowe.P21Specified = !IsDefaultValue(pozycjeSzczegolowe.P21);
            pozycjeSzczegolowe.P22Specified = !IsDefaultValue(pozycjeSzczegolowe.P22);
            pozycjeSzczegolowe.P23Specified = areP23P24Specified;
            pozycjeSzczegolowe.P24Specified = areP23P24Specified;
            pozycjeSzczegolowe.P25Specified = areP25P26Specified;
            pozycjeSzczegolowe.P26Specified = areP25P26Specified;
            pozycjeSzczegolowe.P27Specified = areP27P28Specified;
            pozycjeSzczegolowe.P28Specified = areP27P28Specified;
            pozycjeSzczegolowe.P29Specified = areP29P30Specified;
            pozycjeSzczegolowe.P30Specified = areP29P30Specified;
            pozycjeSzczegolowe.P31Specified = areP31P32Specified;
            pozycjeSzczegolowe.P32Specified = areP31P32Specified;
            pozycjeSzczegolowe.P33Specified = !IsDefaultValue(pozycjeSzczegolowe.P33);
            pozycjeSzczegolowe.P34Specified = !IsDefaultValue(pozycjeSzczegolowe.P34);
            pozycjeSzczegolowe.P35Specified = !IsDefaultValue(pozycjeSzczegolowe.P35);
            pozycjeSzczegolowe.P36Specified = !IsDefaultValue(pozycjeSzczegolowe.P36);
            pozycjeSzczegolowe.P37Specified = !IsDefaultValue(pozycjeSzczegolowe.P37); //regardless it's in a sequence with P38
            // P38 - mandatory
            pozycjeSzczegolowe.P39Specified = !IsDefaultValue(pozycjeSzczegolowe.P39);
            pozycjeSzczegolowe.P40Specified = areP40P41Specified;
            pozycjeSzczegolowe.P41Specified = areP40P41Specified;
            pozycjeSzczegolowe.P42Specified = areP42P43Specified;
            pozycjeSzczegolowe.P43Specified = areP42P43Specified;
            pozycjeSzczegolowe.P44Specified = !IsDefaultValue(pozycjeSzczegolowe.P44);
            pozycjeSzczegolowe.P45Specified = !IsDefaultValue(pozycjeSzczegolowe.P45);
            pozycjeSzczegolowe.P46Specified = !IsDefaultValue(pozycjeSzczegolowe.P46);
            pozycjeSzczegolowe.P47Specified = !IsDefaultValue(pozycjeSzczegolowe.P47);
            pozycjeSzczegolowe.P48Specified = !IsDefaultValue(pozycjeSzczegolowe.P48);
            pozycjeSzczegolowe.P49Specified = !IsDefaultValue(pozycjeSzczegolowe.P49);
            pozycjeSzczegolowe.P50Specified = !IsDefaultValue(pozycjeSzczegolowe.P50);
            // P51 - mandatory
            pozycjeSzczegolowe.P52Specified = !IsDefaultValue(pozycjeSzczegolowe.P52);
            pozycjeSzczegolowe.P53Specified = !IsDefaultValue(pozycjeSzczegolowe.P53);
            pozycjeSzczegolowe.P54Specified = areP54KwotaZwrotuSpecified;
            pozycjeSzczegolowe.KwotaZwrotuSpecified = areP54KwotaZwrotuSpecified;
            pozycjeSzczegolowe.P59Specified = areP59P60P61Specified;
            pozycjeSzczegolowe.P60Specified = areP59P60P61Specified;
            pozycjeSzczegolowe.P61Specified = areP59P60P61Specified;
            pozycjeSzczegolowe.P62Specified = !IsDefaultValue(pozycjeSzczegolowe.P62);
            pozycjeSzczegolowe.P63Specified = !IsDefaultValue(pozycjeSzczegolowe.P63);
            pozycjeSzczegolowe.P64Specified = !IsDefaultValue(pozycjeSzczegolowe.P64);
            pozycjeSzczegolowe.P65Specified = !IsDefaultValue(pozycjeSzczegolowe.P65);
            pozycjeSzczegolowe.P66Specified = !IsDefaultValue(pozycjeSzczegolowe.P66);
            pozycjeSzczegolowe.P660Specified = !IsDefaultValue(pozycjeSzczegolowe.P660);
            pozycjeSzczegolowe.P67Specified = !IsDefaultValue(pozycjeSzczegolowe.P67);
            pozycjeSzczegolowe.P68Specified = areP68P69Specified;
            pozycjeSzczegolowe.P69Specified = areP68P69Specified;
            pozycjeSzczegolowe.PordzuSpecified = !IsDefaultValue(pozycjeSzczegolowe.Pordzu);
        }

        protected virtual void UpdateSprzedazWiersze(IEnumerable<EwidencjaSprzedazWierszBase> sprzedazWiersze)
        {
            if (sprzedazWiersze == null) return;

            var count = 1;
            foreach (var sprzedazWiersz in sprzedazWiersze)
            {
                sprzedazWiersz.LpSprzedazy = count++.ToString();

                var areK15K16Specified = !IsDefaultValue(sprzedazWiersz.K15) || !IsDefaultValue(sprzedazWiersz.K16);
                var areK17K18Specified = !IsDefaultValue(sprzedazWiersz.K17) || !IsDefaultValue(sprzedazWiersz.K18);
                var areK19K20Specified = !IsDefaultValue(sprzedazWiersz.K19) || !IsDefaultValue(sprzedazWiersz.K20);
                var areK23K24Specified = !IsDefaultValue(sprzedazWiersz.K23) || !IsDefaultValue(sprzedazWiersz.K24);
                var areK25K26Specified = !IsDefaultValue(sprzedazWiersz.K25) || !IsDefaultValue(sprzedazWiersz.K26);
                var areK27K28Specified = !IsDefaultValue(sprzedazWiersz.K27) || !IsDefaultValue(sprzedazWiersz.K28);
                var areK29K30Specified = !IsDefaultValue(sprzedazWiersz.K29) || !IsDefaultValue(sprzedazWiersz.K30);
                var areK31K32Specified = !IsDefaultValue(sprzedazWiersz.K31) || !IsDefaultValue(sprzedazWiersz.K32);

                var isKorektaSpecified = !IsDefaultValue(sprzedazWiersz.KorektaPodstawyOpodatkowania) || 
                    !IsDefaultValue(sprzedazWiersz.DataKorekty);

                sprzedazWiersz.KodKrajuNadaniaTinSpecified = !IsDefaultValue(sprzedazWiersz.KodKrajuNadaniaTin);
                sprzedazWiersz.DataSprzedazySpecified = !IsDefaultValue(sprzedazWiersz.DataSprzedazy);
                sprzedazWiersz.TypDokumentuSpecified = !IsDefaultValue(sprzedazWiersz.TypDokumentu);

                sprzedazWiersz.Gtu01Specified = !IsDefaultValue(sprzedazWiersz.Gtu01);
                sprzedazWiersz.Gtu02Specified = !IsDefaultValue(sprzedazWiersz.Gtu02);
                sprzedazWiersz.Gtu03Specified = !IsDefaultValue(sprzedazWiersz.Gtu03);
                sprzedazWiersz.Gtu04Specified = !IsDefaultValue(sprzedazWiersz.Gtu04);
                sprzedazWiersz.Gtu05Specified = !IsDefaultValue(sprzedazWiersz.Gtu05);
                sprzedazWiersz.Gtu06Specified = !IsDefaultValue(sprzedazWiersz.Gtu06);
                sprzedazWiersz.Gtu07Specified = !IsDefaultValue(sprzedazWiersz.Gtu07);
                sprzedazWiersz.Gtu08Specified = !IsDefaultValue(sprzedazWiersz.Gtu08);
                sprzedazWiersz.Gtu09Specified = !IsDefaultValue(sprzedazWiersz.Gtu09);
                sprzedazWiersz.Gtu10Specified = !IsDefaultValue(sprzedazWiersz.Gtu10);
                sprzedazWiersz.Gtu11Specified = !IsDefaultValue(sprzedazWiersz.Gtu11);
                sprzedazWiersz.Gtu12Specified = !IsDefaultValue(sprzedazWiersz.Gtu12);
                sprzedazWiersz.Gtu13Specified = !IsDefaultValue(sprzedazWiersz.Gtu13);

                sprzedazWiersz.WstoEeSpecified = !IsDefaultValue(sprzedazWiersz.WstoEe);
                sprzedazWiersz.IedSpecified = !IsDefaultValue(sprzedazWiersz.Ied);
                sprzedazWiersz.TpSpecified = !IsDefaultValue(sprzedazWiersz.Tp);
                sprzedazWiersz.TtWntSpecified = !IsDefaultValue(sprzedazWiersz.TtWnt);
                sprzedazWiersz.TtDSpecified = !IsDefaultValue(sprzedazWiersz.TtD);
                sprzedazWiersz.MrTSpecified = !IsDefaultValue(sprzedazWiersz.MrT);
                sprzedazWiersz.MrUzSpecified = !IsDefaultValue(sprzedazWiersz.MrUz);
                sprzedazWiersz.I42Specified = !IsDefaultValue(sprzedazWiersz.I42);
                sprzedazWiersz.I63Specified = !IsDefaultValue(sprzedazWiersz.I63);
                sprzedazWiersz.BSpvSpecified = !IsDefaultValue(sprzedazWiersz.BSpv);
                sprzedazWiersz.BSpvDostawaSpecified = !IsDefaultValue(sprzedazWiersz.BSpvDostawa);
                sprzedazWiersz.BMpvProwizjaSpecified = !IsDefaultValue(sprzedazWiersz.BMpvProwizja);

                sprzedazWiersz.KorektaPodstawyOpodatkowaniaSpecified = isKorektaSpecified;
                sprzedazWiersz.DataKorektySpecified = isKorektaSpecified;
                sprzedazWiersz.TypDatyKorektySpecified = isKorektaSpecified;

                sprzedazWiersz.K10Specified = !IsDefaultValue(sprzedazWiersz.K10);
                sprzedazWiersz.K11Specified = !IsDefaultValue(sprzedazWiersz.K11);
                sprzedazWiersz.K12Specified = !IsDefaultValue(sprzedazWiersz.K12);
                sprzedazWiersz.K13Specified = !IsDefaultValue(sprzedazWiersz.K13);
                sprzedazWiersz.K14Specified = !IsDefaultValue(sprzedazWiersz.K14);
                sprzedazWiersz.K15Specified = areK15K16Specified;
                sprzedazWiersz.K16Specified = areK15K16Specified;
                sprzedazWiersz.K17Specified = areK17K18Specified;
                sprzedazWiersz.K18Specified = areK17K18Specified;
                sprzedazWiersz.K19Specified = areK19K20Specified;
                sprzedazWiersz.K20Specified = areK19K20Specified;
                sprzedazWiersz.K21Specified = !IsDefaultValue(sprzedazWiersz.K21);
                sprzedazWiersz.K22Specified = !IsDefaultValue(sprzedazWiersz.K22);
                sprzedazWiersz.K23Specified = areK23K24Specified;
                sprzedazWiersz.K24Specified = areK23K24Specified;
                sprzedazWiersz.K25Specified = areK25K26Specified;
                sprzedazWiersz.K26Specified = areK25K26Specified;
                sprzedazWiersz.K27Specified = areK27K28Specified;
                sprzedazWiersz.K28Specified = areK27K28Specified;
                sprzedazWiersz.K29Specified = areK29K30Specified;
                sprzedazWiersz.K30Specified = areK29K30Specified;
                sprzedazWiersz.K31Specified = areK31K32Specified;
                sprzedazWiersz.K32Specified = areK31K32Specified;
                sprzedazWiersz.K33Specified = !IsDefaultValue(sprzedazWiersz.K33);
                sprzedazWiersz.K34Specified = !IsDefaultValue(sprzedazWiersz.K34);
                sprzedazWiersz.K35Specified = !IsDefaultValue(sprzedazWiersz.K35);
                sprzedazWiersz.K36Specified = !IsDefaultValue(sprzedazWiersz.K36);
                sprzedazWiersz.SprzedazVatMarzaSpecified = !IsDefaultValue(sprzedazWiersz.SprzedazVatMarza);
            }
        }

        protected virtual void UpdateZakupWiersze(IEnumerable<EwidencjaZakupWierszBase> zakupWiersze)
        {
            if (zakupWiersze == null) return;

            var count = 1;
            foreach (var zakupWiersz in zakupWiersze)
            {
                zakupWiersz.LpZakupu = count++.ToString();

                var areK40K41Specified = !IsDefaultValue(zakupWiersz.K40) || !IsDefaultValue(zakupWiersz.K41);
                var areK42K43Specified = !IsDefaultValue(zakupWiersz.K42) || !IsDefaultValue(zakupWiersz.K43);

                zakupWiersz.KodKrajuNadaniaTinSpecified = !IsDefaultValue(zakupWiersz.KodKrajuNadaniaTin);
                zakupWiersz.DataWplywuSpecified = !IsDefaultValue(zakupWiersz.DataWplywu);
                zakupWiersz.DokumentZakupuSpecified = !IsDefaultValue(zakupWiersz.DokumentZakupu);

                zakupWiersz.ImpSpecified = !IsDefaultValue(zakupWiersz.Imp);

                zakupWiersz.K40Specified = areK40K41Specified;
                zakupWiersz.K41Specified = areK40K41Specified;
                zakupWiersz.K42Specified = areK42K43Specified;
                zakupWiersz.K43Specified = areK42K43Specified;
                zakupWiersz.K44Specified = !IsDefaultValue(zakupWiersz.K44);
                zakupWiersz.K45Specified = !IsDefaultValue(zakupWiersz.K45);
                zakupWiersz.K46Specified = !IsDefaultValue(zakupWiersz.K46);
                zakupWiersz.K47Specified = !IsDefaultValue(zakupWiersz.K47);
                zakupWiersz.ZakupVatMarzaSpecified = !IsDefaultValue(zakupWiersz.ZakupVatMarza);
            }
        }

        protected virtual decimal GetPodatekNalezny(IEnumerable<EwidencjaSprzedazWierszBase> sprzedazWiersze)
        {
            if (sprzedazWiersze == null || sprzedazWiersze.Count() == 0) return 0;

            return sprzedazWiersze
                .Where(w => w.TypDokumentu != TypDokumentu.Fp)
                .Sum(s => s.K16 + s.K18 + s.K20 + s.K24 + s.K26 + s.K28 + s.K30 + s.K32 + s.K33 + s.K34 - s.K35 - s.K36);
        }

        protected virtual decimal GetPodatekNaliczony(IEnumerable<EwidencjaZakupWierszBase> zakupWiersze)
        {
            if (zakupWiersze == null || zakupWiersze.Count() == 0) return 0;

            return zakupWiersze
                .Sum(s => s.K41 + s.K43 + s.K44 + s.K45 + s.K46 + s.K47);
        }
    }
}
