namespace JpkEdytor.Models.Ewp2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2021/01/25/01251/")]
    public sealed class Podmiot : NotifyPropertyChanged
    {
        private IdentyfikatorOsobyNiefizycznej1V60 identyfikatorPodmiotu;

        private AdresPolski1V60 adresPodmiotu;

        public IdentyfikatorOsobyNiefizycznej1V60 IdentyfikatorPodmiotu
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

        public AdresPolski1V60 AdresPodmiotu
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