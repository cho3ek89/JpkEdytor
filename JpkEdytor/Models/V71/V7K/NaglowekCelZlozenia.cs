namespace JpkEdytor.Models.V71.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TNaglowekCelZlozenia", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9394/")]
    public sealed class NaglowekCelZlozenia : NotifyPropertyChanged
    {
        private string poz;

        private string value;

        public NaglowekCelZlozenia()
        {
            Poz = "P_7";
            Value = "1";
        }

        [XmlAttribute(AttributeName = "poz")]
        public string Poz
        {
            get
            {
                return poz;
            }
            set
            {
                poz = value;
                RaisePropertyChanged();
            }
        }

        [XmlText]
        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                RaisePropertyChanged();
            }
        }
    }
}
