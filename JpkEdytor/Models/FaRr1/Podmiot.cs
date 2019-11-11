namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class Podmiot : NotifyPropertyChanged
    {
        private IdentyfikatorOsobyNiefizycznej1V50 identyfikatorPodmiotu;

        private AdresPolski1V50 adresPodmiotu;

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

        public AdresPolski1V50 AdresPodmiotu
        {
            get
            {
                return adresPodmiotu;
            }
            set
            {
                adresPodmiotu = value;
                RaisePropertyChanged();
            }
        }
    }
}
