namespace JpkEdytor.Models.Kr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKKontoZapis", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03091/")]
    public sealed class KontoZapis : NotifyPropertyChanged
    {
        private string lpZapisu;

        private string nrZapisu;

        private string kodKontaWinien;

        private decimal kwotaWinien;

        private decimal kwotaWinienWaluta;

        private bool kwotaWinienWalutaSpecified;

        private KodWalutyV30 kodWalutyWinien;

        private bool kodWalutyWinienSpecified;

        private string opisZapisuWinien;

        private string kodKontaMa;

        private decimal kwotaMa;

        private decimal kwotaMaWaluta;

        private bool kwotaMaWalutaSpecified;

        private KodWalutyV30 kodWalutyMa;

        private bool kodWalutyMaSpecified;

        private string opisZapisuMa;

        private string typ;

        public KontoZapis()
        {
            KodKontaWinien = "null";
            KodKontaMa = "null";
            Typ = "G";
        }

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LpZapisu
        {
            get
            {
                return lpZapisu;
            }
            set
            {
                lpZapisu = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NrZapisu
        {
            get
            {
                return nrZapisu;
            }
            set
            {
                nrZapisu = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string KodKontaWinien
        {
            get
            {
                return kodKontaWinien;
            }
            set
            {
                kodKontaWinien = value;
                RaisePropertyChanged();
            }
        }

        public decimal KwotaWinien
        {
            get
            {
                return kwotaWinien;
            }
            set
            {
                kwotaWinien = value;
                RaisePropertyChanged();
            }
        }

        public decimal KwotaWinienWaluta
        {
            get
            {
                return kwotaWinienWaluta;
            }
            set
            {
                kwotaWinienWaluta = value;
                RaisePropertyChanged();
                KwotaWinienWalutaSpecified = value != default(decimal);
            }
        }

        [XmlIgnore]
        public bool KwotaWinienWalutaSpecified
        {
            get
            {
                return kwotaWinienWalutaSpecified;
            }
            set
            {
                kwotaWinienWalutaSpecified = value;
                RaisePropertyChanged();
            }
        }

        public KodWalutyV30 KodWalutyWinien
        {
            get
            {
                return kodWalutyWinien;
            }
            set
            {
                kodWalutyWinien = value;
                RaisePropertyChanged();
                KodWalutyWinienSpecified = value != default(KodWalutyV30);
            }
        }

        [XmlIgnore]
        public bool KodWalutyWinienSpecified
        {
            get
            {
                return kodWalutyWinienSpecified;
            }
            set
            {
                kodWalutyWinienSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string OpisZapisuWinien
        {
            get
            {
                return opisZapisuWinien;
            }
            set
            {
                opisZapisuWinien = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string KodKontaMa
        {
            get
            {
                return kodKontaMa;
            }
            set
            {
                kodKontaMa = value;
                RaisePropertyChanged();
            }
        }

        public decimal KwotaMa
        {
            get
            {
                return kwotaMa;
            }
            set
            {
                kwotaMa = value;
                RaisePropertyChanged();
            }
        }

        public decimal KwotaMaWaluta
        {
            get
            {
                return kwotaMaWaluta;
            }
            set
            {
                kwotaMaWaluta = value;
                RaisePropertyChanged();
                KwotaMaWalutaSpecified = value != default(decimal);
            }
        }

        [XmlIgnore]
        public bool KwotaMaWalutaSpecified
        {
            get
            {
                return kwotaMaWalutaSpecified;
            }
            set
            {
                kwotaMaWalutaSpecified = value;
                RaisePropertyChanged();
            }
        }

        public KodWalutyV30 KodWalutyMa
        {
            get
            {
                return kodWalutyMa;
            }
            set
            {
                kodWalutyMa = value;
                RaisePropertyChanged();
                KodWalutyMaSpecified = value != default(KodWalutyV30);
            }
        }

        [XmlIgnore]
        public bool KodWalutyMaSpecified
        {
            get
            {
                return kodWalutyMaSpecified;
            }
            set
            {
                kodWalutyMaSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string OpisZapisuMa
        {
            get
            {
                return opisZapisuMa;
            }
            set
            {
                opisZapisuMa = value;
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
