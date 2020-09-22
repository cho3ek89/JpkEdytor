namespace JpkEdytor.Models.V71.Common
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
        [Description("Zwrot na rachunek VAT (art. 87 ust. 6a)")]
        [XmlEnum(Name = "P_55")]
        P55,

        [Description("Zwrot w terminie (art. 87 ust. 6)")]
        [XmlEnum(Name = "P_56")]
        P56,

        [Description("Zwrot w terminie (art. 87 ust. 2)")]
        [XmlEnum(Name = "P_57")]
        P57,

        [Description("Zwrot w terminie (art. 87 ust. 5a)")]
        [XmlEnum(Name = "P_58")]
        P58,
    }
}