namespace JpkEdytor.Models.Ewp2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2021/01/25/01251/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2021/01/25/01251/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private Naglowek naglowek;

        private Podmiot podmiot;

        private ObservableCollection<EwpWiersz> ewpWiersze;

        private EwpCtrl ewpCtrl;
        
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
        
        [XmlElement(ElementName = "EWPWiersz")]
        public ObservableCollection<EwpWiersz> EwpWiersze
        {
            get
            {
                return ewpWiersze;
            }
            set
            {
                ewpWiersze = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "EWPCtrl")]
        public EwpCtrl EwpCtrl
        {
            get
            {
                return ewpCtrl;
            }
            set
            {
                ewpCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
