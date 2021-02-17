namespace JpkEdytor.Models.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TIdentyfikatorOsobyNiefizycznej1", Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2020/03/11/eD/DefinicjeTypy/")]
    public sealed class IdentyfikatorOsobyNiefizycznej1V60 : NotifyPropertyChanged
    {
        private string nip;

        private string pelnaNazwa;

        [XmlElement(ElementName = "NIP")]
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
    }
}
