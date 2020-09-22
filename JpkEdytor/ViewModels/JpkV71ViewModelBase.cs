namespace JpkEdytor.ViewModels
{
    using System.Threading.Tasks;
    using System.Windows.Input;
    using System.Xml.Serialization;

    using Models.V71;

    public abstract class JpkV71ViewModelBase<T> : JpkViewModelBase<T> where T : IJpkV71
    {
        protected string tnsNamespace;

        public abstract ICommand ChangePodmiotType { get; }

        public abstract ICommand AddOrRemoveDeklaracja { get; }

        public abstract Task ImportSprzedazFromCsv(string fullFilePath);

        public abstract Task ImportZakupyFromCsv(string fullFilePath);

        protected override XmlSerializerNamespaces GetXmlNamespaces()
        {
            var namespaces = base.GetXmlNamespaces();

            namespaces.Add("tns", tnsNamespace);

            return namespaces;
        }
    }
}
