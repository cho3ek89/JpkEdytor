namespace JpkEdytor.Models.Kr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Attributes;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKDziennik", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03091/")]
    public sealed class Dziennik : NotifyPropertyChanged
    {
        private string lpZapisuDziennika;

        private string nrZapisuDziennika;

        private string opisDziennika;

        private string nrDowoduKsiegowego;

        private string rodzajDowodu;

        private DateTime dataOperacji;

        private DateTime dataDowodu;

        private DateTime dataKsiegowania;

        private string kodOperatora;

        private string opisOperacji;

        private decimal dziennikKwotaOperacji;

        private string typ;

        public Dziennik()
        {
            Typ = "G";
        }

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LpZapisuDziennika
        {
            get
            {
                return lpZapisuDziennika;
            }
            set
            {
                lpZapisuDziennika = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string NrZapisuDziennika
        {
            get
            {
                return nrZapisuDziennika;
            }
            set
            {
                nrZapisuDziennika = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string OpisDziennika
        {
            get
            {
                return opisDziennika;
            }
            set
            {
                opisDziennika = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string NrDowoduKsiegowego
        {
            get
            {
                return nrDowoduKsiegowego;
            }
            set
            {
                nrDowoduKsiegowego = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string RodzajDowodu
        {
            get
            {
                return rodzajDowodu;
            }
            set
            {
                rodzajDowodu = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "date")]
        public DateTime DataOperacji
        {
            get
            {
                return dataOperacji;
            }
            set
            {
                dataOperacji = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "date")]
        public DateTime DataDowodu
        {
            get
            {
                return dataDowodu;
            }
            set
            {
                dataDowodu = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "date")]
        public DateTime DataKsiegowania
        {
            get
            {
                return dataKsiegowania;
            }
            set
            {
                dataKsiegowania = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string KodOperatora
        {
            get
            {
                return kodOperatora;
            }
            set
            {
                kodOperatora = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string OpisOperacji
        {
            get
            {
                return opisOperacji;
            }
            set
            {
                opisOperacji = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal DziennikKwotaOperacji
        {
            get
            {
                return dziennikKwotaOperacji;
            }
            set
            {
                dziennikKwotaOperacji = value;
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
