namespace JpkEdytor.Models.V71.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKEwidencjaZakupCtrl", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9394/")]
    public sealed class EwidencjaZakupCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszyZakupow;

        private decimal podatekNaliczony;

        public EwidencjaZakupCtrl()
        {
            LiczbaWierszyZakupow = "0";
        }

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaWierszyZakupow
        {
            get
            {
                return liczbaWierszyZakupow;
            }
            set
            {
                liczbaWierszyZakupow = value;
                RaisePropertyChanged();
            }
        }

        public decimal PodatekNaliczony
        {
            get
            {
                return podatekNaliczony;
            }
            set
            {
                podatekNaliczony = value;
                RaisePropertyChanged();
            }
        }
    }
}
