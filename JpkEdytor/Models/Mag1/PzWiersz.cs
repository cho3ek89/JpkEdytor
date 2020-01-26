namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPZPZWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class PzWiersz : NotifyPropertyChanged
    {
        private string numer2;

        private string kodTowaru;

        private bool kodTowaruSpecified;

        private string nazwaTowaru;

        private decimal iloscPrzyjeta;

        private string jednostkaMiary;

        private decimal cenaJednostkowa;

        private decimal wartoscPozycji;

        [XmlElement(ElementName = "Numer2PZ", DataType = "token")]
        public string Numer2
        {
            get
            {
                return numer2;
            }
            set
            {
                numer2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "KodTowaruPZ", DataType = "token")]
        public string KodTowaru
        {
            get
            {
                return kodTowaru;
            }
            set
            {
                kodTowaru = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool KodTowaruSpecified
        {
            get
            {
                return kodTowaruSpecified;
            }
            set
            {
                kodTowaruSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "NazwaTowaruPZ", DataType = "token")]
        public string NazwaTowaru
        {
            get
            {
                return nazwaTowaru;
            }
            set
            {
                nazwaTowaru = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "IloscPrzyjetaPZ")]
        public decimal IloscPrzyjeta
        {
            get
            {
                return iloscPrzyjeta;
            }
            set
            {
                iloscPrzyjeta = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "JednostkaMiaryPZ", DataType = "token")]
        public string JednostkaMiary
        {
            get
            {
                return jednostkaMiary;
            }
            set
            {
                jednostkaMiary = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "CenaJednPZ")]
        public decimal CenaJednostkowa
        {
            get
            {
                return cenaJednostkowa;
            }
            set
            {
                cenaJednostkowa = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "WartoscPozycjiPZ")]
        public decimal WartoscPozycji
        {
            get
            {
                return wartoscPozycji;
            }
            set
            {
                wartoscPozycji = value;
                RaisePropertyChanged();
            }
        }
    }
}
