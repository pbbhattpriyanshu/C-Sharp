using System;

//Inhertitance
public class Employee
{
	public string name { get; set; }
	public int age { get; set; }
	public double salary { get; set; }

	//Constructor
	public Employee(string name)
	{
		this.name = name;
	}

	public void Work()
	{
		Console.WriteLine($"{name} Employee is working");
	}

	public virtial void Location()
	{
		Console.WriteLine("Employee location is Lucknow");
	}
}

public class Developer : Employee
{
	//Construtor Inheritance
	public Developer(string name) : base(name) { }
	public void Code()
	{
		Console.WriteLine($"{name} is writting code");
	}

    //Method Hiding - The new keyword hides the parent's method.
    public new void Work()
	{
		Console.WriteLine($"{name} developer is working");
	}

	//Method overloading - virtual in parent, override in child
	public override void Location()
	{
		Console.WriteLine("Developer location is Delhi");
	}
}
