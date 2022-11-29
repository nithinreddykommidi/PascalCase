using System;

public class Reference
{
    public void fun2(ref int value)
    {
        value = value + 10;
        Console.WriteLine("value in function {0}", value);
    }

    public static void Main1()
    {
        int value = 10;
        Console.WriteLine("before passing {0}", value);
        Reference e1 = new Reference();
        e1.fun2(ref value);
        Console.WriteLine("After passing to the finction {0}", value);

    }


}
