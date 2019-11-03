namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private Naglowek naglowek;

        private Podmiot podmiot;

        private string magazyn;

        private Pz pz;

        private Wz wz;

        private Rw rw;

        private Mm mm;

        public Naglowek Naglowek
        {
            get
            {
                return naglowek;
            }
            set
            {
                naglowek = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "Podmiot1")]
        public Podmiot Podmiot
        {
            get
            {
                return podmiot;
            }
            set
            {
                podmiot = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Magazyn
        {
            get
            {
                return magazyn;
            }
            set
            {
                magazyn = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "PZ")]
        public Pz Pz
        {
            get
            {
                return pz;
            }
            set
            {
                pz = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "WZ")]
        public Wz Wz
        {
            get
            {
                return wz;
            }
            set
            {
                wz = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "RW")]
        public Rw Rw
        {
            get
            {
                return rw;
            }
            set
            {
                rw = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "MM")]
        public Mm Mm
        {
            get
            {
                return mm;
            }
            set
            {
                mm = value;
                RaisePropertyChanged();
            }
        }
    }
}