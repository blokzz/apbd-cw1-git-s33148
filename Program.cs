namespace apbdcwiczenie;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Moj Program");
        Console.WriteLine(CalculateAverage([1,2,2,1]));
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);

        Student student = new Student("kamil", 100);

        foreach (int item in set)
        {
         Console.WriteLine(item);   
        }
    }

    public static int CalculateAverage(int[] values)
    {   
        if(values==null||values.Length == 0)
        {
            return 0;
        }

        return (int)values.Average(); 
        
    }
    public static int CalculateMax(int[] numbers)
    {
        if(numbers==null||numbers.Length == 0)
        {
            return 0;
        }
        return numbers.Max();
    }

    public static int CalculateMin(int[] numbers)
    {
        if(numbers==null||numbers.Length == 0)
        {
            return 0;
        }
        return numbers.Min();
    }
}