namespace JpkEdytor.Models.Pkpir2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "TAdresJPK", Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10262/")]
    public sealed class Adres : NotifyPropertyChanged
    {
        private KodKrajuV41 kodKraju;

        private string wojewodztwo;

        private bool wojewodztwoSpecified;

        private string powiat;

        private bool powiatSpecified;

        private string gmina;

        private bool gminaSpecified;

        private string ulica;

        private bool ulicaSpecified;

        private string nrDomu;

        private bool nrDomuSpecified;

        private string nrLokalu;

        private bool nrLokaluSpecified;

        private string miejscowosc;

        private string kodPocztowy;

        private bool kodPocztowySpecified;

        private string poczta;

        private bool pocztaSpecified;

        public Adres()
        {
            KodKraju = KodKrajuV41.PL;
        }

        public KodKrajuV41 KodKraju
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
        public string Wojewodztwo
        {
            get
            {
                return wojewodztwo;
            }
            set
            {
                wojewodztwo = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool WojewodztwoSpecified
        {
            get
            {
                return wojewodztwoSpecified;
            }
            set
            {
                wojewodztwoSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Powiat
        {
            get
            {
                return powiat;
            }
            set
            {
                powiat = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool PowiatSpecified
        {
            get
            {
                return powiatSpecified;
            }
            set
            {
                powiatSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Gmina
        {
            get
            {
                return gmina;
            }
            set
            {
                gmina = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool GminaSpecified
        {
            get
            {
                return gminaSpecified;
            }
            set
            {
                gminaSpecified = value;
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
        public string Poczta
        {
            get
            {
                return poczta;
            }
            set
            {
                poczta = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool PocztaSpecified
        {
            get
            {
                return pocztaSpecified;
            }
            set
            {
                pocztaSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
