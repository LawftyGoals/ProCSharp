// See https://aka.ms/new-console-template for more information

Console.WriteLine("***** A first look at interaces - 317 *****\n");

CloneableExample();

static void CloneableExample() {
    string myStr = "Hello";
    OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());

    CloneMe(myStr);
    CloneMe(unixOS);

    static void CloneMe(ICloneable c) {
        object theClone = c.Clone();
        Console.WriteLine($"Clone is a: {theClone.GetType().Name}");
    }
}

