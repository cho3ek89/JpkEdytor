namespace JpkEdytor.Models.V72.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum TypDatyKorekty
    {
        [Description("Data dokonania zapłaty w przypadku korekt dokonanych zgodnie z art. 89a ust. 4 ustawy.")]
        [XmlEnum]
        DataZaplaty,

        [Description("Data upływu terminu płatności w przypadku korekt dokonanych zgodnie z art. 89a ust. 1 ustawy.")]
        [XmlEnum]
        TerminPlatnosci,
    }
}
