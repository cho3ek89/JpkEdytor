namespace JpkEdytor.Models.V72.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TPodmiotDowolnyBezAdresuOsobaNiefizyczna", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07082/")]
    public sealed class PodmiotDowolnyBezAdresuOsobaNiefizyczna : IdentyfikatorOsobyNiefizycznej
    {
        private string email;

        private string telefon;

        private bool telefonSpecified;

        [XmlElement(DataType = "token")]
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool TelefonSpecified
        {
            get
            {
                return telefonSpecified;
            }
            set
            {
                telefonSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
