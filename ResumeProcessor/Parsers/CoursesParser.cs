using Model;
using Model.Models;

namespace ResumeProcessor.Parsers
{
    public class CoursesParser : IParser
    {        
        public void Parse(Section section, Resume resume)
        {
            resume.Courses = section.Content;
        }
    }
}
