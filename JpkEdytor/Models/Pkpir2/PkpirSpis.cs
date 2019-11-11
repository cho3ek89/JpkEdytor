namespace JpkEdytor.Models.Pkpir2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPKPIRSpis", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10262/")]
    public sealed class PkpirSpis : NotifyPropertyChanged
    {
        private DateTime p5A;

        private decimal p5B;

        private string typ;

        public PkpirSpis()
        {
            Typ = "G";
        }

        [XmlElement(ElementName = "P_5A", DataType = "date")]
        public DateTime P5A
        {
            get
            {
                return p5A;
            }
            set
            {
                p5A = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_5B", DataType = "decimal")]
        public decimal P5B
        {
            get
            {
                return p5B;
            }
            set
            {
                p5B = value;
                RaisePropertyChanged();
            }
        }

        [XmlAttribute(AttributeName = "typ")]
        public string Typ
        {
            get
            {
                return typ;
            }
            set
            {
                typ = value;
                RaisePropertyChanged();
            }
        }
    }
}
