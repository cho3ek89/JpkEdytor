namespace JpkEdytor.Models.Wb1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKWyciagCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03092/")]
    public sealed class WyciagCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszy;

        private decimal sumaObciazen;

        private decimal sumaUznan;

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

        public decimal SumaObciazen
        {
            get
            {
                return sumaObciazen;
            }
            set
            {
                sumaObciazen = value;
                RaisePropertyChanged();
            }
        }

        public decimal SumaUznan
        {
            get
            {
                return sumaUznan;
            }
            set
            {
                sumaUznan = value;
                RaisePropertyChanged();
            }
        }
    }
}
