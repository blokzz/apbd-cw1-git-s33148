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

    public static int CalculateAverage(int[] numbers)
    {   
        if(numbers==null||numbers.Length == 0)
        {
            return 0;
        }

        return (int)numbers.Average(); 
        
    }
    public static int CalculateMax(int[] numbers)
    {
        return numbers.Max();
    }
}