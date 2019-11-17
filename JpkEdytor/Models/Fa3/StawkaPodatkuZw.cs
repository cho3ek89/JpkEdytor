namespace JpkEdytor.Models.Fa3
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKZamowienieZamowienieWierszP_12Z", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/09/27/09271/")]
    public enum StawkaPodatkuZw
    {
        [Description("23%")]
        [XmlEnum("23")]
        N23,

        [Description("22%")]
        [XmlEnum("22")]
        N22,

        [Description("8%")]
        [XmlEnum("8")]
        N08,

        [Description("7%")]
        [XmlEnum("7")]
        N07,

        [Description("5%")]
        [XmlEnum("5")]
        N05,

        [Description("4%")]
        [XmlEnum("4")]
        N04,

        [Description("3%")]
        [XmlEnum("3")]
        N03,

        [Description("0%")]
        [XmlEnum("0")]
        N00,

        [Description("Zw")]
        [XmlEnum(Name = "zw")]
        Zw,

        [Description("Odwrotne obciążenie")]
        [XmlEnum(Name = "oo")]
        Oo,

        [Description("Niepodlegające opodatkowaniu")]
        [XmlEnum(Name = "np")]
        Np,
    }
}
