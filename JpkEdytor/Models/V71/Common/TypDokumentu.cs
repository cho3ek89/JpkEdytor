namespace JpkEdytor.Models.V71.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TDowoduSprzedazy", IncludeInSchema = false)]
    public enum TypDokumentu
    {
        [Description("Dokument zbiorczy wewnętrzny zawierający sprzedaż z kas rejestrujących")]
        [XmlEnum(Name = "RO")]
        Ro,

        [Description("Dokument wewnętrzny")]
        [XmlEnum(Name = "WEW")]
        Wew,

        [Description("Faktura, o której mowa w art. 109 ust. 3d ustawy")]
        [XmlEnum(Name = "FP")]
        Fp,
    }
}