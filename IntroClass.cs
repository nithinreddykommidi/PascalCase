using Practice;
using System;

public class IntroClass
{
	int id;
	string name;
	public void Add(int i, string S)
	{
		id= i;
		name= S;
	}
	public void Show()
	{
		Console.WriteLine("id is{0} and Name is {1}",id,name);

	}
	public static void Cls()
	{
        IntroClass e1= new IntroClass();
        IntroClass e2= new IntroClass();

		e1.Add(1, "Nithin");
		e2.Add(2, "Naveen");

		e1.Show();
		e2.Show();
		/*
		 * Creating object without constructor
				Book b1 = new Book();
				b1.Name = "Nithin";
				b1.Author = "Nithin";
				b1.Pages = 100;

				Book b2 = new Book();
				b2.Name = "Naveen";
				b2.Author = "Naveen";
				b2.Pages = 110;
		*/

		// Creating Objects with constructers

		Book b1 = new Book("Nithin", "Nithin", 100);
		Book b2 = new Book("Naveen", "Naveen", 110);
		// We can change the atribute of object by
		b1.Name = "New Name";
		Console.WriteLine(b1.Name);
		
		Console.WriteLine(b2.LargeBook());
		Console.WriteLine(b1.LargeBook());


    }
	public static void Main0()
	{
		Movies Avengers = new Movies("Avengers", "Marvel", "PG-13");
		Movies Flash = new Movies("Flash", "DC", "PG-13");
		Movies Deadpool = new Movies("Deadpool", "Marvel", "R");
		Deadpool.Rating = "PG-13";
		Console.WriteLine(Deadpool.Rating);

		StaticCircle c1 = new StaticCircle(2);
		Console.WriteLine(c1.Area());
	}
}
