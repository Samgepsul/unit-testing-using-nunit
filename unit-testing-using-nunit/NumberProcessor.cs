public class NumberProcessor
{
    public static int FindFirstPositive(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] > 0)
                return i;
        return -1;
    }

    public static int FindLastPositive(int[] numbers)
    {
        for (int i = numbers.Length - 1; i >= 0; i--)
            if (numbers[i] > 0)
                return i;
        return -1;
    }

    public static double SumBetweenFirstAndLastPositive(int[] numbers)
    {
        int first = FindFirstPositive(numbers);
        int last = FindLastPositive(numbers);
        if (first == -1 || last == -1 || first == last) return 0;

        double sum = 0;
        for (int i = first + 1; i < last; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    public static void MoveZeroesToFront(int[] numbers)
    {
        for (int i = 0, j = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
                j++;
            }
        }
    }
}
