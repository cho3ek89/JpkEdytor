namespace JpkEdytor.Models.V72.V7K
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKNaglowek", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/07/08/07082/")]
    public sealed class JpkNaglowek : Naglowek
    {
        public JpkNaglowek()
        {
            KodFormularza = new NaglowekKodFormularza();
            WariantFormularza = 2;
            DataWytworzeniaJpk = DateTime.Now;
            NazwaSystemu = AppDomain.CurrentDomain.FriendlyName;
            CelZlozenia = new NaglowekCelZlozenia();
            Rok = DateTime.Now.Year.ToString();
            Miesiac = (sbyte)DateTime.Now.Month;
        }
    }
}
