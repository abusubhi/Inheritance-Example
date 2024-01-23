using System;

public class PerantClass
{
	public PerantClass()
	{
		Console.WriteLine("parent class constructor called");
	}

	public PerantClass(string message)
	{
		Console.WriteLine($"{message}");
	}


}

public class chiledclass : PerantClass
{
	/*constructor*/
    public chiledclass() : base("Derived class controlling") 
	{
		Console.WriteLine("chiled class constructor called");
	}

}
class Program 
{
	public static void Main(string[] args)
	{
		/*object to call constructor (chiledclass)*/
		chiledclass cc= new chiledclass();
	}
}