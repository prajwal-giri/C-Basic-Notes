/*namespace C_Sharp_Notes_101;
// we discussed that delegates are used to reference any methods that has the same signature as that of delegate.
// As the name suggests, an anonymous method is a method without a name just the body.
// Anonymous methods in C# can be defined using the delegate keyword.

public delegate void MyDelegate(int num);

public class Anonymous_Function
{
    /*public static void MyMethod(int a)
    {
        a += 10;
        Console.WriteLine(a);
    }#1#
    static void Main(string[] args)
    {
        /*MyDelegate obj = new MyDelegate(MyMethod); // or (Program.MyMethod)
        obj.Invoke(5);  // or obj(5);#1#
        
        MyDelegate obj = delegate(int a)
        {
            a += 10;
        };

        obj(5);    // or invoke method.

    }
}*/