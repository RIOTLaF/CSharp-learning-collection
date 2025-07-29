namespace learning.Learn1;

class Conditions
{
    public void Condition()
    {
        var types = new Dictionary<string, object>()
        {
            { "boolean", true },
            { "string", "a string" },
        };

        foreach (var type in types)
        {
            Console.WriteLine($"Testing now: {type.Key}");
            if (type.Value.GetType() == typeof(bool))
            {
                Console.WriteLine("It's a bool\n");
            } else {
                Console.WriteLine("It's not a bool or it's a string\n");
            }
        }
    }
}