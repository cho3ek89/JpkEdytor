namespace JpkEdytor.Helpers.JpkModelUpdater
{
    using Models;

    /// <summary>
    /// A class for updating <see cref="IJpk"/> objects.
    /// </summary>
    /// <typeparam name="T"><see cref="IJpk"/> type.</typeparam>
    public interface IJpkModelUpdater<in T> where T : IJpk
    {
        /// <summary>
        /// Updates <paramref name="jpk"/> object.
        /// Sets up specified fields, indexes, CRTL's etc.
        /// </summary>
        /// <param name="jpk"><see cref="IJpk"/> object to update.</param>
        void UpdateJpk(T jpk);
    }
}
