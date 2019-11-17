namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class FakturaCtrl : NotifyPropertyChanged
    {
        private string liczbaFakturField;

        private decimal wartoscFakturField;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaFaktur
        {
            get
            {
                return liczbaFakturField;
            }
            set
            {
                liczbaFakturField = value;
                RaisePropertyChanged();
            }
        }

        public decimal WartoscFaktur
        {
            get
            {
                return wartoscFakturField;
            }
            set
            {
                wartoscFakturField = value;
                RaisePropertyChanged();
            }
        }
    }
}
