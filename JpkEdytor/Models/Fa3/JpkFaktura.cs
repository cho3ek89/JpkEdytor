namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFaktura", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class JpkFaktura : NotifyPropertyChanged
    {
        private KodWalutyV30 kodWaluty;

        private DateTime p1;

        private string p2A;

        private string p3A;

        private bool p3ASpecified;

        private string p3B;

        private bool p3BSpecified;

        private string p3C;

        private string p3D;

        private KodKrajuUeV30 p4A;

        private bool p4ASpecified;

        private string p4B;

        private bool p4BSpecified;

        private KodKrajuUeV30 p5A;

        private bool p5ASpecified;

        private string p5B;

        private bool p5BSpecified;

        private DateTime p6;

        private bool p6Specified;

        private decimal p13_1;

        private bool p13_1Specified;

        private decimal p14_1;

        private bool p14_1Specified;

        private decimal p14_1W;

        private bool p14_1WSpecified;

        private decimal p13_2;

        private bool p13_2Specified;

        private decimal p14_2;

        private bool p14_2Specified;

        private decimal p14_2W;

        private bool p14_2WSpecified;

        private decimal p13_3;

        private bool p13_3Specified;

        private decimal p14_3;

        private bool p14_3Specified;

        private decimal p14_3W;

        private bool p14_3WSpecified;

        private decimal p13_4;

        private bool p13_4Specified;

        private decimal p14_4;

        private bool p14_4Specified;

        private decimal p14_4W;

        private bool p14_4WSpecified;

        private decimal p13_5;

        private bool p13_5Specified;

        private decimal p13_6;

        private bool p13_6Specified;

        private decimal p13_7;

        private bool p13_7Specified;

        private decimal p15;

        private bool p16;

        private bool p17;

        private bool p18;

        private bool p18A;

        private bool p19;

        private string p19A;

        private bool p19ASpecified;

        private string p19B;

        private bool p19BSpecified;

        private string p19C;

        private bool p19CSpecified;

        private bool p20;

        private string p20A;

        private bool p20ASpecified;

        private string p20B;

        private bool p20BSpecified;

        private bool p21;

        private string p21A;

        private bool p21ASpecified;

        private string p21B;

        private bool p21BSpecified;

        private string p21C;

        private bool p21CSpecified;

        private bool p22;

        private DateTime p22A;

        private bool p22ASpecified;

        private string p22B;

        private bool p22BSpecified;

        private string p22C;

        private bool p22CSpecified;

        private bool p23;

        private bool p106E2;

        private bool p106E3;

        private string p106E3A;

        private bool p106E3ASpecified;

        private RodzajFaktury rodzajFaktury;

        private string przyczynaKorekty;

        private bool przyczynaKorektySpecified;

        private string nrFaKorygowanej;

        private bool nrFaKorygowanejSpecified;

        private string okresFaKorygowanej;

        private bool okresFaKorygowanejSpecified;

        private string nrFaZaliczkowej;

        private bool nrFaZaliczkowejSpecified;

        public JpkFaktura()
        {
            P16 = false;
            P17 = false;
            P18 = false;
            P18A = false;
            P19 = false;
            P19A = "false";
            P19B = "false";
            P19C = "false";
            P20 = false;
            P21 = false;
            P21A = "false";
            P21B = "false";
            P21C = "false";
            P22 = false;
            P23 = false;
            P106E2 = false;
            P106E3 = false;
            P106E3A = "false";
        }

        public KodWalutyV30 KodWaluty
        {
            get
            {
                return kodWaluty;
            }
            set
            {
                kodWaluty = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_1", DataType = "date")]
        public DateTime P1
        {
            get
            {
                return p1;
            }
            set
            {
                p1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_2A", DataType = "token")]
        public string P2A
        {
            get
            {
                return p2A;
            }
            set
            {
                p2A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3A", DataType = "token")]
        public string P3A
        {
            get
            {
                return p3A;
            }
            set
            {
                p3A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3ASpecified")]
        [XmlIgnore]
        public bool P3ASpecified
        {
            get
            {
                return p3ASpecified;
            }
            set
            {
                p3ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3B", DataType = "token")]
        public string P3B
        {
            get
            {
                return p3B;
            }
            set
            {
                p3B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3BSpecified")]
        [XmlIgnore]
        public bool P3BSpecified
        {
            get
            {
                return p3BSpecified;
            }
            set
            {
                p3BSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3C", DataType = "token")]
        public string P3C
        {
            get
            {
                return p3C;
            }
            set
            {
                p3C = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3D", DataType = "token")]
        public string P3D
        {
            get
            {
                return p3D;
            }
            set
            {
                p3D = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_4A")]
        public KodKrajuUeV30 P4A
        {
            get
            {
                return p4A;
            }
            set
            {
                p4A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_4ASpecified")]
        [XmlIgnore]
        public bool P4ASpecified
        {
            get
            {
                return p4ASpecified;
            }
            set
            {
                p4ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_4B")]
        public string P4B
        {
            get
            {
                return p4B;
            }
            set
            {
                p4B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_4BSpecified")]
        [XmlIgnore]
        public bool P4BSpecified
        {
            get
            {
                return p4BSpecified;
            }
            set
            {
                p4BSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_5A")]
        public KodKrajuUeV30 P5A
        {
            get
            {
                return p5A;
            }
            set
            {
                p5A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_5ASpecified")]
        [XmlIgnore]
        public bool P5ASpecified
        {
            get
            {
                return p5ASpecified;
            }
            set
            {
                p5ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_5B")]
        public string P5B
        {
            get
            {
                return p5B;
            }
            set
            {
                p5B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_5BSpecified")]
        [XmlIgnore]
        public bool P5BSpecified
        {
            get
            {
                return p5BSpecified;
            }
            set
            {
                p5BSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_6", DataType = "date")]
        public DateTime P6
        {
            get
            {
                return p6;
            }
            set
            {
                p6 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_6Specified")]
        [XmlIgnore]
        public bool P6Specified
        {
            get
            {
                return p6Specified;
            }
            set
            {
                p6Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_1")]
        public decimal P13_1
        {
            get
            {
                return p13_1;
            }
            set
            {
                p13_1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_1Specified")]
        [XmlIgnore]
        public bool P13_1Specified
        {
            get
            {
                return p13_1Specified;
            }
            set
            {
                p13_1Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_1")]
        public decimal P14_1
        {
            get
            {
                return p14_1;
            }
            set
            {
                p14_1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_1Specified")]
        [XmlIgnore]
        public bool P14_1Specified
        {
            get
            {
                return p14_1Specified;
            }
            set
            {
                p14_1Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_1W")]
        public decimal P14_1W
        {
            get
            {
                return p14_1W;
            }
            set
            {
                p14_1W = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_1WSpecified")]
        [XmlIgnore]
        public bool P14_1WSpecified
        {
            get
            {
                return p14_1WSpecified;
            }
            set
            {
                p14_1WSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_2")]
        public decimal P13_2
        {
            get
            {
                return p13_2;
            }
            set
            {
                p13_2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_2Specified")]
        [XmlIgnore]
        public bool P13_2Specified
        {
            get
            {
                return p13_2Specified;
            }
            set
            {
                p13_2Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_2")]
        public decimal P14_2
        {
            get
            {
                return p14_2;
            }
            set
            {
                p14_2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_2Specified")]
        [XmlIgnore]
        public bool P14_2Specified
        {
            get
            {
                return p14_2Specified;
            }
            set
            {
                p14_2Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_2W")]
        public decimal P14_2W
        {
            get
            {
                return p14_2W;
            }
            set
            {
                p14_2W = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_2WSpecified")]
        [XmlIgnore]
        public bool P14_2WSpecified
        {
            get
            {
                return p14_2WSpecified;
            }
            set
            {
                p14_2WSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_3")]
        public decimal P13_3
        {
            get
            {
                return p13_3;
            }
            set
            {
                p13_3 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_3Specified")]
        [XmlIgnore]
        public bool P13_3Specified
        {
            get
            {
                return p13_3Specified;
            }
            set
            {
                p13_3Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_3")]
        public decimal P14_3
        {
            get
            {
                return p14_3;
            }
            set
            {
                p14_3 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_3Specified")]
        [XmlIgnore]
        public bool P14_3Specified
        {
            get
            {
                return p14_3Specified;
            }
            set
            {
                p14_3Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_3W")]
        public decimal P14_3W
        {
            get
            {
                return p14_3W;
            }
            set
            {
                p14_3W = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_3WSpecified")]
        [XmlIgnore]
        public bool P14_3WSpecified
        {
            get
            {
                return p14_3WSpecified;
            }
            set
            {
                p14_3WSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_4")]
        public decimal P13_4
        {
            get
            {
                return p13_4;
            }
            set
            {
                p13_4 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_4Specified")]
        [XmlIgnore]
        public bool P13_4Specified
        {
            get
            {
                return p13_4Specified;
            }
            set
            {
                p13_4Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_4")]
        public decimal P14_4
        {
            get
            {
                return p14_4;
            }
            set
            {
                p14_4 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_4Specified")]
        [XmlIgnore]
        public bool P14_4Specified
        {
            get
            {
                return p14_4Specified;
            }
            set
            {
                p14_4Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_4W")]
        public decimal P14_4W
        {
            get
            {
                return p14_4W;
            }
            set
            {
                p14_4W = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_14_4WSpecified")]
        [XmlIgnore]
        public bool P14_4WSpecified
        {
            get
            {
                return p14_4WSpecified;
            }
            set
            {
                p14_4WSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_5")]
        public decimal P13_5
        {
            get
            {
                return p13_5;
            }
            set
            {
                p13_5 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_5Specified")]
        [XmlIgnore]
        public bool P13_5Specified
        {
            get
            {
                return p13_5Specified;
            }
            set
            {
                p13_5Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_6")]
        public decimal P13_6
        {
            get
            {
                return p13_6;
            }
            set
            {
                p13_6 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_6Specified")]
        [XmlIgnore]
        public bool P13_6Specified
        {
            get
            {
                return p13_6Specified;
            }
            set
            {
                p13_6Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_7")]
        public decimal P13_7
        {
            get
            {
                return p13_7;
            }
            set
            {
                p13_7 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_7Specified")]
        [XmlIgnore]
        public bool P13_7Specified
        {
            get
            {
                return p13_7Specified;
            }
            set
            {
                p13_7Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_15")]
        public decimal P15
        {
            get
            {
                return p15;
            }
            set
            {
                p15 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_16")]
        public bool P16
        {
            get
            {
                return p16;
            }
            set
            {
                p16 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_17")]
        public bool P17
        {
            get
            {
                return p17;
            }
            set
            {
                p17 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_18")]
        public bool P18
        {
            get
            {
                return p18;
            }
            set
            {
                p18 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_18A")]
        public bool P18A
        {
            get
            {
                return p18A;
            }
            set
            {
                p18A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_19")]
        public bool P19
        {
            get
            {
                return p19;
            }
            set
            {
                p19 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_19A", DataType = "token")]
        [DefaultValue("false")]
        public string P19A
        {
            get
            {
                return p19A;
            }
            set
            {
                p19A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_19ASpecified")]
        [XmlIgnore]
        public bool P19ASpecified
        {
            get
            {
                return p19ASpecified;
            }
            set
            {
                p19ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_19B", DataType = "token")]
        [DefaultValue("false")]
        public string P19B
        {
            get
            {
                return p19B;
            }
            set
            {
                p19B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_19BSpecified")]
        [XmlIgnore]
        public bool P19BSpecified
        {
            get
            {
                return p19BSpecified;
            }
            set
            {
                p19BSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_19C", DataType = "token")]
        [DefaultValue("false")]
        public string P19C
        {
            get
            {
                return p19C;
            }
            set
            {
                p19C = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_19CSpecified")]
        [XmlIgnore]
        public bool P19CSpecified
        {
            get
            {
                return p19CSpecified;
            }
            set
            {
                p19CSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_20")]
        public bool P20
        {
            get
            {
                return p20;
            }
            set
            {
                p20 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_20A", DataType = "token")]
        public string P20A
        {
            get
            {
                return p20A;
            }
            set
            {
                p20A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_20ASpecified")]
        [XmlIgnore]
        public bool P20ASpecified
        {
            get
            {
                return p20ASpecified;
            }
            set
            {
                p20ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_20B", DataType = "token")]
        public string P20B
        {
            get
            {
                return p20B;
            }
            set
            {
                p20B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_20BSpecified")]
        [XmlIgnore]
        public bool P20BSpecified
        {
            get
            {
                return p20BSpecified;
            }
            set
            {
                p20BSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_21")]
        public bool P21
        {
            get
            {
                return p21;
            }
            set
            {
                p21 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_21A", DataType = "token")]
        public string P21A
        {
            get
            {
                return p21A;
            }
            set
            {
                p21A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_21ASpecified")]
        [XmlIgnore]
        public bool P21ASpecified
        {
            get
            {
                return p21ASpecified;
            }
            set
            {
                p21ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_21B", DataType = "token")]
        public string P21B
        {
            get
            {
                return p21B;
            }
            set
            {
                p21B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_21BSpecified")]
        [XmlIgnore]
        public bool P21BSpecified
        {
            get
            {
                return p21BSpecified;
            }
            set
            {
                p21BSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_21C", DataType = "token")]
        public string P21C
        {
            get
            {
                return p21C;
            }
            set
            {
                p21C = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_21CSpecified")]
        [XmlIgnore]
        public bool P21CSpecified
        {
            get
            {
                return p21CSpecified;
            }
            set
            {
                p21CSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_22")]
        public bool P22
        {
            get
            {
                return p22;
            }
            set
            {
                p22 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_22A", DataType = "date")]
        public DateTime P22A
        {
            get
            {
                return p22A;
            }
            set
            {
                p22A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_22ASpecified")]
        [XmlIgnore]
        public bool P22ASpecified
        {
            get
            {
                return p22ASpecified;
            }
            set
            {
                p22ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_22B", DataType = "token")]
        public string P22B
        {
            get
            {
                return p22B;
            }
            set
            {
                p22B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_22BSpecified")]
        [XmlIgnore]
        public bool P22BSpecified
        {
            get
            {
                return p22BSpecified;
            }
            set
            {
                p22BSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_22C", DataType = "token")]
        public string P22C
        {
            get
            {
                return p22C;
            }
            set
            {
                p22C = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_22CSpecified")]
        [XmlIgnore]
        public bool P22CSpecified
        {
            get
            {
                return p22CSpecified;
            }
            set
            {
                p22CSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_23")]
        public bool P23
        {
            get
            {
                return p23;
            }
            set
            {
                p23 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_106E_2")]
        public bool P106E2
        {
            get
            {
                return p106E2;
            }
            set
            {
                p106E2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_106E_3")]
        public bool P106E3
        {
            get
            {
                return p106E3;
            }
            set
            {
                p106E3 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_106E_3A", DataType = "token")]
        [DefaultValue("false")]
        public string P106E3A
        {
            get
            {
                return p106E3A;
            }
            set
            {
                p106E3A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_106E_3ASpecified")]
        [XmlIgnore]
        public bool P106E3ASpecified
        {
            get
            {
                return p106E3ASpecified;
            }
            set
            {
                p106E3ASpecified = value;
                RaisePropertyChanged();
            }
        }

        public RodzajFaktury RodzajFaktury
        {
            get
            {
                return rodzajFaktury;
            }
            set
            {
                rodzajFaktury = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string PrzyczynaKorekty
        {
            get
            {
                return przyczynaKorekty;
            }
            set
            {
                przyczynaKorekty = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "PrzyczynaKorektySpecified")]
        [XmlIgnore]
        public bool PrzyczynaKorektySpecified
        {
            get
            {
                return przyczynaKorektySpecified;
            }
            set
            {
                przyczynaKorektySpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NrFaKorygowanej
        {
            get
            {
                return nrFaKorygowanej;
            }
            set
            {
                nrFaKorygowanej = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "NrFaKorygowanejSpecified")]
        [XmlIgnore]
        public bool NrFaKorygowanejSpecified
        {
            get
            {
                return nrFaKorygowanejSpecified;
            }
            set
            {
                nrFaKorygowanejSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string OkresFaKorygowanej
        {
            get
            {
                return okresFaKorygowanej;
            }
            set
            {
                okresFaKorygowanej = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "OkresFaKorygowanejSpecified")]
        [XmlIgnore]
        public bool OkresFaKorygowanejSpecified
        {
            get
            {
                return okresFaKorygowanejSpecified;
            }
            set
            {
                okresFaKorygowanejSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NrFaZaliczkowej
        {
            get
            {
                return nrFaZaliczkowej;
            }
            set
            {
                nrFaZaliczkowej = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "NrFaZaliczkowejSpecified")]
        [XmlIgnore]
        public bool NrFaZaliczkowejSpecified
        {
            get
            {
                return nrFaZaliczkowejSpecified;
            }
            set
            {
                nrFaZaliczkowejSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
