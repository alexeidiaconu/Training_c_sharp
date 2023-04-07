using System;

public class Employee : Person
{
	public DateTime EmployedDate { get; set; }
	public int EmployeeId { get; set; }
	public int Salary { get; set; }
	public Employee(string firstname, string lastname, int age,DateTime employedDate, int employeeId, int Salary) :base(firstname, lastname, age)
	{
		this.EmployeeId = employeeId;
		this.Salary = Salary;
		this.EmployedDate = employedDate;
		this.FirstName =	firstname; 
		this.LastName = lastname;
		this.Age = age;
	}
}
