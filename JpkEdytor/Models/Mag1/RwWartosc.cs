namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKRWRWWartosc", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class RwWartosc : NotifyPropertyChanged
    {
        private string numer;

        private DateTime data;

        private decimal wartosc;

        private DateTime dataWydania;

        private string skad;

        private bool skadSpecified;

        private string dokad;

        private bool dokadSpecified;

        [XmlElement(ElementName = "NumerRW", DataType = "token")]
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

        [XmlElement(ElementName = "DataRW", DataType = "date")]
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

        [XmlElement(ElementName = "WartoscRW")]
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

        [XmlElement(ElementName = "DataWydaniaRW", DataType = "date")]
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

        [XmlElement(ElementName = "SkadRW", DataType = "token")]
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

        [XmlIgnore]
        public bool SkadSpecified
        {
            get
            {
                return skadSpecified;
            }
            set
            {
                skadSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "DokadRW", DataType = "token")]
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

        [XmlIgnore]
        public bool DokadSpecified
        {
            get
            {
                return dokadSpecified;
            }
            set
            {
                dokadSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
