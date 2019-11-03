namespace JpkEdytor.Models.Kr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKDziennikCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03091/")]
    public sealed class DziennikCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszyDziennika;

        private decimal sumaKwotOperacji;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaWierszyDziennika
        {
            get
            {
                return liczbaWierszyDziennika;
            }
            set
            {
                liczbaWierszyDziennika = value;
                RaisePropertyChanged();
            }
        }

        public decimal SumaKwotOperacji
        {
            get
            {
                return sumaKwotOperacji;
            }
            set
            {
                sumaKwotOperacji = value;
                RaisePropertyChanged();
            }
        }
    }
}
