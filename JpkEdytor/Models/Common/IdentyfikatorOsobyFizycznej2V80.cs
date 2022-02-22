namespace JpkEdytor.Models.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TIdentyfikatorOsobyFizycznej2", Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2021/06/08/eD/DefinicjeTypy/")]
    public class IdentyfikatorOsobyFizycznej2V80 : NotifyPropertyChanged
    {
        private string nip;

        private string imiePierwsze;

        private string nazwisko;

        private DateTime dataUrodzenia;

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
        public string ImiePierwsze
        {
            get
            {
                return imiePierwsze;
            }
            set
            {
                imiePierwsze = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataUrodzenia
        {
            get
            {
                return dataUrodzenia;
            }
            set
            {
                dataUrodzenia = value;
                RaisePropertyChanged();
            }
        }
    }
}
