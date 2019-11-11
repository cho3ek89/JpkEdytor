namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKMMMMWartosc", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class MmWartosc : NotifyPropertyChanged
    {
        private string numer;

        private DateTime data;

        private decimal wartosc;

        private DateTime dataWydania;

        private string skad;

        private string dokad;

        [XmlElement(ElementName = "NumerMM", DataType = "token")]
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

        [XmlElement(ElementName = "DataMM", DataType = "date")]
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

        [XmlElement(ElementName = "WartoscMM")]
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

        [XmlElement(ElementName = "DataWydaniaMM", DataType = "date")]
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

        [XmlElement(ElementName = "SkadMM", DataType = "token")]
        public string Skad
        {
            get
            {
                return skad;
            }
            set
            {
                skad = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "DokadMM", DataType = "token")]
        public string Dokad
        {
            get
            {
                return dokad;
            }
            set
            {
                dokad = value;
                RaisePropertyChanged();
            }
        }
    }
}
