namespace JpkEdytor.Models.Vat3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "TNaglowek", Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
    public sealed class Naglowek : NotifyPropertyChanged
    {
        private NaglowekKodFormularza kodFormularza;

        private sbyte wariantFormularza;

        private string celZlozenia;

        private DateTime dataWytworzeniaJpk;

        private DateTime dataOd;

        private DateTime dataDo;

        private string nazwaSystemu;

        public Naglowek()
        {
            CelZlozenia = "0";
            WariantFormularza = 3;
            NazwaSystemu = AppDomain.CurrentDomain.FriendlyName;
            DataWytworzeniaJpk = DateTime.Now;
            KodFormularza = new NaglowekKodFormularza();
        }

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

        [XmlElement(DataType = "nonNegativeInteger")]
        public string CelZlozenia
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

        [XmlElement(ElementName = "DataWytworzeniaJPK", DataType = "dateTime")]
        public DateTime DataWytworzeniaJpk
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
        public DateTime DataOd
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

        [XmlElement(DataType = "token")]
        public string NazwaSystemu
        {
            get
            {
                return nazwaSystemu;
            }
            set
            {
                nazwaSystemu = value;
                RaisePropertyChanged();
            }
        }
    }
}
