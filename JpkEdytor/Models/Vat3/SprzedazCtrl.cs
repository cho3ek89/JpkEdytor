namespace JpkEdytor.Models.Vat3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKSprzedazCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
    public sealed class SprzedazCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszySprzedazy;

        private decimal podatekNalezny;

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
