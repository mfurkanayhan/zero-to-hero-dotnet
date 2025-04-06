using FileProcessor;

class Program
{
    static void Main()
    {
        IFileReader fileReader = new FileReader();
        ICalculator calculator = new Calculator();
        ILogger logger = new ConsoleLogger();

        string path = "data.txt";
        var lines = fileReader.ReadLines(path);

        foreach (var line in lines)
        {
            var numbers = line.Split(',').Select(s => int .TryParse(s, out var n) ? n : 0);

            double avg = calculator.CalculateAverage(numbers);

            logger.Log($"Row Average: {avg:F2}");
        }
    }
}