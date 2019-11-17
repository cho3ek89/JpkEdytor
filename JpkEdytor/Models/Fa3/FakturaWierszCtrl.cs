namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaWierszCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class FakturaWierszCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszyFakturField;

        private decimal wartoscWierszyFakturField;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaWierszyFaktur
        {
            get
            {
                return liczbaWierszyFakturField;
            }
            set
            {
                liczbaWierszyFakturField = value;
                RaisePropertyChanged();
            }
        }

        public decimal WartoscWierszyFaktur
        {
            get
            {
                return wartoscWierszyFakturField;
            }
            set
            {
                wartoscWierszyFakturField = value;
                RaisePropertyChanged();
            }
        }
    }
}
