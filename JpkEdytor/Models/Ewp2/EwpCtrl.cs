namespace JpkEdytor.Models.Ewp2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKEWPCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2021/01/25/01251/")]
    public sealed class EwpCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszy;

        private decimal sumaPrzychodow;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaWierszy
        {
            get
            {
                return liczbaWierszy;
            }
            set
            {
                liczbaWierszy = value;
                RaisePropertyChanged();
            }
        }

        public decimal SumaPrzychodow
        {
            get
            {
                return sumaPrzychodow;
            }
            set
            {
                sumaPrzychodow = value;
                RaisePropertyChanged();
            }
        }
    }
}
