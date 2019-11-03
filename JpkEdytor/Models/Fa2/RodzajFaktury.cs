namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaRodzajFaktury", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public enum RodzajFaktury
    {
        [XmlEnum(Name = "VAT")]
        Vat,

        [XmlEnum(Name = "KOREKTA")]
        Korekta,

        [XmlEnum(Name = "ZAL")]
        Zal,
    }
}
