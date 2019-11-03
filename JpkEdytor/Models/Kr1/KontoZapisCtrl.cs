namespace JpkEdytor.Models.Kr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKKontoZapisCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03091/")]
    public sealed class KontoZapisCtrl : NotifyPropertyChanged
    {
        private string liczbaWierszyKontoZapisu;

        private decimal sumaWinien;

        private decimal sumaMa;

        [XmlElement(ElementName = "LiczbaWierszyKontoZapisj", DataType = "nonNegativeInteger")]
        public string LiczbaWierszyKontoZapisu
        {
            get
            {
                return liczbaWierszyKontoZapisu;
            }
            set
            {
                liczbaWierszyKontoZapisu = value;
                RaisePropertyChanged();
            }
        }

        public decimal SumaWinien
        {
            get
            {
                return sumaWinien;
            }
            set
            {
                sumaWinien = value;
                RaisePropertyChanged();
            }
        }

        public decimal SumaMa
        {
            get
            {
                return sumaMa;
            }
            set
            {
                sumaMa = value;
                RaisePropertyChanged();
            }
        }
    }
}
