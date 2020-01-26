namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaRR", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class FakturaRr : NotifyPropertyChanged
    {
        private string p1A;

        private string p_1B;

        private string p_1C;

        private string p1D;

        private string p2A;

        private string p2B;

        private Podpis p3A;

        private Podpis p3B;

        private DateTime p4A;

        private DateTime p4B;

        private string p4C1;

        private decimal p11_1;

        private decimal p11_2;

        private decimal p12_1;

        private string p12_2;

        private bool p116_3;

        private RodzajFaktury rodzajFaktury;

        private string przyczynaKorekty;

        private bool przyczynaKorektySpecified;

        private string nrFaKorygowanej;

        private bool nrFaKorygowanejSpecified;

        private string okresFaKorygowanej;

        private bool okresFaKorygowanejSpecified;

        private string dokument;

        private bool dokumentSpecified;

        private string typField;

        public FakturaRr()
        {
            P3A = new Podpis();
            P3B = new Podpis();

            P116_3 = false;
            Typ = "G";
        }

        [XmlElement(ElementName = "P_1A", DataType = "token")]
        public string P1A
        {
            get
            {
                return p1A;
            }
            set
            {
                p1A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_1B", DataType = "token")]
        public string P1B
        {
            get
            {
                return p_1B;
            }
            set
            {
                p_1B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_1C", DataType = "token")]
        public string P1C
        {
            get
            {
                return p_1C;
            }
            set
            {
                p_1C = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_1D", DataType = "token")]
        public string P1D
        {
            get
            {
                return p1D;
            }
            set
            {
                p1D = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_2A")]
        public string P2A
        {
            get
            {
                return p2A;
            }
            set
            {
                p2A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_2B")]
        public string P2B
        {
            get
            {
                return p2B;
            }
            set
            {
                p2B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3A")]
        public Podpis P3A
        {
            get
            {
                return p3A;
            }
            set
            {
                p3A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3B")]
        public Podpis P3B
        {
            get
            {
                return p3B;
            }
            set
            {
                p3B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_4A", DataType = "date")]
        public DateTime P4A
        {
            get
            {
                return p4A;
            }
            set
            {
                p4A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_4B", DataType = "date")]
        public DateTime P4B
        {
            get
            {
                return p4B;
            }
            set
            {
                p4B = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_4C1", DataType = "token")]
        public string P4C1
        {
            get
            {
                return p4C1;
            }
            set
            {
                p4C1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_11_1")]
        public decimal P11_1
        {
            get
            {
                return p11_1;
            }
            set
            {
                p11_1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_11_2")]
        public decimal P11_2
        {
            get
            {
                return p11_2;
            }
            set
            {
                p11_2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_12_1")]
        public decimal P12_1
        {
            get
            {
                return p12_1;
            }
            set
            {
                p12_1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_12_2", DataType = "token")]
        public string P12_2
        {
            get
            {
                return p12_2;
            }
            set
            {
                p12_2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_116_3")]
        public bool P116_3
        {
            get
            {
                return p116_3;
            }
            set
            {
                p116_3 = value;
                RaisePropertyChanged();
            }
        }

        public RodzajFaktury RodzajFaktury
        {
            get
            {
                return rodzajFaktury;
            }
            set
            {
                rodzajFaktury = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string PrzyczynaKorekty
        {
            get
            {
                return przyczynaKorekty;
            }
            set
            {
                przyczynaKorekty = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "PrzyczynaKorektySpecified")]
        [XmlIgnore]
        public bool PrzyczynaKorektySpecified
        {
            get
            {
                return przyczynaKorektySpecified;
            }
            set
            {
                przyczynaKorektySpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string NrFaKorygowanej
        {
            get
            {
                return nrFaKorygowanej;
            }
            set
            {
                nrFaKorygowanej = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "NrFaKorygowanejSpecified")]
        [XmlIgnore]
        public bool NrFaKorygowanejSpecified
        {
            get
            {
                return nrFaKorygowanejSpecified;
            }
            set
            {
                nrFaKorygowanejSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string OkresFaKorygowanej
        {
            get
            {
                return okresFaKorygowanej;
            }
            set
            {
                okresFaKorygowanej = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "OkresFaKorygowanejSpecified")]
        [XmlIgnore]
        public bool OkresFaKorygowanejSpecified
        {
            get
            {
                return okresFaKorygowanejSpecified;
            }
            set
            {
                okresFaKorygowanejSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Dokument
        {
            get
            {
                return dokument;
            }
            set
            {
                dokument = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "DokumentSpecified")]
        [XmlIgnore]
        public bool DokumentSpecified
        {
            get
            {
                return dokumentSpecified;
            }
            set
            {
                dokumentSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlAttribute(AttributeName = "typ")]
        public string Typ
        {
            get
            {
                return typField;
            }
            set
            {
                typField = value;
                RaisePropertyChanged();
            }
        }
    }
}
