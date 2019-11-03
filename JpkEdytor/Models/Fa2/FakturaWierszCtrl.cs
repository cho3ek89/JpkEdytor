namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaWierszCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public sealed class FakturaWierszCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszyFaktur;

        private decimal wartoscWierszyFaktur;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaWierszyFaktur
        {
            get
            {
                return liczbaWierszyFaktur;
            }
            set
            {
                liczbaWierszyFaktur = value;
                RaisePropertyChanged();
            }
        }

        public decimal WartoscWierszyFaktur
        {
            get
            {
                return wartoscWierszyFaktur;
            }
            set
            {
                wartoscWierszyFaktur = value;
                RaisePropertyChanged();
            }
        }
    }
}
