namespace JpkEdytor.Models.Vat3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKZakupCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
    public sealed class ZakupCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszyZakupow;

        private decimal podatekNaliczony;

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
