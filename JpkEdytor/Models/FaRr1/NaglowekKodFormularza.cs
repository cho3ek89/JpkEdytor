namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "TNaglowekKodFormularza", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public sealed class NaglowekKodFormularza : NotifyPropertyChanged
    {
        private string kodSystemowy;

        private string wersjaSchemy;

        private string kodFormularza;

        public NaglowekKodFormularza()
        {
            KodSystemowy = "JPK_FA_RR (1)";
            WersjaSchemy = "1-0";
            KodFormularza = "JPK_FA_RR";
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
