namespace JpkEdytor.Models.Pkpir2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10262/")]
    public sealed class Podmiot : NotifyPropertyChanged
    {
        private IdentyfikatorOsobyNiefizycznejV40 identyfikatorPodmiotu;

        private Adres adresPodmiotu;

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

        public Adres AdresPodmiotu
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
