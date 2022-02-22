namespace JpkEdytor.Models.V72.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;
    using Models.Common;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TNaglowek", Namespace = "http://crd.gov.pl/wzor/2021/07/08/07081/")]
    public class Naglowek : NotifyPropertyChanged
    {
        private NaglowekKodFormularza kodFormularza;

        private sbyte wariantFormularza;

        private DateTime dataWytworzeniaJpk;

        private string nazwaSystemu;

        private NaglowekCelZlozenia celZlozenia;

        private KodUsV70 kodUrzedu;

        private string rok;

        private sbyte miesiac;

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

        [XmlElement(ElementName = "DataWytworzeniaJPK")]
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

        public NaglowekCelZlozenia CelZlozenia
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

        public KodUsV70 KodUrzedu
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

        [XmlElement(DataType = "gYear")]
        public string Rok
        {
            get
            {
                return rok;
            }
            set
            {
                rok = value;
                RaisePropertyChanged();
            }
        }

        public sbyte Miesiac
        {
            get
            {
                return miesiac;
            }
            set
            {
                miesiac = value;
                RaisePropertyChanged();
            }
        }
    }
}
