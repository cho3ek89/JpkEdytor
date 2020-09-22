namespace JpkEdytor.Models.V71.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TPodmiotDowolnyBezAdresu", Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public abstract class PodmiotDowolnyBezAdresu : NotifyPropertyChanged
    {
        private object item;

        [XmlElement("OsobaFizyczna", typeof(PodmiotDowolnyBezAdresuOsobaFizyczna))]
        [XmlElement("OsobaNiefizyczna", typeof(PodmiotDowolnyBezAdresuOsobaNiefizyczna))]
        public object Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                RaisePropertyChanged();
            }
        }
    }
}
