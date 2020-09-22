namespace JpkEdytor.Tests.ViewModelTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.IO;

    public abstract class ViewModelTestsBase
    {
        protected static string workingDirectory;

        [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void ClassInit(TestContext context)
        {
            _ = context;
            workingDirectory = Path.Combine(Path.GetTempPath(), GetRandomGuid());
            Directory.CreateDirectory(workingDirectory);
        }

        [ClassCleanup(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void ClassCleanup()
        {
            Directory.Delete(workingDirectory, true);
        }

        protected static string GetRandomGuid()
        {
            return Guid.NewGuid().ToString("N").ToUpperInvariant();
        }

        protected static string GetTempFilePath()
        {
            return Path.Combine(workingDirectory, GetRandomGuid() + ".xml");
        }
    }
}
