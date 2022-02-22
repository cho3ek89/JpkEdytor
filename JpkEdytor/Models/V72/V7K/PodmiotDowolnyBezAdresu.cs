namespace JpkEdytor.Models.V72.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TPodmiotDowolnyBezAdresu", Namespace = "http://crd.gov.pl/wzor/2021/07/08/07082/")]
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
