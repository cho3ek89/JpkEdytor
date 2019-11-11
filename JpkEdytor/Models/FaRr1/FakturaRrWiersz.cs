namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaRRWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class FakturaRrWiersz : NotifyPropertyChanged
    {
        private string p4C2;

        private string p5;

        private string p6A;

        private decimal p6B;

        private string p6C;

        private decimal p7;

        private decimal p8;

        private decimal p9;

        private decimal p10;

        private string typ;

        public FakturaRrWiersz()
        {
            Typ = "G";
        }

        [XmlElement(ElementName = "P_4C2", DataType = "token")]
        public string P4C2
        {
            get
            {
                return p4C2;
            }
            set
            {
                p4C2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_5", DataType = "token")]
        public string P5
        {
            get
            {
                return p5;
            }
            set
            {
                p5 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_6A", DataType = "token")]
        public string P6A
        {
            get
            {
                return p6A;
            }
            set
            {
                p6A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_6B")]
        public decimal P6B
        {
            get
            {
                return p6B;
            }
            set
            {
                p6B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_6C", DataType = "token")]
        public string P6C
        {
            get
            {
                return p6C;
            }
            set
            {
                p6C = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_7")]
        public decimal P7
        {
            get
            {
                return p7;
            }
            set
            {
                p7 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_8")]
        public decimal P8
        {
            get
            {
                return p8;
            }
            set
            {
                p8 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_9")]
        public decimal P9
        {
            get
            {
                return p9;
            }
            set
            {
                p9 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_10")]
        public decimal P10
        {
            get
            {
                return p10;
            }
            set
            {
                p10 = value;
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
