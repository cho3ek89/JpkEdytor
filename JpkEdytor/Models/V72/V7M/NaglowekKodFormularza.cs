namespace JpkEdytor.Models.V72.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TNaglowekKodFormularza", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07081/")]
    public sealed class NaglowekKodFormularza : NotifyPropertyChanged
    {
        private string kodSystemowy;

        private string wersjaSchemy;

        private string kodFormularza;

        public NaglowekKodFormularza()
        {
            KodSystemowy = "JPK_V7M (2)";
            WersjaSchemy = "1-0E";
            KodFormularza = "JPK_VAT";
        }

        [XmlAttribute(AttributeName = "kodSystemowy")]
        public string KodSystemowy
        {
            get
            {
                return kodSystemowy;
            }
            set
            {
                kodSystemowy = value;
                RaisePropertyChanged();
            }
        }

        [XmlAttribute(AttributeName = "wersjaSchemy")]
        public string WersjaSchemy
        {
            get
            {
                return wersjaSchemy;
            }
            set
            {
                wersjaSchemy = value;
                RaisePropertyChanged();
            }
        }

        [XmlText]
        public string KodFormularza
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
    }
}
