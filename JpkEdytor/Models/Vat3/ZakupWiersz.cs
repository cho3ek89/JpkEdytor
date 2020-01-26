namespace JpkEdytor.Models.Vat3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKZakupWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
    public sealed class ZakupWiersz : NotifyPropertyChanged
    {
        private string lpZakupu;

        private string nrDostawcy;

        private string nazwaDostawcy;

        private string adresDostawcy;

        private string dowodZakupu;

        private DateTime dataZakupu;

        private DateTime dataWplywu;

        private bool dataWplywuSpecified;

        private decimal k43;

        private bool k43Specified;

        private decimal k44;

        private bool k44Specified;

        private decimal k45;

        private bool k45Specified;

        private decimal k46;

        private bool k46Specified;

        private decimal k47;

        private bool k47Specified;

        private decimal k48;

        private bool k48Specified;

        private decimal k49;

        private bool k49Specified;

        private decimal k50;

        private bool k50Specified;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LpZakupu
        {
            get
            {
                return lpZakupu;
            }
            set
            {
                lpZakupu = value;
                RaisePropertyChanged();
            }
        }

        public string NrDostawcy
        {
            get
            {
                return nrDostawcy;
            }
            set
            {
                nrDostawcy = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NazwaDostawcy
        {
            get
            {
                return nazwaDostawcy;
            }
            set
            {
                nazwaDostawcy = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string AdresDostawcy
        {
            get
            {
                return adresDostawcy;
            }
            set
            {
                adresDostawcy = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string DowodZakupu
        {
            get
            {
                return dowodZakupu;
            }
            set
            {
                dowodZakupu = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataZakupu
        {
            get
            {
                return dataZakupu;
            }
            set
            {
                dataZakupu = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataWplywu
        {
            get
            {
                return dataWplywu;
            }
            set
            {
                dataWplywu = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool DataWplywuSpecified
        {
            get
            {
                return dataWplywuSpecified;
            }
            set
            {
                dataWplywuSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_43", DataType = "decimal")]
        public decimal K43
        {
            get
            {
                return k43;
            }
            set
            {
                k43 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_43Specified", DataType = "boolean")]
        public bool K43Specified
        {
            get
            {
                return k43Specified;
            }
            set
            {
                k43Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_44", DataType = "decimal")]
        public decimal K44
        {
            get
            {
                return k44;
            }
            set
            {
                k44 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_44Specified", DataType = "boolean")]
        public bool K44Specified
        {
            get
            {
                return k44Specified;
            }
            set
            {
                k44Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_45", DataType = "decimal")]
        public decimal K45
        {
            get
            {
                return k45;
            }
            set
            {
                k45 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_45Specified", DataType = "boolean")]
        public bool K45Specified
        {
            get
            {
                return k45Specified;
            }
            set
            {
                k45Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_46", DataType = "decimal")]
        public decimal K46
        {
            get
            {
                return k46;
            }
            set
            {
                k46 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_46Specified", DataType = "boolean")]
        public bool K46Specified
        {
            get
            {
                return k46Specified;
            }
            set
            {
                k46Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_47", DataType = "decimal")]
        public decimal K47
        {
            get
            {
                return k47;
            }
            set
            {
                k47 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_47Specified", DataType = "boolean")]
        public bool K47Specified
        {
            get
            {
                return k47Specified;
            }
            set
            {
                k47Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_48", DataType = "decimal")]
        public decimal K48
        {
            get
            {
                return k48;
            }
            set
            {
                k48 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_48Specified", DataType = "boolean")]
        public bool K48Specified
        {
            get
            {
                return k48Specified;
            }
            set
            {
                k48Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_49", DataType = "decimal")]
        public decimal K49
        {
            get
            {
                return k49;
            }
            set
            {
                k49 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_49Specified", DataType = "boolean")]
        public bool K49Specified
        {
            get
            {
                return k49Specified;
            }
            set
            {
                k49Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_50", DataType = "decimal")]
        public decimal K50
        {
            get
            {
                return k50;
            }
            set
            {
                k50 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_50Specified", DataType = "boolean")]
        public bool K50Specified
        {
            get
            {
                return k50Specified;
            }
            set
            {
                k50Specified = value;
                RaisePropertyChanged();
            }
        }
    }
}
