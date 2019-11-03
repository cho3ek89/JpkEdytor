namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKMM", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class Mm : NotifyPropertyChanged
    {
        private ObservableCollection<MmWartosc> mmWartosc;

        private ObservableCollection<MmWiersz> mmWiersz;

        private MmCtrl mmCtrl;

        [XmlElement(ElementName = "MMWartosc")]
        public ObservableCollection<MmWartosc> MmWartosc
        {
            get
            {
                return mmWartosc;
            }
            set
            {
                mmWartosc = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "MMWiersz")]
        public ObservableCollection<MmWiersz> MmWiersz
        {
            get
            {
                return mmWiersz;
            }
            set
            {
                mmWiersz = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "MMCtrl")]
        public MmCtrl MmCtrl
        {
            get
            {
                return mmCtrl;
            }
            set
            {
                mmCtrl = value;
                RaisePropertyChanged();
            }
        }
    }
}
