namespace JpkEdytor.Models.V71.V7M
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "JPKNaglowek", AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2020/05/08/9393/")]
    public sealed class JpkNaglowek : Naglowek
    {
        public JpkNaglowek()
        {
            KodFormularza = new NaglowekKodFormularza();
            WariantFormularza = 1;
            DataWytworzeniaJpk = DateTime.Now;
            NazwaSystemu = AppDomain.CurrentDomain.FriendlyName;
            CelZlozenia = new NaglowekCelZlozenia();
            Rok = DateTime.Now.Year.ToString();
            Miesiac = (sbyte)DateTime.Now.Month;
        }
    }
}
