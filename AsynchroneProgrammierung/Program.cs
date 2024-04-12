using AsynchroneProgrammierung;

internal class Program
{
    private static void Main(string[] args)
    {
        IExampleSystem exampleSystem = new ExampleSystem();
        Console.WriteLine("Start HelloWorldAsync");
        var helloWorld = GetHelloWorldAsync().Result;
        Console.WriteLine(helloWorld);
        Console.WriteLine("Enter an URL:");       
        var url = Console.ReadLine();

        if(!string.IsNullOrEmpty(url) && url.StartsWith("https://"))
        {
            Console.WriteLine("Start GetContentAsync");
            var content = exampleSystem.GetContentAsync(url).Result;
            Console.WriteLine(content);
        }  
        
        exampleSystem.AsyncVoidExceptions_CannotBeCaughtByCatch();
        //exampleSystem.ThowException_CanBeCaughtByCatch();
    }

    private static async Task<string> GetHelloWorldAsync()
    {
        await Task.Delay(1000);
        return "Hello, World!";
    }

    
}