namespace JpkEdytor.Models.Vat3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPodmiot1", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
    public sealed class Podmiot : NotifyPropertyChanged
    {
        private string nip;

        private string pelnaNazwa;

        private string email;

        private bool emailSpecified;

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

        [XmlIgnore]
        public bool EmailSpecified
        {
            get
            {
                return emailSpecified;
            }
            set
            {
                emailSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
