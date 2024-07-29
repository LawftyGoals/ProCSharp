// See https://aka.ms/new-console-template for more information

// top level statements, only one file in app can do this. Cannot have a DECLARED entry point
//still access string[] args. no namespace bro. 
Console.WriteLine("***** My Not Really First C# App *****");
Console.WriteLine("Hello, World!\n");

for(int i = 0; i < args.Length; i++) {
    Console.WriteLine("Arg: {0}", args[i]);
}

foreach (string arg in args) {
    Console.WriteLine("Arg2: {0}", arg);
}

string[] theArgs = Environment.GetCommandLineArgs();

foreach(string arg in theArgs) {
    Console.WriteLine("Arg3: {0}", arg);
}

ShowEnvironmentDetails();

Console.ReadLine();

return 0;
// return -1;


static void ShowEnvironmentDetails() {
    foreach (string drive in Environment.GetLogicalDrives()) {
        Console.WriteLine($"Drive: {drive}");
    }
    Console.WriteLine($"OS: {Environment.OSVersion}");
    Console.WriteLine($"Number of processors: {Environment.ProcessorCount}");
    Console.WriteLine($".Net CoreVersion: {Environment.Version}");
}


/*
class Program {

    // the file that cointains the Main() is called an application object. Is the entry point
    // for a program. O_O
    static void Main(string[] args) {
        Console.WriteLine("***** My Not Really First C# App *****");
        Console.WriteLine("Hello, World!\n");

        Console.ReadLine();
    }
}
*/