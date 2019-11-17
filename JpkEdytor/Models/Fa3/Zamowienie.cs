namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKZamowienie", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class Zamowienie : NotifyPropertyChanged
    {
        private string p2AZ;

        private decimal wartoscZamowienia;

        private ObservableCollection<ZamowienieWiersz> zamowienieWiersz;

        public Zamowienie()
        {
            ZamowienieWiersz = new ObservableCollection<ZamowienieWiersz>();
        }

        [XmlElement(ElementName = "P_2AZ", DataType = "token")]
        public string P2AZ
        {
            get
            {
                return p2AZ;
            }
            set
            {
                p2AZ = value;
                RaisePropertyChanged();
            }
        }

        public decimal WartoscZamowienia
        {
            get
            {
                return wartoscZamowienia;
            }
            set
            {
                wartoscZamowienia = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement("ZamowienieWiersz")]
        public ObservableCollection<ZamowienieWiersz> ZamowienieWiersz
        {
            get
            {
                return zamowienieWiersz;
            }
            set
            {
                zamowienieWiersz = value;
                RaisePropertyChanged();
            }
        }
    }
}
