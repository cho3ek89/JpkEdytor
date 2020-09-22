namespace JpkEdytor.Models.V71.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TIdentyfikatorOsobyNiefizycznej", Namespace = "http://crd.gov.pl/wzor/2020/05/08/9394/")]
    public class IdentyfikatorOsobyNiefizycznej : NotifyPropertyChanged
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
