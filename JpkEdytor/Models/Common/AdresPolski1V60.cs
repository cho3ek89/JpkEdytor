﻿namespace JpkEdytor.Models.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TAdresPolski1", Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2020/03/11/eD/DefinicjeTypy/")]
    public sealed class AdresPolski1V60 : NotifyPropertyChanged
    {
        private KodKrajuV60 kodKraju;

        private string wojewodztwo;

        private string powiat;

        private string gmina;

        private string ulica;

        private bool ulicaSpecified;

        private string nrDomu;

        private string nrLokalu;

        private bool nrLokaluSpecified;

        private string miejscowosc;

        private string kodPocztowy;

        public AdresPolski1V60()
        {
            KodKraju = KodKrajuV60.PL;
        }

        public KodKrajuV60 KodKraju
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
    }
}
