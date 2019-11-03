namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKMMMMCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class MmCtrl : NotifyPropertyChanged
    {
        private string liczba;

        private decimal suma;

        [XmlElement(ElementName = "LiczbaMM", DataType = "nonNegativeInteger")]
        public string Liczba
        {
            get
            {
                return liczba;
            }
            set
            {
                liczba = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "SumaMM")]
        public decimal Suma
        {
            get
            {
                return suma;
            }
            set
            {
                suma = value;
                RaisePropertyChanged();
            }
        }
    }
}
