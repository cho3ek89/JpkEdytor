namespace JpkEdytor.ViewModels
{
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using Framework;
    using Helpers;
    using Models;

    public abstract class JpkViewModelBase<T> : NotifyPropertyChanged, IJpkViewModel<T> where T : IJpk
    {
        protected T jpk1;

        public virtual T Jpk
        {
            get
            {
                return jpk1;
            }
            protected set
            {
                jpk1 = value;
                RaisePropertyChanged();
            }
        }

        protected string schemaFileName;

        public virtual async Task LoadFromFile(string fullFilePath)
        {
            await Task.Run(() =>
            {
                var serializer = new XmlSerializer(typeof(T));

                using (var stringReader = new StringReader(File.ReadAllText(fullFilePath)))
                {
                    using (var xmlReader = XmlReader.Create(stringReader))
                    {
                        Jpk = (T)serializer.Deserialize(xmlReader);
                    }
                }
            });
        }

        public virtual async Task SaveToFile(string fullFilePath)
        {
            await Task.Run(() => 
            {
                var doc = GetSerializedDocument();
                doc.Save(fullFilePath);
            });
        }

        public virtual async Task<string> Validate()
        {
            return await Task.Run(() =>
            {
                var doc = GetSerializedDocument();

                var validationErrors = new StringBuilder();
                doc.Validate(GetSchemaSet(), (o, e) =>
                {
                    validationErrors.AppendLine(e.Message);
                    validationErrors.AppendLine();
                });
                return validationErrors.ToString();
            });
        }

        protected virtual XDocument GetSerializedDocument()
        {
            UpdateCrtls();

            var serializer = new XmlSerializer(typeof(T));
            var doc = new XDocument(new XDeclaration("1.0", "utf-8", null));

            using (var xmlWriter = doc.CreateWriter())
            {
                serializer.Serialize(xmlWriter, Jpk);
            }

            return doc;
        }

        protected virtual XmlSchemaSet GetSchemaSet()
        {
            var schemaSet = new XmlSchemaSet
            {
                XmlResolver = new XmlUrlToResResolver()
            };
            schemaSet.Add(null, schemaFileName);

            return schemaSet;
        }

        protected abstract void UpdateCrtls();

        protected static bool IsDefaultValue<Type>(Type obj)
        {
            return obj.Equals(default(Type));
        }
    }
}
