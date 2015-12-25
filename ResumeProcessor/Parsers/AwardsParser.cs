using Model;
using Model.Models;

namespace ResumeProcessor.Parsers
{
    public class AwardsParser : IParser
    {        
        public void Parse(Section section, Resume resume)
        {
            resume.Awards = section.Content;
        }
    }
}
