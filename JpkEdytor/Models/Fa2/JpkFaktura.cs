namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFaktura", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public sealed class JpkFaktura : NotifyPropertyChanged
    {
        private DateTime p1;

        private string p2A;

        private string p3A;

        private string p3B;

        private string p3C;

        private string p3D;

        private KodKrajuUeV30 p4A;

        private bool p4ASpecified;

        private string p4B;

        private KodKrajuUeV30 p5A;

        private bool p5ASpecified;

        private string p5B;

        private DateTime p6;

        private bool p6Specified;

        private decimal p13_1;

        private decimal p14_1;

        private decimal p13_2;

        private decimal p14_2;

        private decimal p13_3;

        private decimal p14_3;

        private decimal p13_4;

        private decimal p14_4;

        private decimal p13_5;

        private decimal p14_5;

        private decimal p13_6;

        private bool p13_6Specified;

        private decimal p13_7;

        private bool p13_7Specified;

        private decimal p15;

        private bool p16;

        private bool p17;

        private bool p18;

        private bool p19;

        private string p19A;

        private string p19B;

        private string p19C;

        private bool p20;

        private string p20A;

        private string p20B;

        private bool p21;

        private string p21A;

        private string p21B;

        private string p21C;

        private DateTime p22A;

        private string p22B;

        private string p22C;

        private bool p23;

        private bool p106E2;

        private bool p106E3;

        private string p106E3A;

        private RodzajFaktury rodzajFaktury;

        private string przyczynaKorekty;

        private string nrFaKorygowanej;

        private string okresFaKorygowanej;

        private decimal zalZaplata;

        private decimal zalPodatek;

        private string typ;

        public JpkFaktura()
        {
            P16 = false;
            P17 = false;
            P18 = false;
            P19 = false;
            P19A = "false";
            P19B = "false";
            P19C = "false";
            P20 = false;
            P21 = false;
            P21A = "false";
            P21B = "false";
            P21C = "false";
            P23 = false;
            P106E2 = false;
            P106E3 = false;
            P106E3A = "false";
            Typ = "G";
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
                P4ASpecified = value != default(KodKrajuUeV30);
            }
        }

        [XmlElement(ElementName = "P_4ASpecified", DataType = "boolean")]
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
                P5ASpecified = value != default(KodKrajuUeV30);
            }
        }

        [XmlElement(ElementName = "P_5ASpecified", DataType = "boolean")]
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
                P6Specified = value != default(DateTime);
            }
        }

        [XmlElement(ElementName = "P_6Specified", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_13_1", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_14_1", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_13_2", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_14_2", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_13_3", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_14_3", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_13_4", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_14_4", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_13_5", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_14_5", DataType = "decimal")]
        public decimal P14_5
        {
            get
            {
                return p14_5;
            }
            set
            {
                p14_5 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_13_6", DataType = "decimal")]
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
                P13_6Specified = value != default(decimal);
            }
        }

        [XmlElement(ElementName = "P_13_6Specified", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_13_7", DataType = "decimal")]
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
                P13_7Specified = value != default(decimal);
            }
        }

        [XmlElement(ElementName = "P_13_7Specified", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_15", DataType = "decimal")]
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

        [XmlElement(ElementName = "P_16", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_17", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_18", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_19", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_20", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_21", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_23", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_106E_2", DataType = "boolean")]
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

        [XmlElement(ElementName = "P_106E_3", DataType = "boolean")]
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

        [XmlElement(ElementName = "ZALZaplata", DataType = "decimal")]
        public decimal ZalZaplata
        {
            get
            {
                return zalZaplata;
            }
            set
            {
                zalZaplata = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "ZALPodatek", DataType = "decimal")]
        public decimal ZalPodatek
        {
            get
            {
                return zalPodatek;
            }
            set
            {
                zalPodatek = value;
                RaisePropertyChanged();
            }
        }

        [XmlAttribute(AttributeName = "typ")]
        public string Typ
        {
            get
            {
                return typ;
            }
            set
            {
                typ = value;
                RaisePropertyChanged();
            }
        }
    }
}
