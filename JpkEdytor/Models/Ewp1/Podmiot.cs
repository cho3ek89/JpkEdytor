namespace JpkEdytor.Models.Ewp1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03097/")]
    public sealed class Podmiot : NotifyPropertyChanged
    {
        private IdentyfikatorOsobyNiefizycznejV40 identyfikatorPodmiotu;

        private AdresPolskiV40 adresPodmiotu;

        public IdentyfikatorOsobyNiefizycznejV40 IdentyfikatorPodmiotu
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

        public AdresPolskiV40 AdresPodmiotu
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
