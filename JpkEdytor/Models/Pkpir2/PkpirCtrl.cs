namespace JpkEdytor.Models.Pkpir2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPKPIRCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10262/")]
    public sealed class PkpirCtrl : NotifyPropertyChanged
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
