using FileReader.Model;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileReader
{
    public static class ReadFile 
    {
        public static JsonResultModel ReadFromFile(string path)
        {
            //var baseDir = Directory.GetCurrentDirectory();
            var filePath = File.ReadAllText(path);
            var res = JsonSerializer.Deserialize<JsonResultModel>(filePath);
            return res;
        }

        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }
    }
}
