namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKStawkiPodatku", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public sealed class StawkiPodatku : NotifyPropertyChanged
    {
        private decimal stawka1;

        private decimal stawka2;

        private decimal stawka3;

        private decimal stawka4;

        private decimal stawka5;

        public StawkiPodatku()
        {
            Stawka1 = ((decimal)(0.23m));
            Stawka2 = ((decimal)(0.08m));
            Stawka3 = ((decimal)(0.05m));
            Stawka4 = ((decimal)(0.00m));
            Stawka5 = ((decimal)(0.00m));
        }

        public decimal Stawka1
        {
            get
            {
                return stawka1;
            }
            set
            {
                stawka1 = value;
                RaisePropertyChanged();
            }
        }

        public decimal Stawka2
        {
            get
            {
                return stawka2;
            }
            set
            {
                stawka2 = value;
                RaisePropertyChanged();
            }
        }

        public decimal Stawka3
        {
            get
            {
                return stawka3;
            }
            set
            {
                stawka3 = value;
                RaisePropertyChanged();
            }
        }

        public decimal Stawka4
        {
            get
            {
                return stawka4;
            }
            set
            {
                stawka4 = value;
                RaisePropertyChanged();
            }
        }

        public decimal Stawka5
        {
            get
            {
                return stawka5;
            }
            set
            {
                stawka5 = value;
                RaisePropertyChanged();
            }
        }
    }
}
