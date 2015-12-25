using Newtonsoft.Json;
using Model;
using Model.Models;

namespace Json
{
    public class JsonOutputFormatter : IOutputFormatter
    {
        private readonly JsonSerializerSettings _settings;
        public JsonOutputFormatter()
        {
            _settings = new JsonSerializerSettings();
            _settings.Converters.Add(new HyphenNameSerializer());
            _settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; 
        }

        public string Format(Resume resume)
        {
            return JsonConvert.SerializeObject(resume, Formatting.Indented, _settings);
        }
    }
}
