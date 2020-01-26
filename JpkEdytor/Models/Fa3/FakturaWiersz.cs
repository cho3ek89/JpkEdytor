namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class FakturaWiersz : NotifyPropertyChanged
    {
        private string p2B;

        private string p7;

        private bool p7Specified;

        private string p8A;

        private bool p8ASpecified;

        private decimal p8B;

        private bool p8BSpecified;

        private decimal p9A;

        private bool p9ASpecified;

        private decimal p9B;

        private bool p9BSpecified;

        private decimal p10;

        private bool p10Specified;

        private decimal p11;

        private bool p11Specified;

        private decimal p11A;

        private bool p11ASpecified;

        private StawkaPodatkuFw p12;

        private bool p12Specified;

        [XmlElement(ElementName = "P_2B", DataType = "token")]
        public string P2B
        {
            get
            {
                return p2B;
            }
            set
            {
                p2B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_7", DataType = "token")]
        public string P7
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

        [XmlIgnore]
        [XmlElement(ElementName = "P_7Specified")]
        public bool P7Specified
        {
            get
            {
                return p7Specified;
            }
            set
            {
                p7Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_8A", DataType = "token")]
        public string P8A
        {
            get
            {
                return p8A;
            }
            set
            {
                p8A = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_8ASpecified")]
        public bool P8ASpecified
        {
            get
            {
                return p8ASpecified;
            }
            set
            {
                p8ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_8B")]
        public decimal P8B
        {
            get
            {
                return p8B;
            }
            set
            {
                p8B = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_8BSpecified")]
        public bool P8BSpecified
        {
            get
            {
                return p8BSpecified;
            }
            set
            {
                p8BSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_9A")]
        public decimal P9A
        {
            get
            {
                return p9A;
            }
            set
            {
                p9A = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_9ASpecified")]
        public bool P9ASpecified
        {
            get
            {
                return p9ASpecified;
            }
            set
            {
                p9ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_9B")]
        public decimal P9B
        {
            get
            {
                return p9B;
            }
            set
            {
                p9B = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_9BSpecified")]
        public bool P9BSpecified
        {
            get
            {
                return p9BSpecified;
            }
            set
            {
                p9BSpecified = value;
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

        [XmlIgnore]
        [XmlElement(ElementName = "P_10Specified")]
        public bool P10Specified
        {
            get
            {
                return p10Specified;
            }
            set
            {
                p10Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_11")]
        public decimal P11
        {
            get
            {
                return p11;
            }
            set
            {
                p11 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_11Specified")]
        public bool P11Specified
        {
            get
            {
                return p11Specified;
            }
            set
            {
                p11Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_11A")]
        public decimal P11A
        {
            get
            {
                return p11A;
            }
            set
            {
                p11A = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_11ASpecified")]
        public bool P11ASpecified
        {
            get
            {
                return p11ASpecified;
            }
            set
            {
                p11ASpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_12")]
        public StawkaPodatkuFw P12
        {
            get
            {
                return p12;
            }
            set
            {
                p12 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_12Specified")]
        public bool P12Specified
        {
            get
            {
                return p12Specified;
            }
            set
            {
                p12Specified = value;
                RaisePropertyChanged();
            }
        }
    }
}
