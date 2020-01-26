namespace JpkEdytor.Models.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "TAdresZagraniczny", Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public sealed class AdresZagranicznyV50 : NotifyPropertyChanged
    {
        private KodKrajuV50 kodKraju;

        private string kodPocztowy;

        private bool kodPocztowySpecified;

        private string miejscowosc;

        private string ulica;

        private bool ulicaSpecified;

        private string nrDomu;

        private bool nrDomuSpecified;

        private string nrLokalu;

        private bool nrLokaluSpecified;

        public KodKrajuV50 KodKraju
        {
            get
            {
                return kodKraju;
            }
            set
            {
                kodKraju = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string KodPocztowy
        {
            get
            {
                return kodPocztowy;
            }
            set
            {
                kodPocztowy = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool KodPocztowySpecified
        {
            get
            {
                return kodPocztowySpecified;
            }
            set
            {
                kodPocztowySpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Miejscowosc
        {
            get
            {
                return miejscowosc;
            }
            set
            {
                miejscowosc = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Ulica
        {
            get
            {
                return ulica;
            }
            set
            {
                ulica = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool UlicaSpecified
        {
            get
            {
                return ulicaSpecified;
            }
            set
            {
                ulicaSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NrDomu
        {
            get
            {
                return nrDomu;
            }
            set
            {
                nrDomu = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool NrDomuSpecified
        {
            get
            {
                return nrDomuSpecified;
            }
            set
            {
                nrDomuSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NrLokalu
        {
            get
            {
                return nrLokalu;
            }
            set
            {
                nrLokalu = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool NrLokaluSpecified
        {
            get
            {
                return nrLokaluSpecified;
            }
            set
            {
                nrLokaluSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
