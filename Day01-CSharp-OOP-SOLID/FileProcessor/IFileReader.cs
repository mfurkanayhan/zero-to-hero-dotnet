namespace FileProcessor;
public interface IFileReader
{
    IEnumerable<string> ReadLines(string path);
}
