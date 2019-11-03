namespace JpkEdytor.Helpers
{
    using System.IO;
    using System.Text;

    /// <summary>
    /// <see cref="StringWriter"/> based class implementation allowing to set up an encoding.
    /// </summary>
    public class StringWriterWithEncoding : StringWriter
    {
        public override Encoding Encoding { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringWriterWithEncoding"/> class.
        /// Default <see cref="Encoding.UTF8"/> will be being used.
        /// </summary>
        public StringWriterWithEncoding()
        {
            Encoding = new UTF8Encoding();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringWriterWithEncoding"/> class.
        /// </summary>
        /// <param name="encoding"><see cref="Encoding"/> what will be being used.</param>
        public StringWriterWithEncoding(Encoding encoding)
        {
            Encoding = encoding;
        }
    }
}
