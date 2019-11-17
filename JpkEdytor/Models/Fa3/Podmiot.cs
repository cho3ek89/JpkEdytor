namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class Podmiot : NotifyPropertyChanged
    {
        private IdentyfikatorOsobyNiefizycznej1V50 identyfikatorPodmiotu;

        private object item;

        public IdentyfikatorOsobyNiefizycznej1V50 IdentyfikatorPodmiotu
        {
            get
            {
                return identyfikatorPodmiotu;
            }
            set
            {
                identyfikatorPodmiotu = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement("AdresPodmiotu", typeof(AdresPolski1V50))]
        [XmlElement("AdresPodmiotu2", typeof(AdresZagranicznyV50))]
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
