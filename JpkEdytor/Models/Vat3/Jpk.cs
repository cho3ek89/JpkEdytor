namespace JpkEdytor.Models.Vat3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private Naglowek naglowek;

        private Podmiot podmiot;

        private ObservableCollection<SprzedazWiersz> sprzedazWiersz;

        private SprzedazCtrl sprzedazCtrl;

        private ObservableCollection<ZakupWiersz> zakupWiersz;

        private ZakupCtrl zakupCtrl;

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

        [XmlElement(ElementName = "SprzedazWiersz")]
        public ObservableCollection<SprzedazWiersz> SprzedazWiersz
        {
            get
            {
                return sprzedazWiersz;
            }
            set
            {
                sprzedazWiersz = value;
                RaisePropertyChanged();
            }
        }

        public SprzedazCtrl SprzedazCtrl
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
        public ObservableCollection<ZakupWiersz> ZakupWiersz
        {
            get
            {
                return zakupWiersz;
            }
            set
            {
                zakupWiersz = value;
                RaisePropertyChanged();
            }
        }

        public ZakupCtrl ZakupCtrl
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
