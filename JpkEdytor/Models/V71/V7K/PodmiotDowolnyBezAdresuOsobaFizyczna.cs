namespace JpkEdytor.Models.V71.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Models.Common;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TPodmiotDowolnyBezAdresuOsobaFizyczna", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9394/")]
    public sealed class PodmiotDowolnyBezAdresuOsobaFizyczna : IdentyfikatorOsobyFizycznej2V60
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
