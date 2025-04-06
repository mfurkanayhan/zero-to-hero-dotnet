
namespace FileProcessor;
public class Calculator : ICalculator
{
    public double CalculateAverage(IEnumerable<int> numbers)
    {
        if (!numbers.Any()) return 0;
        return numbers.Average();
    }
}
