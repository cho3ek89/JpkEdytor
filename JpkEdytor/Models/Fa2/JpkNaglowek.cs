namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKNaglowek", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public sealed class JpkNaglowek : Naglowek
    {
        public JpkNaglowek()
        {
            CelZlozenia = 1;
            WariantFormularza = 2;
            DataWytworzeniaJpk = DateTime.Now;
            KodFormularza = new NaglowekKodFormularza();
        }
    }
}
