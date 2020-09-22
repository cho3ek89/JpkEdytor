namespace JpkEdytor.Models.V71.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKDeklaracjaNaglowek", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9394/")]
    public sealed class DeklaracjaNaglowek : NotifyPropertyChanged
    {
        private DeklaracjaNaglowekKodFormularza kodFormularza;

        private sbyte wariantFormularza;

        private sbyte kwartal;

        public DeklaracjaNaglowek()
        {
            KodFormularza = new DeklaracjaNaglowekKodFormularza();
            WariantFormularza = 15;
            Kwartal = 1;
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

        public sbyte Kwartal
        {
            get
            {
                return kwartal;
            }
            set
            {
                kwartal = value;
                RaisePropertyChanged();
            }
        }
    }
}
