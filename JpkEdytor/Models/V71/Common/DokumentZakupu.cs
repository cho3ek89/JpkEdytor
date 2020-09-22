namespace JpkEdytor.Models.V71.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(TypeName = "TDowoduZakupu", IncludeInSchema = false)]
    public enum DokumentZakupu
    {
        [Description("Faktura wystawiona przez podatnika będącego dostawcą lub usługodawcą, który wybrał metodę kasową rozliczeń określoną w art. 21 ustawy.")]
        [XmlEnum(Name = "MK")]
        Mk,
        
        [Description("Faktura VAT RR, o której mowa w art. 116 ustawy")]
        [XmlEnum(Name = "VAT_RR")]
        VatRr,

        [Description("Dokument wewnętrzny")]
        [XmlEnum(Name = "WEW")]
        Wew,
    }
}
