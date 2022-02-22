namespace JpkEdytor.Models.V72.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKEwidencja", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07081/")]
    public sealed class Ewidencja : NotifyPropertyChanged
    {
        private ObservableCollection<EwidencjaSprzedazWiersz> sprzedazWiersze;

        private EwidencjaSprzedazCtrl sprzedazCtrl;

        private ObservableCollection<EwidencjaZakupWiersz> zakupWiersze;

        private EwidencjaZakupCtrl zakupCtrl;

        public Ewidencja()
        {
            SprzedazWiersze = new ObservableCollection<EwidencjaSprzedazWiersz>();
            SprzedazCtrl = new EwidencjaSprzedazCtrl();
            ZakupWiersze = new ObservableCollection<EwidencjaZakupWiersz>();
            ZakupCtrl = new EwidencjaZakupCtrl();
        }

        [XmlElement(ElementName = "SprzedazWiersz")]
        public ObservableCollection<EwidencjaSprzedazWiersz> SprzedazWiersze
        {
            get
            {
                return sprzedazWiersze;
            }
            set
            {
                sprzedazWiersze = value;
                RaisePropertyChanged();
            }
        }

        public EwidencjaSprzedazCtrl SprzedazCtrl
        {
            get
            {
                return sprzedazCtrl;
            }
            set
            {
                sprzedazCtrl = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "ZakupWiersz")]
        public ObservableCollection<EwidencjaZakupWiersz> ZakupWiersze
        {
            get
            {
                return zakupWiersze;
            }
            set
            {
                zakupWiersze = value;
                RaisePropertyChanged();
            }
        }

        public EwidencjaZakupCtrl ZakupCtrl
        {
            get
            {
                return zakupCtrl;
            }
            set
            {
                zakupCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
