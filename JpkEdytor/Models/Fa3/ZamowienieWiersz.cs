namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKZamowienieZamowienieWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class ZamowienieWiersz : NotifyPropertyChanged
    {
        private string p7Z;

        private bool p7ZSpecified;

        private string p8AZ;

        private bool p8AZSpecified;

        private decimal p8BZ;

        private bool p8BZSpecified;

        private decimal p9AZ;

        private bool p9AZSpecified;

        private decimal p11NettoZ;

        private bool p11NettoZSpecified;

        private decimal p11VatZ;

        private bool p11VatZSpecified;

        private StawkaPodatkuZw? p12Z;

        private bool p12ZSpecified;

        [XmlElement(ElementName = "P_7Z", DataType = "token")]
        public string P7Z
        {
            get
            {
                return p7Z;
            }
            set
            {
                p7Z = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_7ZSpecified")]
        public bool P7ZSpecified
        {
            get
            {
                return p7ZSpecified;
            }
            set
            {
                p7ZSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_8AZ", DataType = "token")]
        public string P8AZ
        {
            get
            {
                return p8AZ;
            }
            set
            {
                p8AZ = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_8AZSpecified")]
        public bool P8AZSpecified
        {
            get
            {
                return p8AZSpecified;
            }
            set
            {
                p8AZSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_8BZ")]
        public decimal P8BZ
        {
            get
            {
                return p8BZ;
            }
            set
            {
                p8BZ = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_8BZSpecified")]
        public bool P8BZSpecified
        {
            get
            {
                return p8BZSpecified;
            }
            set
            {
                p8BZSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_9AZ")]
        public decimal P9AZ
        {
            get
            {
                return p9AZ;
            }
            set
            {
                p9AZ = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_9AZSpecified")]
        public bool P9AZSpecified
        {
            get
            {
                return p9AZSpecified;
            }
            set
            {
                p9AZSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_11NettoZ")]
        public decimal P11NettoZ
        {
            get
            {
                return p11NettoZ;
            }
            set
            {
                p11NettoZ = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_11NettoZSpecified")]
        public bool P11NettoZSpecified
        {
            get
            {
                return p11NettoZSpecified;
            }
            set
            {
                p11NettoZSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_11VatZ")]
        public decimal P11VatZ
        {
            get
            {
                return p11VatZ;
            }
            set
            {
                p11VatZ = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_11VatZSpecified")]
        public bool P11VatZSpecified
        {
            get
            {
                return p11VatZSpecified;
            }
            set
            {
                p11VatZSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_12Z")]
        public StawkaPodatkuZw? P12Z
        {
            get
            {
                return p12Z;
            }
            set
            {
                p12Z = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "P_12ZSpecified")]
        public bool P12ZSpecified
        {
            get
            {
                return p12ZSpecified;
            }
            set
            {
                p12ZSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
