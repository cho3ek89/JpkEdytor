namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private JpkNaglowek naglowek;

        private Podmiot podmiot;

        private ObservableCollection<FakturaRr> fakturaRr;

        private FakturaRrCtrl fakturaRrCtrl;

        private ObservableCollection<FakturaRrWiersz> fakturaRrWiersz;

        private FakturaRrWierszCtrl fakturaRrWierszCtrl;

        private ObservableCollection<Oswiadczenie> oswiadczenie;

        private OswiadczenieCtrl oswiadczenieCtrl;
        
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

        [XmlElement(ElementName = "FakturaRR")]
        public ObservableCollection<FakturaRr> FakturaRr
        {
            get
            {
                return fakturaRr;
            }
            set
            {
                fakturaRr = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "FakturaRRCtrl")]
        public FakturaRrCtrl FakturaRrCtrl
        {
            get
            {
                return fakturaRrCtrl;
            }
            set
            {
                fakturaRrCtrl = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "FakturaRRWiersz")]
        public ObservableCollection<FakturaRrWiersz> FakturaRrWiersz
        {
            get
            {
                return fakturaRrWiersz;
            }
            set
            {
                fakturaRrWiersz = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "FakturaRRWierszCtrl")]
        public FakturaRrWierszCtrl FakturaRrWierszCtrl
        {
            get
            {
                return fakturaRrWierszCtrl;
            }
            set
            {
                fakturaRrWierszCtrl = value;
                RaisePropertyChanged();
            }
        }
        
        [XmlElement(ElementName = "Oswiadczenie")]
        public ObservableCollection<Oswiadczenie> Oswiadczenie
        {
            get
            {
                return oswiadczenie;
            }
            set
            {
                oswiadczenie = value;
                RaisePropertyChanged();
            }
        }

        public OswiadczenieCtrl OswiadczenieCtrl
        {
            get
            {
                return oswiadczenieCtrl;
            }
            set
            {
                oswiadczenieCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
