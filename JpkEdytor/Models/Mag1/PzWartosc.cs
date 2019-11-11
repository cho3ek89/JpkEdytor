namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPZPZWartosc", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class PzWartosc : NotifyPropertyChanged
    {
        private string numer;

        private DateTime data;

        private decimal wartosc;

        private DateTime dataOtrzymania;

        private string dostawca;

        private string numerFaktury;

        private DateTime dataFaktury;

        private bool dataFakturySpecified;

        [XmlElement(ElementName = "NumerPZ", DataType = "token")]
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

        [XmlElement(ElementName = "DataPZ", DataType = "date")]
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

        [XmlElement(ElementName = "WartoscPZ")]
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

        [XmlElement(ElementName = "DataOtrzymaniaPZ", DataType = "date")]
        public DateTime DataOtrzymania
        {
            get
            {
                return dataOtrzymania;
            }
            set
            {
                dataOtrzymania = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Dostawca
        {
            get
            {
                return dostawca;
            }
            set
            {
                dostawca = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "NumerFaPZ", DataType = "token")]
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

        [XmlElement(ElementName = "DataFaPZ", DataType = "date")]
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
