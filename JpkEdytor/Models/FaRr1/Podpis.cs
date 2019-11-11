namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "TPodpis", Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class Podpis : NotifyPropertyChanged
    {
        private string numerSeryjnyField;

        private string wystawcaField;

        private string posiadaczField;

        public string NumerSeryjny
        {
            get
            {
                return numerSeryjnyField;
            }
            set
            {
                numerSeryjnyField = value;
                RaisePropertyChanged();
            }
        }

        public string Wystawca
        {
            get
            {
                return wystawcaField;
            }
            set
            {
                wystawcaField = value;
                RaisePropertyChanged();
            }
        }

        public string Posiadacz
        {
            get
            {
                return posiadaczField;
            }
            set
            {
                posiadaczField = value;
                RaisePropertyChanged();
            }
        }
    }
}
