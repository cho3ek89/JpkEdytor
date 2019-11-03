namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private JpkNaglowek naglowek;

        private Podmiot podmiot;

        private ObservableCollection<JpkFaktura> faktura;

        private FakturaCtrl fakturaCtrl;

        private StawkiPodatku stawkiPodatku;

        private ObservableCollection<FakturaWiersz> fakturaWiersz;

        private FakturaWierszCtrl fakturaWierszCtrl;
        
        public JpkNaglowek Naglowek
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

        [XmlElement(ElementName = "Faktura")]
        public ObservableCollection<JpkFaktura> Faktura
        {
            get
            {
                return faktura;
            }
            set
            {
                faktura = value;
                RaisePropertyChanged();
            }
        }
        
        public FakturaCtrl FakturaCtrl
        {
            get
            {
                return fakturaCtrl;
            }
            set
            {
                fakturaCtrl = value;
                RaisePropertyChanged();
            }
        }

        public StawkiPodatku StawkiPodatku
        {
            get
            {
                return stawkiPodatku;
            }
            set
            {
                stawkiPodatku = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "FakturaWiersz")]
        public ObservableCollection<FakturaWiersz> FakturaWiersz
        {
            get
            {
                return fakturaWiersz;
            }
            set
            {
                fakturaWiersz = value;
                RaisePropertyChanged();
            }
        }
        
        public FakturaWierszCtrl FakturaWierszCtrl
        {
            get
            {
                return fakturaWierszCtrl;
            }
            set
            {
                fakturaWierszCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
