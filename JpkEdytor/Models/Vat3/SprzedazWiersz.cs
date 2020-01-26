namespace JpkEdytor.Models.Vat3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKSprzedazWiersz", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
    public sealed class SprzedazWiersz : NotifyPropertyChanged
    {
        private string lpSprzedazy;

        private string nrKontrahenta;

        private string nazwaKontrahenta;

        private string adresKontrahenta;

        private string dowodSprzedazy;

        private DateTime dataWystawienia;

        private DateTime dataSprzedazy;

        private bool dataSprzedazySpecified;

        private decimal k10;

        private bool k10Specified;

        private decimal k11;

        private bool k11Specified;

        private decimal k12;

        private bool k12Specified;

        private decimal k13;

        private bool k13Specified;

        private decimal k14;

        private bool k14Specified;

        private decimal k15;

        private bool k15Specified;

        private decimal k16;

        private bool k16Specified;

        private decimal k17;

        private bool k17Specified;

        private decimal k18;

        private bool k18Specified;

        private decimal k19;

        private bool k19Specified;

        private decimal k20;

        private bool k20Specified;

        private decimal k21;

        private bool k21Specified;

        private decimal k22;

        private bool k22Specified;

        private decimal k23;

        private bool k23Specified;

        private decimal k24;

        private bool k24Specified;

        private decimal k25;

        private bool k25Specified;

        private decimal k26;

        private bool k26Specified;

        private decimal k27;

        private bool k27Specified;

        private decimal k28;

        private bool k28Specified;

        private decimal k29;

        private bool k29Specified;

        private decimal k30;

        private bool k30Specified;

        private decimal k31;

        private bool k31Specified;

        private decimal k32;

        private bool k32Specified;

        private decimal k33;

        private bool k33Specified;

        private decimal k34;

        private bool k34Specified;

        private decimal k35;

        private bool k35Specified;

        private decimal k36;

        private bool k36Specified;

        private decimal k37;

        private bool k37Specified;

        private decimal k38;

        private bool k38Specified;

        private decimal k39;

        private bool k39Specified;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LpSprzedazy
        {
            get
            {
                return lpSprzedazy;
            }
            set
            {
                lpSprzedazy = value;
                RaisePropertyChanged();
            }
        }

        public string NrKontrahenta
        {
            get
            {
                return nrKontrahenta;
            }
            set
            {
                nrKontrahenta = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NazwaKontrahenta
        {
            get
            {
                return nazwaKontrahenta;
            }
            set
            {
                nazwaKontrahenta = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string AdresKontrahenta
        {
            get
            {
                return adresKontrahenta;
            }
            set
            {
                adresKontrahenta = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string DowodSprzedazy
        {
            get
            {
                return dowodSprzedazy;
            }
            set
            {
                dowodSprzedazy = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataWystawienia
        {
            get
            {
                return dataWystawienia;
            }
            set
            {
                dataWystawienia = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataSprzedazy
        {
            get
            {
                return dataSprzedazy;
            }
            set
            {
                dataSprzedazy = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool DataSprzedazySpecified
        {
            get
            {
                return dataSprzedazySpecified;
            }
            set
            {
                dataSprzedazySpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_10", DataType = "decimal")]
        public decimal K10
        {
            get
            {
                return k10;
            }
            set
            {
                k10 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_10Specified", DataType = "boolean")]
        public bool K10Specified
        {
            get
            {
                return k10Specified;
            }
            set
            {
                k10Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_11", DataType = "decimal")]
        public decimal K11
        {
            get
            {
                return k11;
            }
            set
            {
                k11 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_11Specified", DataType = "boolean")]
        public bool K11Specified
        {
            get
            {
                return k11Specified;
            }
            set
            {
                k11Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_12", DataType = "decimal")]
        public decimal K12
        {
            get
            {
                return k12;
            }
            set
            {
                k12 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_12Specified", DataType = "boolean")]
        public bool K12Specified
        {
            get
            {
                return k12Specified;
            }
            set
            {
                k12Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_13", DataType = "decimal")]
        public decimal K13
        {
            get
            {
                return k13;
            }
            set
            {
                k13 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_13Specified", DataType = "boolean")]
        public bool K13Specified
        {
            get
            {
                return k13Specified;
            }
            set
            {
                k13Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_14", DataType = "decimal")]
        public decimal K14
        {
            get
            {
                return k14;
            }
            set
            {
                k14 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_14Specified", DataType = "boolean")]
        public bool K14Specified
        {
            get
            {
                return k14Specified;
            }
            set
            {
                k14Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_15", DataType = "decimal")]
        public decimal K15
        {
            get
            {
                return k15;
            }
            set
            {
                k15 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_15Specified", DataType = "boolean")]
        public bool K15Specified
        {
            get
            {
                return k15Specified;
            }
            set
            {
                k15Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_16", DataType = "decimal")]
        public decimal K16
        {
            get
            {
                return k16;
            }
            set
            {
                k16 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_16Specified", DataType = "boolean")]
        public bool K16Specified
        {
            get
            {
                return k16Specified;
            }
            set
            {
                k16Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_17", DataType = "decimal")]
        public decimal K17
        {
            get
            {
                return k17;
            }
            set
            {
                k17 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_17Specified", DataType = "boolean")]
        public bool K17Specified
        {
            get
            {
                return k17Specified;
            }
            set
            {
                k17Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_18", DataType = "decimal")]
        public decimal K18
        {
            get
            {
                return k18;
            }
            set
            {
                k18 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_18Specified", DataType = "boolean")]
        public bool K18Specified
        {
            get
            {
                return k18Specified;
            }
            set
            {
                k18Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_19", DataType = "decimal")]
        public decimal K19
        {
            get
            {
                return k19;
            }
            set
            {
                k19 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_19Specified", DataType = "boolean")]
        public bool K19Specified
        {
            get
            {
                return k19Specified;
            }
            set
            {
                k19Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_20", DataType = "decimal")]
        public decimal K20
        {
            get
            {
                return k20;
            }
            set
            {
                k20 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_20Specified", DataType = "boolean")]
        public bool K20Specified
        {
            get
            {
                return k20Specified;
            }
            set
            {
                k20Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_21", DataType = "decimal")]
        public decimal K21
        {
            get
            {
                return k21;
            }
            set
            {
                k21 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_21Specified", DataType = "boolean")]
        public bool K21Specified
        {
            get
            {
                return k21Specified;
            }
            set
            {
                k21Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_22", DataType = "decimal")]
        public decimal K22
        {
            get
            {
                return k22;
            }
            set
            {
                k22 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_22Specified", DataType = "boolean")]
        public bool K22Specified
        {
            get
            {
                return k22Specified;
            }
            set
            {
                k22Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_23", DataType = "decimal")]
        public decimal K23
        {
            get
            {
                return k23;
            }
            set
            {
                k23 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_23Specified", DataType = "boolean")]
        public bool K23Specified
        {
            get
            {
                return k23Specified;
            }
            set
            {
                k23Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_24", DataType = "decimal")]
        public decimal K24
        {
            get
            {
                return k24;
            }
            set
            {
                k24 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_24Specified", DataType = "boolean")]
        public bool K24Specified
        {
            get
            {
                return k24Specified;
            }
            set
            {
                k24Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_25", DataType = "decimal")]
        public decimal K25
        {
            get
            {
                return k25;
            }
            set
            {
                k25 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_25Specified", DataType = "boolean")]
        public bool K25Specified
        {
            get
            {
                return k25Specified;
            }
            set
            {
                k25Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_26", DataType = "decimal")]
        public decimal K26
        {
            get
            {
                return k26;
            }
            set
            {
                k26 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_26Specified", DataType = "boolean")]
        public bool K26Specified
        {
            get
            {
                return k26Specified;
            }
            set
            {
                k26Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_27", DataType = "decimal")]
        public decimal K27
        {
            get
            {
                return k27;
            }
            set
            {
                k27 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_27Specified", DataType = "boolean")]
        public bool K27Specified
        {
            get
            {
                return k27Specified;
            }
            set
            {
                k27Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_28", DataType = "decimal")]
        public decimal K28
        {
            get
            {
                return k28;
            }
            set
            {
                k28 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_28Specified", DataType = "boolean")]
        public bool K28Specified
        {
            get
            {
                return k28Specified;
            }
            set
            {
                k28Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_29", DataType = "decimal")]
        public decimal K29
        {
            get
            {
                return k29;
            }
            set
            {
                k29 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_29Specified", DataType = "boolean")]
        public bool K29Specified
        {
            get
            {
                return k29Specified;
            }
            set
            {
                k29Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_30", DataType = "decimal")]
        public decimal K30
        {
            get
            {
                return k30;
            }
            set
            {
                k30 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_30Specified", DataType = "boolean")]
        public bool K30Specified
        {
            get
            {
                return k30Specified;
            }
            set
            {
                k30Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_31", DataType = "decimal")]
        public decimal K31
        {
            get
            {
                return k31;
            }
            set
            {
                k31 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_31Specified", DataType = "boolean")]
        public bool K31Specified
        {
            get
            {
                return k31Specified;
            }
            set
            {
                k31Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_32", DataType = "decimal")]
        public decimal K32
        {
            get
            {
                return k32;
            }
            set
            {
                k32 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_32Specified", DataType = "boolean")]
        public bool K32Specified
        {
            get
            {
                return k32Specified;
            }
            set
            {
                k32Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_33", DataType = "decimal")]
        public decimal K33
        {
            get
            {
                return k33;
            }
            set
            {
                k33 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_33Specified", DataType = "boolean")]
        public bool K33Specified
        {
            get
            {
                return k33Specified;
            }
            set
            {
                k33Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_34", DataType = "decimal")]
        public decimal K34
        {
            get
            {
                return k34;
            }
            set
            {
                k34 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_34Specified", DataType = "boolean")]
        public bool K34Specified
        {
            get
            {
                return k34Specified;
            }
            set
            {
                k34Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_35", DataType = "decimal")]
        public decimal K35
        {
            get
            {
                return k35;
            }
            set
            {
                k35 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_35Specified", DataType = "boolean")]
        public bool K35Specified
        {
            get
            {
                return k35Specified;
            }
            set
            {
                k35Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_36", DataType = "decimal")]
        public decimal K36
        {
            get
            {
                return k36;
            }
            set
            {
                k36 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_36Specified", DataType = "boolean")]
        public bool K36Specified
        {
            get
            {
                return k36Specified;
            }
            set
            {
                k36Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_37", DataType = "decimal")]
        public decimal K37
        {
            get
            {
                return k37;
            }
            set
            {
                k37 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_37Specified", DataType = "boolean")]
        public bool K37Specified
        {
            get
            {
                return k37Specified;
            }
            set
            {
                k37Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_38", DataType = "decimal")]
        public decimal K38
        {
            get
            {
                return k38;
            }
            set
            {
                k38 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_38Specified", DataType = "boolean")]
        public bool K38Specified
        {
            get
            {
                return k38Specified;
            }
            set
            {
                k38Specified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "K_39", DataType = "decimal")]
        public decimal K39
        {
            get
            {
                return k39;
            }
            set
            {
                k39 = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "K_39Specified", DataType = "boolean")]
        public bool K39Specified
        {
            get
            {
                return k39Specified;
            }
            set
            {
                k39Specified = value;
                RaisePropertyChanged();
            }
        }
    }
}
