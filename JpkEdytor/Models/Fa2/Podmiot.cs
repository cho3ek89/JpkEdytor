namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public sealed class Podmiot : NotifyPropertyChanged
    {
        private IdentyfikatorOsobyNiefizycznejV50 identyfikatorPodmiotu;

        private AdresPolskiV50 adresPodmiotu;

        public IdentyfikatorOsobyNiefizycznejV50 IdentyfikatorPodmiotu
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

        public AdresPolskiV50 AdresPodmiotu
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
