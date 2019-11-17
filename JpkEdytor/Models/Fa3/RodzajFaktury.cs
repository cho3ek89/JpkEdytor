namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaRodzajFaktury", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public enum RodzajFaktury
    {
        [Description("Faktura VAT")]
        [XmlEnum(Name = "VAT")]
        Vat,

        [Description("Faktura korygująca")]
        [XmlEnum(Name = "KOREKTA")]
        Korekta,

        [Description("Faktura dokumentująca otrzymanie zapłaty lub jej części przed dokonaniem czynności oraz faktura końcowa (art.106b ust. 1 pkt 4 ustawy)")]
        [XmlEnum(Name = "ZAL")]
        Zal,
    }
}
