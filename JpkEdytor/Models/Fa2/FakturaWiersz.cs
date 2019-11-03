﻿namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Attributes;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public sealed class FakturaWiersz : NotifyPropertyChanged
    {
        private string p2B;

        private string p7;

        private string p8A;

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

        private StawkaPodatku p12;

        private bool p12Specified;

        private string typ;

        public FakturaWiersz()
        {
            Typ = "G";
        }

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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

        [CsvField]
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
                P8BSpecified = value != default(decimal);
            }
        }

        [XmlElement(ElementName = "P_8BSpecified", DataType = "boolean")]
        [XmlIgnore]
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

        [CsvField]
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
                P9ASpecified = value != default(decimal);
            }
        }

        [XmlElement(ElementName = "P_9BSpecified", DataType = "boolean")]
        [XmlIgnore]
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

        [CsvField]
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
                P9BSpecified = value != default(decimal);
            }
        }

        [XmlElement(ElementName = "P_9BSpecified", DataType = "boolean")]
        [XmlIgnore]
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

        [CsvField]
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
                P10Specified = value != default(decimal);
            }
        }

        [XmlElement(ElementName = "P_10Specified", DataType = "boolean")]
        [XmlIgnore]
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

        [CsvField]
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
                P11Specified = value != default(decimal);
            }
        }

        [XmlElement(ElementName = "P_11Specified", DataType = "boolean")]
        [XmlIgnore]
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

        [CsvField]
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
                P11ASpecified = value != default(decimal);
            }
        }

        [XmlElement(ElementName = "P_11ASpecified", DataType = "boolean")]
        [XmlIgnore]
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

        [CsvField]
        public StawkaPodatku P12
        {
            get
            {
                return p12;
            }
            set
            {
                p12 = value;
                RaisePropertyChanged();
                P12Specified = value != default(StawkaPodatku);
            }
        }

        [XmlElement(ElementName = "P_12Specified", DataType = "boolean")]
        [XmlIgnore]
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
