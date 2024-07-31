
namespace ConstData; 
class MyMathClass {
    public const double PI = 3.14;

    public readonly double PIreadOnly;

    public MyMathClass()
    {
        PIreadOnly = 3.14;
    }

}


// if static is applied to readonly it must be known at compile time
// if not possible then static ctor may be used.
/*
 * 
 * public static readonly double PI =3.14;
 * 
 * class MyMathClass {
 * public static readonly double PI;
 * static MyMathClass(){
 * PI = 3.14;
 * }
 * }
 * 
 */