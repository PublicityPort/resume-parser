using Model;
using Model.Models;

namespace ResumeProcessor.Parsers
{
    public interface IParser
    {
        void Parse(Section section, Resume resume);
    }
}
