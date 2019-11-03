namespace JpkEdytor.Models.Kr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03091/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03091/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private Naglowek naglowek;

        private Podmiot podmiot;

        private ObservableCollection<Zois> zois;

        private ObservableCollection<Dziennik> dziennik;

        private DziennikCtrl dziennikCtrl;

        private ObservableCollection<KontoZapis> kontoZapis;

        private KontoZapisCtrl kontoZapisCtrl;

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

        [XmlElement(ElementName = "ZOiS")]
        public ObservableCollection<Zois> Zois
        {
            get
            {
                return zois;
            }
            set
            {
                zois = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "Dziennik")]
        public ObservableCollection<Dziennik> Dziennik
        {
            get
            {
                return dziennik;
            }
            set
            {
                dziennik = value;
                RaisePropertyChanged();
            }
        }

        public DziennikCtrl DziennikCtrl
        {
            get
            {
                return dziennikCtrl;
            }
            set
            {
                dziennikCtrl = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "KontoZapis")]
        public ObservableCollection<KontoZapis> KontoZapis
        {
            get
            {
                return kontoZapis;
            }
            set
            {
                kontoZapis = value;
                RaisePropertyChanged();
            }
        }

        public KontoZapisCtrl KontoZapisCtrl
        {
            get
            {
                return kontoZapisCtrl;
            }
            set
            {
                kontoZapisCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
