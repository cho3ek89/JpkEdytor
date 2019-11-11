namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaRRCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class FakturaRrCtrl : NotifyPropertyChanged
    {
        private string liczbaFakturRr;

        private decimal wartoscFakturRr;

        [XmlElement(ElementName = "LiczbaFakturRR", DataType = "nonNegativeInteger")]
        public string LiczbaFakturRr
        {
            get
            {
                return liczbaFakturRr;
            }
            set
            {
                liczbaFakturRr = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "WartoscFakturRR")]
        public decimal WartoscFakturRr
        {
            get
            {
                return wartoscFakturRr;
            }
            set
            {
                wartoscFakturRr = value;
                RaisePropertyChanged();
            }
        }
    }
}
