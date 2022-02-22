namespace JpkEdytor.Models.V72.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKEwidencjaSprzedazCtrl", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07081/")]
    public sealed class EwidencjaSprzedazCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszySprzedazy;

        private decimal podatekNalezny;

        public EwidencjaSprzedazCtrl()
        {
            LiczbaWierszySprzedazy = "0";
        }

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaWierszySprzedazy
        {
            get
            {
                return liczbaWierszySprzedazy;
            }
            set
            {
                liczbaWierszySprzedazy = value;
                RaisePropertyChanged();
            }
        }

        public decimal PodatekNalezny
        {
            get
            {
                return podatekNalezny;
            }
            set
            {
                podatekNalezny = value;
                RaisePropertyChanged();
            }
        }
    }
}
