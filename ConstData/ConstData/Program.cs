// See https://aka.ms/new-console-template for more information
using ConstData;
using static ConstData.MyMathClass;

Console.WriteLine("**** Fun with Const ****\n 231");

Console.WriteLine("The value of PI is: {0}", PI);

Console.WriteLine("=> Constant String Interpolation:");
const string foo = "Foo";
const string bar = "Bar";
const string foobar = $"{foo}{bar}";
Console.WriteLine(foobar);

Console.WriteLine("ReadOnly: {0}",new MyMathClass().PIreadOnly);

Console.ReadLine();
