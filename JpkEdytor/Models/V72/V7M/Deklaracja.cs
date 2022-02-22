namespace JpkEdytor.Models.V72.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKDeklaracja", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07081/")]
    public sealed class Deklaracja : NotifyPropertyChanged
    {
        private DeklaracjaNaglowek naglowek;

        private DeklaracjaPozycjeSzczegolowe pozycjeSzczegolowe;

        private decimal pouczenia;

        public Deklaracja()
        {
            Naglowek = new DeklaracjaNaglowek();
            PozycjeSzczegolowe = new DeklaracjaPozycjeSzczegolowe();
            Pouczenia = 1;
        }

        public DeklaracjaNaglowek Naglowek
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

        public DeklaracjaPozycjeSzczegolowe PozycjeSzczegolowe
        {
            get
            {
                return pozycjeSzczegolowe;
            }
            set
            {
                pozycjeSzczegolowe = value;
                RaisePropertyChanged();
            }
        }

        public decimal Pouczenia
        {
            get
            {
                return pouczenia;
            }
            set
            {
                pouczenia = value;
                RaisePropertyChanged();
            }
        }
    }
}
