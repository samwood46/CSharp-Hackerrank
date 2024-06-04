public class Program
{
    public static void NoDuplicates(List<string> inputArray)
    {
        List<string> outputArray = new List<string>(); 

        foreach (string name in inputArray)
        {
            if (!outputArray.Contains(name))
            {
                outputArray.Add(name);
            }

            
        }
        foreach (string name in outputArray)
        {
            Console.WriteLine(name);
        }
    }
    public static void Main(string[] args)
    {
        List<string> names = new List<string> { "Jamie", "John", "Jamie", "Simon", "John" };
        
        NoDuplicates(names);

            
    }
}