using Model;
using Model.Models;

namespace ResumeProcessor.Parsers
{
    public class SummaryParser : IParser
    {
        public void Parse(Section section, Resume resume)
        {
            resume.SummaryDescription = string.Join("; ", section.Content);
        }
    }
}
