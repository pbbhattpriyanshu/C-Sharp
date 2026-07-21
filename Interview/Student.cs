using System;

//class
public class Student
{
	//Fields
	public string name { get; set; } //modern C#
	public int age;
	public string major;
	public string hobby;
	public int year;

	//constructor - Parameterized
	public Student(string name, int age, string major, string hobby, int year)
	{
		this.name = name;
		this.age = age;
		this.major = major;
		this.hobby = hobby;
		this.year = year;
	}

	public void DisplayInfo()
	{
        Console.WriteLine($"Student: {name}, Age: {age}, Major: {major}, Hobby: {hobby}, Year: {year}");
    }
}
