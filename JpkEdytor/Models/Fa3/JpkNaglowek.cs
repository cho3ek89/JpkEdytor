namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKNaglowek", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public sealed class JpkNaglowek : Naglowek
    {
        public JpkNaglowek()
        {
            CelZlozenia = 1;
            WariantFormularza = 3;
            DataWytworzeniaJpk = DateTime.Now;
            KodFormularza = new NaglowekKodFormularza();
        }
    }
}
