namespace JpkEdytor.Models.Kr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Attributes;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKZOiS", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03091/")]
    public sealed class Zois : NotifyPropertyChanged
    {
        private string kodKonta;

        private string opisKonta;

        private string typKonta;

        private string kodZespolu;

        private string opisZespolu;

        private string kodKategorii;

        private string opisKategorii;

        private string kodPodkategorii;

        private string opisPodkategorii;

        private decimal bilansOtwarciaWinien;

        private decimal bilansOtwarciaMa;

        private decimal obrotyWinien;

        private decimal obrotyMa;

        private decimal obrotyWinienNarast;

        private decimal obrotyMaNarast;

        private decimal saldoWinien;

        private decimal saldoMa;

        private string typ;

        public Zois()
        {
            Typ = "G";
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string KodKonta
        {
            get
            {
                return kodKonta;
            }
            set
            {
                kodKonta = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string OpisKonta
        {
            get
            {
                return opisKonta;
            }
            set
            {
                opisKonta = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string TypKonta
        {
            get
            {
                return typKonta;
            }
            set
            {
                typKonta = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string KodZespolu
        {
            get
            {
                return kodZespolu;
            }
            set
            {
                kodZespolu = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string OpisZespolu
        {
            get
            {
                return opisZespolu;
            }
            set
            {
                opisZespolu = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string KodKategorii
        {
            get
            {
                return kodKategorii;
            }
            set
            {
                kodKategorii = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string OpisKategorii
        {
            get
            {
                return opisKategorii;
            }
            set
            {
                opisKategorii = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string KodPodkategorii
        {
            get
            {
                return kodPodkategorii;
            }
            set
            {
                kodPodkategorii = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        [XmlElement(DataType = "token")]
        public string OpisPodkategorii
        {
            get
            {
                return opisPodkategorii;
            }
            set
            {
                opisPodkategorii = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal BilansOtwarciaWinien
        {
            get
            {
                return bilansOtwarciaWinien;
            }
            set
            {
                bilansOtwarciaWinien = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal BilansOtwarciaMa
        {
            get
            {
                return bilansOtwarciaMa;
            }
            set
            {
                bilansOtwarciaMa = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal ObrotyWinien
        {
            get
            {
                return obrotyWinien;
            }
            set
            {
                obrotyWinien = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal ObrotyMa
        {
            get
            {
                return obrotyMa;
            }
            set
            {
                obrotyMa = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal ObrotyWinienNarast
        {
            get
            {
                return obrotyWinienNarast;
            }
            set
            {
                obrotyWinienNarast = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal ObrotyMaNarast
        {
            get
            {
                return obrotyMaNarast;
            }
            set
            {
                obrotyMaNarast = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal SaldoWinien
        {
            get
            {
                return saldoWinien;
            }
            set
            {
                saldoWinien = value;
                RaisePropertyChanged();
            }
        }

        [CsvField]
        public decimal SaldoMa
        {
            get
            {
                return saldoMa;
            }
            set
            {
                saldoMa = value;
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
