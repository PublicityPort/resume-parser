using Model.Models;

namespace Model
{
    public interface IOutputFormatter
    {
        string Format(Resume resume);
    }
}
