namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKRWRWCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    public sealed class RwCtrl : NotifyPropertyChanged
    {
        private string liczba;

        private decimal suma;

        [XmlElement(ElementName = "LiczbaRW", DataType = "nonNegativeInteger")]
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

        [XmlElement(ElementName = "SumaRW")]
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
