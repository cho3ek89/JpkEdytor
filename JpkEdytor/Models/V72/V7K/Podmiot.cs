namespace JpkEdytor.Models.V72.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07082/")]
    public sealed class Podmiot : PodmiotDowolnyBezAdresu
    {
        private string rola;

        public Podmiot()
        {
            Rola = "Podatnik";
        }

        [XmlAttribute(AttributeName = "rola")]
        public string Rola
        {
            get
            {
                return rola;
            }
            set
            {
                rola = value;
                RaisePropertyChanged();
            }
        }
    }
}
