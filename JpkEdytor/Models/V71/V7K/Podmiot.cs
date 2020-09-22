namespace JpkEdytor.Models.V71.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9394/")]
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
