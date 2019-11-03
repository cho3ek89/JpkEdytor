namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Attributes;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKMMMMWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class MmWiersz : NotifyPropertyChanged
    {
        private string numer2;

        private string kodTowaru;

        private string nazwaTowaru;

        private decimal iloscWydana;

        private string jednostkaMiary;

        private decimal cenaJednostkowa;

        private decimal wartoscPozycji;

        [CsvField]
        [XmlElement(ElementName = "Numer2MM", DataType = "token")]
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

        [CsvField]
        [XmlElement(ElementName = "KodTowaruMM", DataType = "token")]
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

        [CsvField]
        [XmlElement(ElementName = "NazwaTowaruMM", DataType = "token")]
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

        [CsvField]
        [XmlElement(ElementName = "IloscWydanaMM")]
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

        [CsvField]
        [XmlElement(ElementName = "JednostkaMiaryMM", DataType = "token")]
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

        [CsvField]
        [XmlElement(ElementName = "CenaJednMM")]
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

        [CsvField]
        [XmlElement(ElementName = "WartoscPozycjiMM")]
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
