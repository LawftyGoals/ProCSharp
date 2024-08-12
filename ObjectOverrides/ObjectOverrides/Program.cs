// See https://aka.ms/new-console-template for more information
using ObjectOverrides;

Console.WriteLine("***** Fun with System.Object \"overrides\" - 283");
Person p1 = new();

Console.WriteLine("ToString: {0}", p1.ToString());

Console.WriteLine("Hash code: {0}", p1.GetHashCode());

Console.WriteLine("Type: {0}", p1.GetType());

//same ref
Person p2 = p1;

// still reffing p1
object o = p2;

if (o.Equals(p1) && p2.Equals(o)) {
    Console.WriteLine("same instance");
}

Console.WriteLine();



Console.WriteLine("***** Fun with System.Object - overriding built in object functions 285");

Quokka q = new("Bobr", "Kewly", 3);
Quokka q2 = q;

Console.WriteLine(q.ToString());
Console.WriteLine(q.Equals(o));
Console.WriteLine(q.Equals(q2));
Console.WriteLine(q.GetHashCode());
Console.WriteLine(q.GetHashCode() == q2.GetHashCode());






Console.ReadLine();


