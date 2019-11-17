namespace JpkEdytor.Models.Fa3
{
    
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKZamowienieCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class ZamowienieCtrl : NotifyPropertyChanged
    {
        private string liczbaZamowien;

        private decimal wartoscZamowien;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaZamowien
        {
            get
            {
                return liczbaZamowien;
            }
            set
            {
                liczbaZamowien = value;
                RaisePropertyChanged();
            }
        }

        public decimal WartoscZamowien
        {
            get
            {
                return wartoscZamowien;
            }
            set
            {
                wartoscZamowien = value;
                RaisePropertyChanged();
            }
        }
    }
}
