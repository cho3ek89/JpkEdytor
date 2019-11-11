namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKOswiadczenieCtrl", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class OswiadczenieCtrl : NotifyPropertyChanged
    {
        private string liczbaOswiadczen;

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LiczbaOswiadczen
        {
            get
            {
                return liczbaOswiadczen;
            }
            set
            {
                liczbaOswiadczen = value;
                RaisePropertyChanged();
            }
        }
    }
}
