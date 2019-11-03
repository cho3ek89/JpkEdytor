namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKRW", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class Rw : NotifyPropertyChanged
    {
        private ObservableCollection<RwWartosc> rwWartosc;

        private ObservableCollection<RwWiersz> rwWiersz;

        private RwCtrl rwCtrl;

        [XmlElement(ElementName = "RWWartosc")]
        public ObservableCollection<RwWartosc> RwWartosc
        {
            get
            {
                return rwWartosc;
            }
            set
            {
                rwWartosc = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "RWWiersz")]
        public ObservableCollection<RwWiersz> RwWiersz
        {
            get
            {
                return rwWiersz;
            }
            set
            {
                rwWiersz = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "RWCtrl")]
        public RwCtrl RwCtrl
        {
            get
            {
                return rwCtrl;
            }
            set
            {
                rwCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
