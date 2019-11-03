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

        private string powiat;

        private string gmina;

        private string ulica;

        private string nrDomu;

        private string nrLokalu;

        private string miejscowosc;

        private string kodPocztowy;

        private string poczta;

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
    }
}
