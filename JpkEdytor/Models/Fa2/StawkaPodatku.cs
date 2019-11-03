namespace JpkEdytor.Models.Fa2
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaWierszP_12", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/03/21/03211/")]
    public enum StawkaPodatku
    {
        [Description("23%")]
        [XmlEnum(Name = "23")]
        N23,

        [Description("22%")]
        [XmlEnum(Name = "22")]
        N22,

        [Description("8%")]
        [XmlEnum(Name = "8")]
        N08,

        [Description("7%")]
        [XmlEnum(Name = "7")]
        N07,

        [Description("5%")]
        [XmlEnum(Name = "5")]
        N05,

        [Description("4%")]
        [XmlEnum(Name = "4")]
        N04,

        [Description("3%")]
        [XmlEnum(Name = "3")]
        N03,

        [Description("0%")]
        [XmlEnum(Name = "0")]
        N00,

        [Description("Zwolnione z opodatkowania")]
        [XmlEnum(Name = "zw")]
        Zw,

        [Description("Odwrotne obciążenie")]
        [XmlEnum(Name = "oo")]
        Oo,

        [Description("Niepodlegające opodatkowaniu - transakcje dostawy towarów oraz świadczenia usług poza terytorium kraju")]
        [XmlEnum(Name = "np")]
        Np,
    }
}
