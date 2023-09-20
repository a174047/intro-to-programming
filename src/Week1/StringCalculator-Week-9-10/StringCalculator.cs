
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers.Length == 0) return 0;

        List<char> delimetersList = new List<char> { ',', '\n' };

        int startOfString = numbers.StartsWith("/") ? 4 : 0;
        if (startOfString == 4)
        {
            delimetersList.Add(numbers[2]);
        }

        return numbers.Substring(startOfString).Split(delimetersList.ToArray()).Select(int.Parse).Sum();

        /*int sum = 0;
        foreach (var number in numberList)
        {
            sum += int.Parse(number);
        }

        return sum;*/
    }
}
