namespace JpkEdytor.Models.Ewp1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKEWPWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03097/")]
    public sealed class EwpWiersz : NotifyPropertyChanged
    {
        private string k1;

        private DateTime k2;

        private DateTime k3;

        private string k4;

        private decimal k5;

        private decimal k6;

        private decimal k7;

        private decimal k8;

        private decimal k9;

        private decimal k10;

        private decimal k11;

        private DateTime k12;

        private bool k12Specified;

        private string typ;

        public EwpWiersz()
        {
            Typ = "G";
        }

        [XmlElement(ElementName = "K_1", DataType = "nonNegativeInteger")]
        public string K1
        {
            get
            {
                return k1;
            }
            set
            {
                k1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_2", DataType = "date")]
        public DateTime K2
        {
            get
            {
                return k2;
            }
            set
            {
                k2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_3", DataType = "date")]
        public DateTime K3
        {
            get
            {
                return k3;
            }
            set
            {
                k3 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_4", DataType = "token")]
        public string K4
        {
            get
            {
                return k4;
            }
            set
            {
                k4 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_5", DataType = "decimal")]
        public decimal K5
        {
            get
            {
                return k5;
            }
            set
            {
                k5 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_6", DataType = "decimal")]
        public decimal K6
        {
            get
            {
                return k6;
            }
            set
            {
                k6 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_7", DataType = "decimal")]
        public decimal K7
        {
            get
            {
                return k7;
            }
            set
            {
                k7 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_8", DataType = "decimal")]
        public decimal K8
        {
            get
            {
                return k8;
            }
            set
            {
                k8 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_9", DataType = "decimal")]
        public decimal K9
        {
            get
            {
                return k9;
            }
            set
            {
                k9 = value;
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

        [XmlElement(ElementName = "K_12", DataType = "date")]
        public DateTime K12
        {
            get
            {
                return k12;
            }
            set
            {
                k12 = value;
                RaisePropertyChanged();
                K12Specified = value != default(DateTime);
            }
        }

        [XmlElement(ElementName = "K_12Specified", DataType = "boolean")]
        [XmlIgnore]
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
