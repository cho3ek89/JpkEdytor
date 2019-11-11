namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaRRWierszCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class FakturaRrWierszCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszyFakturRr;

        private decimal wartoscWierszyFakturRr;

        [XmlElement(ElementName = "LiczbaWierszyFakturRR", DataType = "nonNegativeInteger")]
        public string LiczbaWierszyFakturRr
        {
            get
            {
                return liczbaWierszyFakturRr;
            }
            set
            {
                liczbaWierszyFakturRr = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "WartoscWierszyFakturRR")]
        public decimal WartoscWierszyFakturRr
        {
            get
            {
                return wartoscWierszyFakturRr;
            }
            set
            {
                wartoscWierszyFakturRr = value;
                RaisePropertyChanged();
            }
        }
    }
}
