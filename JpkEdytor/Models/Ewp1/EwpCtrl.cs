namespace JpkEdytor.Models.Ewp1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKEWPCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03097/")]
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
