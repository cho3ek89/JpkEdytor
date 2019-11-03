namespace JpkEdytor.Models.Pkpir2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10262/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10262/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private Naglowek naglowek;

        private Podmiot podmiot;

        private PkpirInfo pkpirInfo;

        private ObservableCollection<PkpirSpis> pkpirSpis;

        private ObservableCollection<PkpirWiersz> pkpirWiersze;

        private PkpirCtrl pkpirCtrl;

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

        [XmlElement(ElementName = "PKPIRInfo")]
        public PkpirInfo PkpirInfo
        {
            get
            {
                return pkpirInfo;
            }
            set
            {
                pkpirInfo = value;
                RaisePropertyChanged();
            }
        }
        
        [XmlElement(ElementName = "PKPIRSpis")]
        public ObservableCollection<PkpirSpis> PkpirSpis
        {
            get
            {
                return pkpirSpis;
            }
            set
            {
                pkpirSpis = value;
                RaisePropertyChanged();
            }
        }
        
        [XmlElement(ElementName = "PKPIRWiersz")]
        public ObservableCollection<PkpirWiersz> PkpirWiersze
        {
            get
            {
                return pkpirWiersze;
            }
            set
            {
                pkpirWiersze = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "PKPIRCtrl")]
        public PkpirCtrl PkpirCtrl
        {
            get
            {
                return pkpirCtrl;
            }
            set
            {
                pkpirCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
