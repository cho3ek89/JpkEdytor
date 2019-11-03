namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKRWRWWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class RwWiersz : NotifyPropertyChanged
    {
        private string numer2;

        private string kodTowaru;

        private string nazwaTowaru;

        private decimal iloscWydana;

        private string jednostkaMiary;

        private decimal cenaJednostkowa;

        private decimal wartoscPozycji;

        [XmlElement(ElementName = "Numer2RW", DataType = "token")]
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

        [XmlElement(ElementName = "KodTowaruRW", DataType = "token")]
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

        [XmlElement(ElementName = "NazwaTowaruRW", DataType = "token")]
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

        [XmlElement(ElementName = "IloscWydanaRW")]
        public decimal IloscWydana
        {
            get
            {
                return iloscWydana;
            }
            set
            {
                iloscWydana = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "JednostkaMiaryRW", DataType = "token")]
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

        [XmlElement(ElementName = "CenaJednRW")]
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

        [XmlElement(ElementName = "WartoscPozycjiRW")]
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
