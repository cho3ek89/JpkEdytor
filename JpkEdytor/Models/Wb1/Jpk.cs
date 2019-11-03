namespace JpkEdytor.Models.Wb1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;
    using JpkEdytor.ViewModels;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03092/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03092/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private Naglowek naglowek;

        private Podmiot podmiot;

        private string numerRachunku;

        private Salda salda;

        private ObservableCollection<WyciagWiersz> wyciagWiersz;

        private WyciagCtrl wyciagCtrl;

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
        
        public string NumerRachunku
        {
            get
            {
                return numerRachunku;
            }
            set
            {
                numerRachunku = value;
                RaisePropertyChanged();
            }
        }
        
        public Salda Salda
        {
            get
            {
                return salda;
            }
            set
            {
                salda = value;
                RaisePropertyChanged();
            }
        }
        
        [XmlElement(ElementName = "WyciagWiersz")]
        public ObservableCollection<WyciagWiersz> WyciagWiersze
        {
            get
            {
                return wyciagWiersz;
            }
            set
            {
                wyciagWiersz = value;
                RaisePropertyChanged();
            }
        }
        
        public WyciagCtrl WyciagCtrl
        {
            get
            {
                return wyciagCtrl;
            }
            set
            {
                wyciagCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
