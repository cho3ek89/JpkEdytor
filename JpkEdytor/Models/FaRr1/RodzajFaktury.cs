﻿namespace JpkEdytor.Models.FaRr1
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(TypeName = "JPKFakturaRRRodzajFaktury", AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2019/08/12/08121/")]
    public enum RodzajFaktury
    {
        [Description("Faktura VAT")]
        [XmlEnum(Name = "VAT_RR")]
        Vat,

        [Description("Faktura korygująca")]
        [XmlEnum(Name = "KOREKTA_RR")]
        Korekta,
    }
}
