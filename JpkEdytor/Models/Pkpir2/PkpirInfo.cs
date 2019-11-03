namespace JpkEdytor.Models.Pkpir2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKPKPIRInfo", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10262/")]
    public sealed class PkpirInfo : NotifyPropertyChanged
    {
        private decimal p1;

        private decimal p2;

        private decimal p3;

        private decimal p4;

        [XmlElement(ElementName = "P_1", DataType = "decimal")]
        public decimal P1
        {
            get
            {
                return p1;
            }
            set
            {
                p1 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_2", DataType = "decimal")]
        public decimal P2
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_3", DataType = "decimal")]
        public decimal P3
        {
            get
            {
                return p3;
            }
            set
            {
                p3 = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "P_4", DataType = "decimal")]
        public decimal P4
        {
            get
            {
                return p4;
            }
            set
            {
                p4 = value;
                RaisePropertyChanged();
            }
        }
    }
}
