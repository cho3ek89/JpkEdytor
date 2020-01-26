namespace JpkEdytor.Models.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "TIdentyfikatorOsobyNiefizycznej", Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public sealed class IdentyfikatorOsobyNiefizycznejV50 : NotifyPropertyChanged
    {
        private string nip;

        private string pelnaNazwa;

        private string regon;

        private bool regonSpecified;

        [XmlElement(ElementName = "NIP", DataType = "token")]
        public string Nip
        {
            get
            {
                return nip;
            }
            set
            {
                nip = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string PelnaNazwa
        {
            get
            {
                return pelnaNazwa;
            }
            set
            {
                pelnaNazwa = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "REGON", DataType = "token")]
        public string Regon
        {
            get
            {
                return regon;
            }
            set
            {
                regon = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "REGONSpecified", DataType = "boolean")]
        public bool RegonSpecified
        {
            get
            {
                return regonSpecified;
            }
            set
            {
                regonSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
