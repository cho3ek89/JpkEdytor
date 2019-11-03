namespace JpkEdytor.Helpers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml;

    /// <summary>
    /// Resolves XML resources named by <see cref="Uri"/> from embedded resources of a given <see cref="Assembly"/>.
    /// </summary>
    public class XmlUrlToResResolver : XmlUrlResolver
    {
        protected Assembly assembly;

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlUrlToResResolver"/> class.
        /// The current executing <see cref="Assembly"/> will be being used to get the resources from.
        /// </summary>
        public XmlUrlToResResolver()
        {
            assembly = Assembly.GetExecutingAssembly();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlUrlToResResolver"/> class.
        /// </summary>
        /// <param name="assembly"><see cref="Assembly"/> what will be being used to get the resources from.</param>
        public XmlUrlToResResolver(Assembly assembly)
        {
            this.assembly = assembly;
        }

        public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
        {
            var schemaFileName = absoluteUri.Segments.Last();
            var resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(f => f.EndsWith(schemaFileName, StringComparison.InvariantCultureIgnoreCase));

            if (string.IsNullOrEmpty(resourceName))
                throw new FileNotFoundException($"Plik {schemaFileName} nie został odnaleziony w zasobach aplikacji.");

            return assembly.GetManifestResourceStream(resourceName);
        }
    }
}
