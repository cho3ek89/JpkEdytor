namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "TNaglowek", Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public class Naglowek : NotifyPropertyChanged
    {
        private NaglowekKodFormularza kodFormularza;

        private sbyte wariantFormularza;

        private sbyte celZlozenia;

        private DateTime dataWytworzeniaJpk;

        private DateTime dataOd;

        private DateTime dataDo;

        private KodUsV50 kodUrzedu;

        public NaglowekKodFormularza KodFormularza
        {
            get
            {
                return kodFormularza;
            }
            set
            {
                kodFormularza = value;
                RaisePropertyChanged();
            }
        }

        public sbyte WariantFormularza
        {
            get
            {
                return wariantFormularza;
            }
            set
            {
                wariantFormularza = value;
                RaisePropertyChanged();
            }
        }

        public sbyte CelZlozenia
        {
            get
            {
                return celZlozenia;
            }
            set
            {
                celZlozenia = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "DataWytworzeniaJPK")]
        public System.DateTime DataWytworzeniaJpk
        {
            get
            {
                return dataWytworzeniaJpk;
            }
            set
            {
                dataWytworzeniaJpk = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public System.DateTime DataOd
        {
            get
            {
                return dataOd;
            }
            set
            {
                dataOd = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime DataDo
        {
            get
            {
                return dataDo;
            }
            set
            {
                dataDo = value;
                RaisePropertyChanged();
            }
        }

        public KodUsV50 KodUrzedu
        {
            get
            {
                return kodUrzedu;
            }
            set
            {
                kodUrzedu = value;
                RaisePropertyChanged();
            }
        }
    }
}
