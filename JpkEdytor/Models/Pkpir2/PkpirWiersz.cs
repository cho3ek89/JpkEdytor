namespace JpkEdytor.Models.Pkpir2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Attributes;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPKPIRWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10262/")]
    public sealed class PkpirWiersz : NotifyPropertyChanged
    {
        private string k1;

        private DateTime k2;

        private string k3;

        private string k4;

        private string k5;

        private string k6;

        private decimal k7;

        private decimal k8;

        private decimal k9;

        private decimal k10;

        private decimal k11;

        private decimal k12;

        private decimal k13;

        private decimal k14;

        private decimal k15;

        private string k16A;

        private decimal k16B;

        private string k17;

        private string typ;

        public PkpirWiersz()
        {
            Typ = "G";
        }

        [CsvField]
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

        [CsvField]
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

        [CsvField]
        [XmlElement(ElementName = "K_3", DataType = "token")]
        public string K3
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

        [CsvField]
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

        [CsvField]
        [XmlElement(ElementName = "K_5", DataType = "token")]
        public string K5
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

        [CsvField]
        [XmlElement(ElementName = "K_6", DataType = "token")]
        public string K6
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
        [XmlElement(ElementName = "K_16A", DataType = "token")]
        public string K16A
        {
            get
            {
                return k16A;
            }
            set
            {
                k16A = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(ElementName = "K_16B", DataType = "decimal")]
        public decimal K16B
        {
            get
            {
                return k16B;
            }
            set
            {
                k16B = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(ElementName = "K_17", DataType = "token")]
        public string K17
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
