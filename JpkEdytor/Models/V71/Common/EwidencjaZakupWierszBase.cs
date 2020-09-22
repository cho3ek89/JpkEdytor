namespace JpkEdytor.Models.V71.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public abstract class EwidencjaZakupWierszBase : NotifyPropertyChanged
    {
        private string lpZakupu;

        private string kodKrajuNadaniaTin;

        private bool kodKrajuNadaniaTinSpecified;

        private string nrDostawcy;

        private string nazwaDostawcy;

        private string dowodZakupu;

        private DateTime dataZakupu;

        private DateTime dataWplywu;

        private bool dataWplywuSpecified;

        private DokumentZakupu? dokumentZakupu;

        private bool dokumentZakupuSpecified;

        private sbyte mpp;

        private bool mppSpecified;

        private sbyte imp;

        private bool impSpecified;

        private decimal k40;

        private bool k40Specified;

        private decimal k41;

        private bool k41Specified;

        private decimal k42;

        private bool k42Specified;

        private decimal k43;

        private bool k43Specified;

        private decimal k44;

        private bool k44Specified;

        private decimal k45;

        private bool k45Specified;

        private decimal k46;

        private bool k46Specified;

        private decimal k47;

        private bool k47Specified;

        private decimal zakupVatMarza;

        private bool zakupVatMarzaSpecified;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LpZakupu
        {
            get
            {
                return lpZakupu;
            }
            set
            {
                lpZakupu = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "KodKrajuNadaniaTIN")]
        public string KodKrajuNadaniaTin
        {
            get
            {
                return kodKrajuNadaniaTin;
            }
            set
            {
                kodKrajuNadaniaTin = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "KodKrajuNadaniaTINSpecified", DataType = "boolean")]
        public bool KodKrajuNadaniaTinSpecified
        {
            get
            {
                return kodKrajuNadaniaTinSpecified;
            }
            set
            {
                kodKrajuNadaniaTinSpecified = value;
                RaisePropertyChanged();
            }
        }

        public string NrDostawcy
        {
            get
            {
                return nrDostawcy;
            }
            set
            {
                nrDostawcy = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NazwaDostawcy
        {
            get
            {
                return nazwaDostawcy;
            }
            set
            {
                nazwaDostawcy = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string DowodZakupu
        {
            get
            {
                return dowodZakupu;
            }
            set
            {
                dowodZakupu = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataZakupu
        {
            get
            {
                return dataZakupu;
            }
            set
            {
                dataZakupu = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataWplywu
        {
            get
            {
                return dataWplywu;
            }
            set
            {
                dataWplywu = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool DataWplywuSpecified
        {
            get
            {
                return dataWplywuSpecified;
            }
            set
            {
                dataWplywuSpecified = value;
                RaisePropertyChanged();
            }
        }

        public DokumentZakupu? DokumentZakupu
        {
            get
            {
                return dokumentZakupu;
            }
            set
            {
                dokumentZakupu = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool DokumentZakupuSpecified
        {
            get
            {
                return dokumentZakupuSpecified;
            }
            set
            {
                dokumentZakupuSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "MPP")]
        public sbyte Mpp
        {
            get
            {
                return mpp;
            }
            set
            {
                mpp = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "MPPSpecified", DataType = "boolean")]
        public bool MppSpecified
        {
            get
            {
                return mppSpecified;
            }
            set
            {
                mppSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "IMP")]
        public sbyte Imp
        {
            get
            {
                return imp;
            }
            set
            {
                imp = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "IMPSpecified", DataType = "boolean")]
        public bool ImpSpecified
        {
            get
            {
                return impSpecified;
            }
            set
            {
                impSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_40", DataType = "decimal")]
        public decimal K40
        {
            get
            {
                return k40;
            }
            set
            {
                k40 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_40Specified", DataType = "boolean")]
        public bool K40Specified
        {
            get
            {
                return k40Specified;
            }
            set
            {
                k40Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_41", DataType = "decimal")]
        public decimal K41
        {
            get
            {
                return k41;
            }
            set
            {
                k41 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_41Specified", DataType = "boolean")]
        public bool K41Specified
        {
            get
            {
                return k41Specified;
            }
            set
            {
                k41Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_42", DataType = "decimal")]
        public decimal K42
        {
            get
            {
                return k42;
            }
            set
            {
                k42 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_42Specified", DataType = "boolean")]
        public bool K42Specified
        {
            get
            {
                return k42Specified;
            }
            set
            {
                k42Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_43", DataType = "decimal")]
        public decimal K43
        {
            get
            {
                return k43;
            }
            set
            {
                k43 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_43Specified", DataType = "boolean")]
        public bool K43Specified
        {
            get
            {
                return k43Specified;
            }
            set
            {
                k43Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_44", DataType = "decimal")]
        public decimal K44
        {
            get
            {
                return k44;
            }
            set
            {
                k44 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_44Specified", DataType = "boolean")]
        public bool K44Specified
        {
            get
            {
                return k44Specified;
            }
            set
            {
                k44Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_45", DataType = "decimal")]
        public decimal K45
        {
            get
            {
                return k45;
            }
            set
            {
                k45 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_45Specified", DataType = "boolean")]
        public bool K45Specified
        {
            get
            {
                return k45Specified;
            }
            set
            {
                k45Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_46", DataType = "decimal")]
        public decimal K46
        {
            get
            {
                return k46;
            }
            set
            {
                k46 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_46Specified", DataType = "boolean")]
        public bool K46Specified
        {
            get
            {
                return k46Specified;
            }
            set
            {
                k46Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_47", DataType = "decimal")]
        public decimal K47
        {
            get
            {
                return k47;
            }
            set
            {
                k47 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_47Specified", DataType = "boolean")]
        public bool K47Specified
        {
            get
            {
                return k47Specified;
            }
            set
            {
                k47Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "ZakupVAT_Marza", DataType = "decimal")]
        public decimal ZakupVatMarza
        {
            get
            {
                return zakupVatMarza;
            }
            set
            {
                zakupVatMarza = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "ZakupVAT_MarzaSpecified", DataType = "boolean")]
        public bool ZakupVatMarzaSpecified
        {
            get
            {
                return zakupVatMarzaSpecified;
            }
            set
            {
                zakupVatMarzaSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
