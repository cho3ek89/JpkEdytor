namespace JpkEdytor.Models.V72.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKDeklaracjaNaglowekKodFormularzaDekl", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07081/")]
    public sealed class DeklaracjaNaglowekKodFormularza : NotifyPropertyChanged
    {
        private string kodSystemowy;

        private string kodPodatku;

        private string rodzajZobowiazania;

        private string wersjaSchemy;

        private string kodFormularza;

        public DeklaracjaNaglowekKodFormularza()
        {
            KodSystemowy = "VAT-7 (22)";
            KodPodatku = "VAT";
            RodzajZobowiazania = "Z";
            WersjaSchemy = "1-0E";
            KodFormularza = "VAT-7";
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

        [XmlAttribute(AttributeName = "kodPodatku")]
        public string KodPodatku
        {
            get
            {
                return kodPodatku;
            }
            set
            {
                kodPodatku = value;
                RaisePropertyChanged();
            }
        }

        [XmlAttribute(AttributeName = "rodzajZobowiazania", DataType = "token")]
        public string RodzajZobowiazania
        {
            get
            {
                return rodzajZobowiazania;
            }
            set
            {
                rodzajZobowiazania = value;
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
