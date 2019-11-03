namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public sealed class FakturaCtrl : NotifyPropertyChanged
    {
        private string liczbaFaktur;

        private decimal wartoscFaktur;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaFaktur
        {
            get
            {
                return liczbaFaktur;
            }
            set
            {
                liczbaFaktur = value;
                RaisePropertyChanged();
            }
        }

        public decimal WartoscFaktur
        {
            get
            {
                return wartoscFaktur;
            }
            set
            {
                wartoscFaktur = value;
                RaisePropertyChanged();
            }
        }
    }
}
