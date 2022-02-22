namespace JpkEdytor.Models.V72.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum TypZwrotu
    {
        [Description("Zwrot na rachunek rozliczeniowy podatnika w terminie 15 dni")]
        [XmlEnum(Name = "P_540")]
        P540,

        [Description("Zwrot na rachunek VAT podatnika w terminie 25 dni")]
        [XmlEnum(Name = "P_55")]
        P55,

        [Description("Zwrot na rachunek rozliczeniowy podatnika w terminie 25 dni")]
        [XmlEnum(Name = "P_56")]
        P56,

        [Description("Zwrot na rachunek rozliczeniowy podatnika w terminie 40 dni")]
        [XmlEnum(Name = "P_560")]
        P560,

        [Description("Zwrot na rachunek rozliczeniowy podatnika w terminie 60 dni")]
        [XmlEnum(Name = "P_57")]
        P57,

        [Description("Zwrot na rachunek rozliczeniowy podatnika w terminie 180 dni")]
        [XmlEnum(Name = "P_58")]
        P58,
    }
}
