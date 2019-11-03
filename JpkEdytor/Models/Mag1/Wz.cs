namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKWZ", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class Wz : NotifyPropertyChanged
    {
        private ObservableCollection<WzWartosc> wzWartosc;

        private ObservableCollection<WzWiersz> wzWiersz;

        private WzCtrl wzCtrl;

        [XmlElement(ElementName = "WZWartosc")]
        public ObservableCollection<WzWartosc> WzWartosc
        {
            get
            {
                return wzWartosc;
            }
            set
            {
                wzWartosc = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "WZWiersz")]
        public ObservableCollection<WzWiersz> WzWiersz
        {
            get
            {
                return wzWiersz;
            }
            set
            {
                wzWiersz = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "WZCtrl")]
        public WzCtrl WzCtrl
        {
            get
            {
                return wzCtrl;
            }
            set
            {
                wzCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
