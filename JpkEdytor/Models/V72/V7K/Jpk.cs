namespace JpkEdytor.Models.V72.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07082/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://crd.gov.pl/wzor/2021/07/08/07082/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpkV72
    {
        private JpkNaglowek naglowek;

        private Podmiot podmiot;

        private Deklaracja deklaracja;

        private bool deklaracjaSpecified;

        private Ewidencja ewidencja;

        private bool ewidencjaSpecified;

        public Jpk()
        {
            Naglowek = new JpkNaglowek();
            Podmiot = new Podmiot
            {
                Item = new PodmiotDowolnyBezAdresuOsobaFizyczna(),
            };

            Deklaracja = null;
            DeklaracjaSpecified = false;

            Ewidencja = new Ewidencja();
            EwidencjaSpecified = true;
        }

        public JpkNaglowek Naglowek
        {
            get
            {
                return naglowek;
            }
            set
            {
                naglowek = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "Podmiot1")]
        public Podmiot Podmiot
        {
            get
            {
                return podmiot;
            }
            set
            {
                podmiot = value;
                RaisePropertyChanged();
            }
        }
        
        public Deklaracja Deklaracja
        {
            get
            {
                return deklaracja;
            }
            set
            {
                deklaracja = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "DeklaracjaSpecified", DataType = "boolean")]
        public bool DeklaracjaSpecified
        {
            get
            {
                return deklaracjaSpecified;
            }
            set
            {
                deklaracjaSpecified = value;
                RaisePropertyChanged();
            }
        }

        public Ewidencja Ewidencja
        {
            get
            {
                return ewidencja;
            }
            set
            {
                ewidencja = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        [XmlElement(ElementName = "EwidencjaSpecified", DataType = "boolean")]
        public bool EwidencjaSpecified
        {
            get
            {
                return ewidencjaSpecified;
            }
            set
            {
                ewidencjaSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}
