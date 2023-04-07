using System;

public class Person

{
	public string FirstName { get; set;}
	public string LastName { get; set;}
	public int Age { get; set;}
	public Person(string firstname, string lastname, int age)
	{
		this.FirstName = firstname;
		this.LastName = lastname;	
		this.Age = age;

	}
}
