namespace JpkEdytor.Models.Wb1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKWyciagWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03092/")]
    public sealed class WyciagWiersz : NotifyPropertyChanged
    {
        private string numerWiersza;

        private DateTime dataOperacji;

        private string nazwaPodmiotu;

        private string opisOperacji;

        private decimal kwotaOperacji;

        private decimal saldoOperacji;

        private string typ;

        public WyciagWiersz()
        {
            Typ = "G";
        }

        [XmlElement(DataType = "nonNegativeInteger")]
        public string NumerWiersza
        {
            get
            {
                return numerWiersza;
            }
            set
            {
                numerWiersza = value;
                RaisePropertyChanged();
            }
        }

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

        [XmlElement(DataType = "token")]
        public string NazwaPodmiotu
        {
            get
            {
                return nazwaPodmiotu;
            }
            set
            {
                nazwaPodmiotu = value;
                RaisePropertyChanged();
            }
        }

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

        public decimal KwotaOperacji
        {
            get
            {
                return kwotaOperacji;
            }
            set
            {
                kwotaOperacji = value;
                RaisePropertyChanged();
            }
        }

        public decimal SaldoOperacji
        {
            get
            {
                return saldoOperacji;
            }
            set
            {
                saldoOperacji = value;
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
