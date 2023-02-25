namespace LabelPrinter.Services
{
    internal class FileReader
    {
        public static string ReadFileToEnd(string path)
        {
            using (var stream = new System.IO.StreamReader(path))
            {
                return stream.ReadToEnd();
            }
        }
    }
}
