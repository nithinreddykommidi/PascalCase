using System;

public class Valuereference
{
	public void fun1(int value)
	{
		value = value + 10;
		Console.WriteLine("value in function {0}", value);
	}

	public static void Main1()
	{
		int value = 10;
		Console.WriteLine("before passing {0}", value);
		Valuereference e1 = new Valuereference();
		e1.fun1(value);
		Console.WriteLine("After passing to the finction {0}",value);

    }


}
