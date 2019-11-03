namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Attributes;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKWZWZWartosc", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class WzWartosc : NotifyPropertyChanged
    {
        private string numer;

        private DateTime data;

        private decimal wartosc;

        private DateTime dataWydania;

        private string odbiorca;

        private string numerFaktury;

        private DateTime dataFaktury;

        private bool dataFakturySpecified;

        [CsvField]
        [XmlElement(ElementName = "NumerWZ", DataType = "token")]
        public string Numer
        {
            get
            {
                return numer;
            }
            set
            {
                numer = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(ElementName = "DataWZ", DataType = "date")]
        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(ElementName = "WartoscWZ")]
        public decimal Wartosc
        {
            get
            {
                return wartosc;
            }
            set
            {
                wartosc = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(ElementName = "DataWydaniaWZ", DataType = "date")]
        public DateTime DataWydania
        {
            get
            {
                return dataWydania;
            }
            set
            {
                dataWydania = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(ElementName = "OdbiorcaWZ", DataType = "token")]
        public string Odbiorca
        {
            get
            {
                return odbiorca;
            }
            set
            {
                odbiorca = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(ElementName = "NumerFaWZ", DataType = "token")]
        public string NumerFaktury
        {
            get
            {
                return numerFaktury;
            }
            set
            {
                numerFaktury = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(ElementName = "DataFaWZ", DataType = "date")]
        public DateTime DataFaktury
        {
            get
            {
                return dataFaktury;
            }
            set
            {
                dataFaktury = value;
                RaisePropertyChanged();
                DataFakturySpecified = value != default(DateTime);
            }
        }

        [XmlIgnore]
        public bool DataFakturySpecified
        {
            get
            {
                return dataFakturySpecified;
            }
            set
            {
                dataFakturySpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
