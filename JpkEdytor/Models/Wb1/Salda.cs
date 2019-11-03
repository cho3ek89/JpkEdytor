namespace JpkEdytor.Models.Wb1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKSalda", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03092/")]
    public sealed class Salda : NotifyPropertyChanged
    {
        private decimal saldoPoczatkowe;

        private decimal saldoKoncowe;

        public decimal SaldoPoczatkowe
        {
            get
            {
                return saldoPoczatkowe;
            }
            set
            {
                saldoPoczatkowe = value;
                RaisePropertyChanged();
            }
        }

        public decimal SaldoKoncowe
        {
            get
            {
                return saldoKoncowe;
            }
            set
            {
                saldoKoncowe = value;
                RaisePropertyChanged();
            }
        }
    }
}
