namespace JpkEdytor.ViewModels
{
    using System.Threading.Tasks;

    using Models;

    public interface IJpkViewModel<out T> where T : IJpk
    {
        T Jpk { get; }

        Task LoadFromFile(string fullFilePath);

        Task SaveToFile(string fullFilePath);

        Task<string> Validate();
    }
}
