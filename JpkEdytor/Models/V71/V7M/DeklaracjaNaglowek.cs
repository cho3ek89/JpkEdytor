namespace JpkEdytor.Models.V71.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKDeklaracjaNaglowek", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public sealed class DeklaracjaNaglowek : NotifyPropertyChanged
    {
        private DeklaracjaNaglowekKodFormularza kodFormularza;

        private sbyte wariantFormularza;

        public DeklaracjaNaglowek()
        {
            KodFormularza = new DeklaracjaNaglowekKodFormularza();
            WariantFormularza = 21;
        }

        [XmlElement(ElementName = "KodFormularzaDekl")]
        public DeklaracjaNaglowekKodFormularza KodFormularza
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

        [XmlElement(ElementName = "WariantFormularzaDekl")]
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
    }
}
