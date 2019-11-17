namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private JpkNaglowek naglowek;

        private Podmiot podmiot;

        private ObservableCollection<JpkFaktura> faktura;

        private FakturaCtrl fakturaCtrl;

        private ObservableCollection<FakturaWiersz> fakturaWiersz;

        private FakturaWierszCtrl fakturaWierszCtrl;

        private ObservableCollection<Zamowienie> zamowienie;

        private ZamowienieCtrl zamowienieCtrl;
        
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
        
        [XmlElement(ElementName = "Zamowienie")]
        public ObservableCollection<Zamowienie> Zamowienie
        {
            get
            {
                return zamowienie;
            }
            set
            {
                zamowienie = value;
                RaisePropertyChanged();
            }
        }
        
        public ZamowienieCtrl ZamowienieCtrl
        {
            get
            {
                return zamowienieCtrl;
            }
            set
            {
                zamowienieCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
