namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKOswiadczenie", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class Oswiadczenie : NotifyPropertyChanged
    {
        private string p1A2;

        private string p1B2;

        private string p1C2;

        private string p1D2;

        private string p2A2;

        private string p2B2;

        private DateTime p116_4_1;

        private string p116_4_2;

        private DateTime p116_4_3;

        private Podpis p3A2;

        public Oswiadczenie()
        {
            P3A2 = new Podpis();
        }

        [XmlElement(ElementName = "P_1A2", DataType = "token")]
        public string P1A2
        {
            get
            {
                return p1A2;
            }
            set
            {
                p1A2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_1B2", DataType = "token")]
        public string P1B2
        {
            get
            {
                return p1B2;
            }
            set
            {
                p1B2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_1C2", DataType = "token")]
        public string P1C2
        {
            get
            {
                return p1C2;
            }
            set
            {
                p1C2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_1D2", DataType = "token")]
        public string P1D2
        {
            get
            {
                return p1D2;
            }
            set
            {
                p1D2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_2A2")]
        public string P2A2
        {
            get
            {
                return p2A2;
            }
            set
            {
                p2A2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_2B2")]
        public string P2B2
        {
            get
            {
                return p2B2;
            }
            set
            {
                p2B2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_116_4_1", DataType = "date")]
        public DateTime P116_4_1
        {
            get
            {
                return p116_4_1;
            }
            set
            {
                p116_4_1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_116_4_2", DataType = "token")]
        public string P116_4_2
        {
            get
            {
                return p116_4_2;
            }
            set
            {
                p116_4_2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_116_4_3", DataType = "date")]
        public DateTime P116_4_3
        {
            get
            {
                return p116_4_3;
            }
            set
            {
                p116_4_3 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3A2")]
        public Podpis P3A2
        {
            get
            {
                return p3A2;
            }
            set
            {
                p3A2 = value;
                RaisePropertyChanged();
            }
        }
    }
}
