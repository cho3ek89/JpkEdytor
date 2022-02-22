namespace JpkEdytor.Models.V72.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKEwidencjaZakupCtrl", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07081/")]
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
