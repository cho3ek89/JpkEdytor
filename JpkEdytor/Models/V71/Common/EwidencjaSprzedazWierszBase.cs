namespace JpkEdytor.Models.V71.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public abstract class EwidencjaSprzedazWierszBase : NotifyPropertyChanged
    {
        private string lpSprzedazy;

        private string kodKrajuNadaniaTin;

        private bool kodKrajuNadaniaTinSpecified;

        private string nrKontrahenta;

        private string nazwaKontrahenta;

        private string dowodSprzedazy;

        private DateTime dataWystawienia;

        private DateTime dataSprzedazy;

        private bool dataSprzedazySpecified;

        private TypDokumentu? typDokumentu;

        private bool typDokumentuSpecified;

        private sbyte gtu01;

        private bool gtu01Specified;

        private sbyte gtu02;

        private bool gtu02Specified;

        private sbyte gtu03;

        private bool gtu03Specified;

        private sbyte gtu04;

        private bool gtu04Specified;

        private sbyte gtu05;

        private bool gtu05Specified;

        private sbyte gtu06;

        private bool gtu06Specified;

        private sbyte gtu07;

        private bool gtu07Specified;

        private sbyte gtu08;

        private bool gtu08Specified;

        private sbyte gtu09;

        private bool gtu09Specified;

        private sbyte gtu10;

        private bool gtu10Specified;

        private sbyte gtu11;

        private bool gtu11Specified;

        private sbyte gtu12;

        private bool gtu12Specified;

        private sbyte gtu13;

        private bool gtu13Specified;

        private sbyte sw;

        private bool swSpecified;

        private sbyte ee;

        private bool eeSpecified;

        private sbyte tp;

        private bool tpSpecified;

        private sbyte ttWnt;

        private bool ttWntSpecified;

        private sbyte ttD;

        private bool ttDSpecified;

        private sbyte mrT;

        private bool mrTSpecified;

        private sbyte mrUz;

        private bool mrUzSpecified;

        private sbyte i42;

        private bool i42Specified;

        private sbyte i63;

        private bool i63Specified;

        private sbyte bSpv;

        private bool bSpvSpecified;

        private sbyte bSpvDostawa;

        private bool bSpvDostawaSpecified;

        private sbyte bMpvProwizja;

        private bool bMpvProwizjaSpecified;

        private sbyte mpp;

        private bool mppSpecified;

        private sbyte korektaPodstawyOpodatkowania;

        private bool korektaPodstawyOpodatkowaniaSpecified;

        private decimal k10;

        private bool k10Specified;

        private decimal k11;

        private bool k11Specified;

        private decimal k12;

        private bool k12Specified;

        private decimal k13;

        private bool k13Specified;

        private decimal k14;

        private bool k14Specified;

        private decimal k15;

        private bool k15Specified;

        private decimal k16;

        private bool k16Specified;

        private decimal k17;

        private bool k17Specified;

        private decimal k18;

        private bool k18Specified;

        private decimal k19;

        private bool k19Specified;

        private decimal k20;

        private bool k20Specified;

        private decimal k21;

        private bool k21Specified;

        private decimal k22;

        private bool k22Specified;

        private decimal k23;

        private bool k23Specified;

        private decimal k24;

        private bool k24Specified;

        private decimal k25;

        private bool k25Specified;

        private decimal k26;

        private bool k26Specified;

        private decimal k27;

        private bool k27Specified;

        private decimal k28;

        private bool k28Specified;

        private decimal k29;

        private bool k29Specified;

        private decimal k30;

        private bool k30Specified;

        private decimal k31;

        private bool k31Specified;

        private decimal k32;

        private bool k32Specified;

        private decimal k33;

        private bool k33Specified;

        private decimal k34;

        private bool k34Specified;

        private decimal k35;

        private bool k35Specified;

        private decimal k36;

        private bool k36Specified;

        private decimal sprzedazVatMarza;

        private bool sprzedazVatMarzaSpecified;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LpSprzedazy
        {
            get
            {
                return lpSprzedazy;
            }
            set
            {
                lpSprzedazy = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "KodKrajuNadaniaTIN")]
        public string KodKrajuNadaniaTin
        {
            get
            {
                return kodKrajuNadaniaTin;
            }
            set
            {
                kodKrajuNadaniaTin = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "KodKrajuNadaniaTINSpecified", DataType = "boolean")]
        public bool KodKrajuNadaniaTinSpecified
        {
            get
            {
                return kodKrajuNadaniaTinSpecified;
            }
            set
            {
                kodKrajuNadaniaTinSpecified = value;
                RaisePropertyChanged();
            }
        }

        public string NrKontrahenta
        {
            get
            {
                return nrKontrahenta;
            }
            set
            {
                nrKontrahenta = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NazwaKontrahenta
        {
            get
            {
                return nazwaKontrahenta;
            }
            set
            {
                nazwaKontrahenta = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string DowodSprzedazy
        {
            get
            {
                return dowodSprzedazy;
            }
            set
            {
                dowodSprzedazy = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataWystawienia
        {
            get
            {
                return dataWystawienia;
            }
            set
            {
                dataWystawienia = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataSprzedazy
        {
            get
            {
                return dataSprzedazy;
            }
            set
            {
                dataSprzedazy = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool DataSprzedazySpecified
        {
            get
            {
                return dataSprzedazySpecified;
            }
            set
            {
                dataSprzedazySpecified = value;
                RaisePropertyChanged();
            }
        }

        public TypDokumentu? TypDokumentu
        {
            get
            {
                return typDokumentu;
            }
            set
            {
                typDokumentu = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool TypDokumentuSpecified
        {
            get
            {
                return typDokumentuSpecified;
            }
            set
            {
                typDokumentuSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_01")]
        public sbyte Gtu01
        {
            get
            {
                return gtu01;
            }
            set
            {
                gtu01 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_01Specified", DataType = "boolean")]
        public bool Gtu01Specified
        {
            get
            {
                return gtu01Specified;
            }
            set
            {
                gtu01Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_02")]
        public sbyte Gtu02
        {
            get
            {
                return gtu02;
            }
            set
            {
                gtu02 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_02Specified", DataType = "boolean")]
        public bool Gtu02Specified
        {
            get
            {
                return gtu02Specified;
            }
            set
            {
                gtu02Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_03")]
        public sbyte Gtu03
        {
            get
            {
                return gtu03;
            }
            set
            {
                gtu03 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_03Specified", DataType = "boolean")]
        public bool Gtu03Specified
        {
            get
            {
                return gtu03Specified;
            }
            set
            {
                gtu03Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_04")]
        public sbyte Gtu04
        {
            get
            {
                return gtu04;
            }
            set
            {
                gtu04 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_04Specified", DataType = "boolean")]
        public bool Gtu04Specified
        {
            get
            {
                return gtu04Specified;
            }
            set
            {
                gtu04Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_05")]
        public sbyte Gtu05
        {
            get
            {
                return gtu05;
            }
            set
            {
                gtu05 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_05Specified", DataType = "boolean")]
        public bool Gtu05Specified
        {
            get
            {
                return gtu05Specified;
            }
            set
            {
                gtu05Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_06")]
        public sbyte Gtu06
        {
            get
            {
                return gtu06;
            }
            set
            {
                gtu06 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_06Specified", DataType = "boolean")]
        public bool Gtu06Specified
        {
            get
            {
                return gtu06Specified;
            }
            set
            {
                gtu06Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_07")]
        public sbyte Gtu07
        {
            get
            {
                return gtu07;
            }
            set
            {
                gtu07 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_07Specified", DataType = "boolean")]
        public bool Gtu07Specified
        {
            get
            {
                return gtu07Specified;
            }
            set
            {
                gtu07Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_08")]
        public sbyte Gtu08
        {
            get
            {
                return gtu08;
            }
            set
            {
                gtu08 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_08Specified", DataType = "boolean")]
        public bool Gtu08Specified
        {
            get
            {
                return gtu08Specified;
            }
            set
            {
                gtu08Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_09")]
        public sbyte Gtu09
        {
            get
            {
                return gtu09;
            }
            set
            {
                gtu09 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_09Specified", DataType = "boolean")]
        public bool Gtu09Specified
        {
            get
            {
                return gtu09Specified;
            }
            set
            {
                gtu09Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_10")]
        public sbyte Gtu10
        {
            get
            {
                return gtu10;
            }
            set
            {
                gtu10 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_10Specified", DataType = "boolean")]
        public bool Gtu10Specified
        {
            get
            {
                return gtu10Specified;
            }
            set
            {
                gtu10Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_11")]
        public sbyte Gtu11
        {
            get
            {
                return gtu11;
            }
            set
            {
                gtu11 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_11Specified", DataType = "boolean")]
        public bool Gtu11Specified
        {
            get
            {
                return gtu11Specified;
            }
            set
            {
                gtu11Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_12")]
        public sbyte Gtu12
        {
            get
            {
                return gtu12;
            }
            set
            {
                gtu12 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_12Specified", DataType = "boolean")]
        public bool Gtu12Specified
        {
            get
            {
                return gtu12Specified;
            }
            set
            {
                gtu12Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "GTU_13")]
        public sbyte Gtu13
        {
            get
            {
                return gtu13;
            }
            set
            {
                gtu13 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "GTU_13Specified", DataType = "boolean")]
        public bool Gtu13Specified
        {
            get
            {
                return gtu13Specified;
            }
            set
            {
                gtu13Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "SW")]
        public sbyte Sw
        {
            get
            {
                return sw;
            }
            set
            {
                sw = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "SWSpecified", DataType = "boolean")]
        public bool SwSpecified
        {
            get
            {
                return swSpecified;
            }
            set
            {
                swSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "EE")]
        public sbyte Ee
        {
            get
            {
                return ee;
            }
            set
            {
                ee = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "EESpecified", DataType = "boolean")]
        public bool EeSpecified
        {
            get
            {
                return eeSpecified;
            }
            set
            {
                eeSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "TP")]
        public sbyte Tp
        {
            get
            {
                return tp;
            }
            set
            {
                tp = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "TPSpecified", DataType = "boolean")]
        public bool TpSpecified
        {
            get
            {
                return tpSpecified;
            }
            set
            {
                tpSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "TT_WNT")]
        public sbyte TtWnt
        {
            get
            {
                return ttWnt;
            }
            set
            {
                ttWnt = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "TT_WNTSpecified", DataType = "boolean")]
        public bool TtWntSpecified
        {
            get
            {
                return ttWntSpecified;
            }
            set
            {
                ttWntSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "TT_D")]
        public sbyte TtD
        {
            get
            {
                return ttD;
            }
            set
            {
                ttD = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "TT_DSpecified", DataType = "boolean")]
        public bool TtDSpecified
        {
            get
            {
                return ttDSpecified;
            }
            set
            {
                ttDSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "MR_T")]
        public sbyte MrT
        {
            get
            {
                return mrT;
            }
            set
            {
                mrT = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "MR_TSpecified", DataType = "boolean")]
        public bool MrTSpecified
        {
            get
            {
                return mrTSpecified;
            }
            set
            {
                mrTSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "MR_UZ")]
        public sbyte MrUz
        {
            get
            {
                return mrUz;
            }
            set
            {
                mrUz = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "MR_UZSpecified", DataType = "boolean")]
        public bool MrUzSpecified
        {
            get
            {
                return mrUzSpecified;
            }
            set
            {
                mrUzSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "I_42")]
        public sbyte I42
        {
            get
            {
                return i42;
            }
            set
            {
                i42 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "I_42Specified", DataType = "boolean")]
        public bool I42Specified
        {
            get
            {
                return i42Specified;
            }
            set
            {
                i42Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "I_63")]
        public sbyte I63
        {
            get
            {
                return i63;
            }
            set
            {
                i63 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "I_63Specified", DataType = "boolean")]
        public bool I63Specified
        {
            get
            {
                return i63Specified;
            }
            set
            {
                i63Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "B_SPV")]
        public sbyte BSpv
        {
            get
            {
                return bSpv;
            }
            set
            {
                bSpv = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "B_SPVSpecified", DataType = "boolean")]
        public bool BSpvSpecified
        {
            get
            {
                return bSpvSpecified;
            }
            set
            {
                bSpvSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "B_SPV_DOSTAWA")]
        public sbyte BSpvDostawa
        {
            get
            {
                return bSpvDostawa;
            }
            set
            {
                bSpvDostawa = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "B_SPV_DOSTAWASpecified", DataType = "boolean")]
        public bool BSpvDostawaSpecified
        {
            get
            {
                return bSpvDostawaSpecified;
            }
            set
            {
                bSpvDostawaSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "B_MPV_PROWIZJA")]
        public sbyte BMpvProwizja
        {
            get
            {
                return bMpvProwizja;
            }
            set
            {
                bMpvProwizja = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "B_MPV_PROWIZJASpecified", DataType = "boolean")]
        public bool BMpvProwizjaSpecified
        {
            get
            {
                return bMpvProwizjaSpecified;
            }
            set
            {
                bMpvProwizjaSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "MPP")]
        public sbyte Mpp
        {
            get
            {
                return mpp;
            }
            set
            {
                mpp = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "MPPSpecified", DataType = "boolean")]
        public bool MppSpecified
        {
            get
            {
                return mppSpecified;
            }
            set
            {
                mppSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "KorektaPodstawyOpodt")]
        public sbyte KorektaPodstawyOpodatkowania
        {
            get
            {
                return korektaPodstawyOpodatkowania;
            }
            set
            {
                korektaPodstawyOpodatkowania = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "KorektaPodstawyOpodtSpecified", DataType = "boolean")]
        public bool KorektaPodstawyOpodatkowaniaSpecified
        {
            get
            {
                return korektaPodstawyOpodatkowaniaSpecified;
            }
            set
            {
                korektaPodstawyOpodatkowaniaSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_10", DataType = "decimal")]
        public decimal K10
        {
            get
            {
                return k10;
            }
            set
            {
                k10 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_10Specified", DataType = "boolean")]
        public bool K10Specified
        {
            get
            {
                return k10Specified;
            }
            set
            {
                k10Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_11", DataType = "decimal")]
        public decimal K11
        {
            get
            {
                return k11;
            }
            set
            {
                k11 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_11Specified", DataType = "boolean")]
        public bool K11Specified
        {
            get
            {
                return k11Specified;
            }
            set
            {
                k11Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_12", DataType = "decimal")]
        public decimal K12
        {
            get
            {
                return k12;
            }
            set
            {
                k12 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_12Specified", DataType = "boolean")]
        public bool K12Specified
        {
            get
            {
                return k12Specified;
            }
            set
            {
                k12Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_13", DataType = "decimal")]
        public decimal K13
        {
            get
            {
                return k13;
            }
            set
            {
                k13 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_13Specified", DataType = "boolean")]
        public bool K13Specified
        {
            get
            {
                return k13Specified;
            }
            set
            {
                k13Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_14", DataType = "decimal")]
        public decimal K14
        {
            get
            {
                return k14;
            }
            set
            {
                k14 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_14Specified", DataType = "boolean")]
        public bool K14Specified
        {
            get
            {
                return k14Specified;
            }
            set
            {
                k14Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_15", DataType = "decimal")]
        public decimal K15
        {
            get
            {
                return k15;
            }
            set
            {
                k15 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_15Specified", DataType = "boolean")]
        public bool K15Specified
        {
            get
            {
                return k15Specified;
            }
            set
            {
                k15Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_16", DataType = "decimal")]
        public decimal K16
        {
            get
            {
                return k16;
            }
            set
            {
                k16 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_16Specified", DataType = "boolean")]
        public bool K16Specified
        {
            get
            {
                return k16Specified;
            }
            set
            {
                k16Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_17", DataType = "decimal")]
        public decimal K17
        {
            get
            {
                return k17;
            }
            set
            {
                k17 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_17Specified", DataType = "boolean")]
        public bool K17Specified
        {
            get
            {
                return k17Specified;
            }
            set
            {
                k17Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_18", DataType = "decimal")]
        public decimal K18
        {
            get
            {
                return k18;
            }
            set
            {
                k18 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_18Specified", DataType = "boolean")]
        public bool K18Specified
        {
            get
            {
                return k18Specified;
            }
            set
            {
                k18Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_19", DataType = "decimal")]
        public decimal K19
        {
            get
            {
                return k19;
            }
            set
            {
                k19 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_19Specified", DataType = "boolean")]
        public bool K19Specified
        {
            get
            {
                return k19Specified;
            }
            set
            {
                k19Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_20", DataType = "decimal")]
        public decimal K20
        {
            get
            {
                return k20;
            }
            set
            {
                k20 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_20Specified", DataType = "boolean")]
        public bool K20Specified
        {
            get
            {
                return k20Specified;
            }
            set
            {
                k20Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_21", DataType = "decimal")]
        public decimal K21
        {
            get
            {
                return k21;
            }
            set
            {
                k21 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_21Specified", DataType = "boolean")]
        public bool K21Specified
        {
            get
            {
                return k21Specified;
            }
            set
            {
                k21Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_22", DataType = "decimal")]
        public decimal K22
        {
            get
            {
                return k22;
            }
            set
            {
                k22 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_22Specified", DataType = "boolean")]
        public bool K22Specified
        {
            get
            {
                return k22Specified;
            }
            set
            {
                k22Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_23", DataType = "decimal")]
        public decimal K23
        {
            get
            {
                return k23;
            }
            set
            {
                k23 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_23Specified", DataType = "boolean")]
        public bool K23Specified
        {
            get
            {
                return k23Specified;
            }
            set
            {
                k23Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_24", DataType = "decimal")]
        public decimal K24
        {
            get
            {
                return k24;
            }
            set
            {
                k24 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_24Specified", DataType = "boolean")]
        public bool K24Specified
        {
            get
            {
                return k24Specified;
            }
            set
            {
                k24Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_25", DataType = "decimal")]
        public decimal K25
        {
            get
            {
                return k25;
            }
            set
            {
                k25 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_25Specified", DataType = "boolean")]
        public bool K25Specified
        {
            get
            {
                return k25Specified;
            }
            set
            {
                k25Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_26", DataType = "decimal")]
        public decimal K26
        {
            get
            {
                return k26;
            }
            set
            {
                k26 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_26Specified", DataType = "boolean")]
        public bool K26Specified
        {
            get
            {
                return k26Specified;
            }
            set
            {
                k26Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_27", DataType = "decimal")]
        public decimal K27
        {
            get
            {
                return k27;
            }
            set
            {
                k27 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_27Specified", DataType = "boolean")]
        public bool K27Specified
        {
            get
            {
                return k27Specified;
            }
            set
            {
                k27Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_28", DataType = "decimal")]
        public decimal K28
        {
            get
            {
                return k28;
            }
            set
            {
                k28 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_28Specified", DataType = "boolean")]
        public bool K28Specified
        {
            get
            {
                return k28Specified;
            }
            set
            {
                k28Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_29", DataType = "decimal")]
        public decimal K29
        {
            get
            {
                return k29;
            }
            set
            {
                k29 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_29Specified", DataType = "boolean")]
        public bool K29Specified
        {
            get
            {
                return k29Specified;
            }
            set
            {
                k29Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_30", DataType = "decimal")]
        public decimal K30
        {
            get
            {
                return k30;
            }
            set
            {
                k30 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_30Specified", DataType = "boolean")]
        public bool K30Specified
        {
            get
            {
                return k30Specified;
            }
            set
            {
                k30Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_31", DataType = "decimal")]
        public decimal K31
        {
            get
            {
                return k31;
            }
            set
            {
                k31 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_31Specified", DataType = "boolean")]
        public bool K31Specified
        {
            get
            {
                return k31Specified;
            }
            set
            {
                k31Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_32", DataType = "decimal")]
        public decimal K32
        {
            get
            {
                return k32;
            }
            set
            {
                k32 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_32Specified", DataType = "boolean")]
        public bool K32Specified
        {
            get
            {
                return k32Specified;
            }
            set
            {
                k32Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_33", DataType = "decimal")]
        public decimal K33
        {
            get
            {
                return k33;
            }
            set
            {
                k33 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_33Specified", DataType = "boolean")]
        public bool K33Specified
        {
            get
            {
                return k33Specified;
            }
            set
            {
                k33Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_34", DataType = "decimal")]
        public decimal K34
        {
            get
            {
                return k34;
            }
            set
            {
                k34 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_34Specified", DataType = "boolean")]
        public bool K34Specified
        {
            get
            {
                return k34Specified;
            }
            set
            {
                k34Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_35", DataType = "decimal")]
        public decimal K35
        {
            get
            {
                return k35;
            }
            set
            {
                k35 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_35Specified", DataType = "boolean")]
        public bool K35Specified
        {
            get
            {
                return k35Specified;
            }
            set
            {
                k35Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_36", DataType = "decimal")]
        public decimal K36
        {
            get
            {
                return k36;
            }
            set
            {
                k36 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_36Specified", DataType = "boolean")]
        public bool K36Specified
        {
            get
            {
                return k36Specified;
            }
            set
            {
                k36Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "SprzedazVAT_Marza", DataType = "decimal")]
        public decimal SprzedazVatMarza
        {
            get
            {
                return sprzedazVatMarza;
            }
            set
            {
                sprzedazVatMarza = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "SprzedazVAT_MarzaSpecified", DataType = "boolean")]
        public bool SprzedazVatMarzaSpecified
        {
            get
            {
                return sprzedazVatMarzaSpecified;
            }
            set
            {
                sprzedazVatMarzaSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
