public static void NoDuplicates(List<string> inputArray)
{
    int h = 2;
}
public static void Main(string[] args)
{
    Dictionary<string, int> people = new Dictionary<string, int> { };

    List<string> names = new List<string> { "Jamie", "John", "Jamie", "Simon", "John" };
    foreach (string name in names)

    {

        people[name] = 18;
    }

    foreach(KeyValuePair<string, int> kvp in people)

    {
        Console.WriteLine(string.Format("Persons name is: {0}",kvp.Key));
        Console.WriteLine(string.Format("Persons age is: {0}", kvp.Value));
        

    }

}