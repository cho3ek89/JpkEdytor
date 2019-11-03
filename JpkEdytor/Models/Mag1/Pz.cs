namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPZ", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class Pz : NotifyPropertyChanged
    {
        private ObservableCollection<PzWartosc> pzWartosc;

        private ObservableCollection<PzWiersz> pzWiersz;

        private PzCtrl pzCtrl;

        [XmlElement(ElementName = "PZWartosc")]
        public ObservableCollection<PzWartosc> PzWartosc
        {
            get
            {
                return pzWartosc;
            }
            set
            {
                pzWartosc = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "PZWiersz")]
        public ObservableCollection<PzWiersz> PzWiersz
        {
            get
            {
                return pzWiersz;
            }
            set
            {
                pzWiersz = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "PZCtrl")]
        public PzCtrl PzCtrl
        {
            get
            {
                return pzCtrl;
            }
            set
            {
                pzCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
