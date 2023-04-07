using System;

public class EmployeeClient : Employee
{
	public Client client;
	public EmployeeClient(string firstname, string lastname, int age, DateTime employedDate, int employeeId, int Salary, int clientId, int ClientDiscount):base(firstname, lastname, age, employedDate, employeeId, Salary)
	{
		this.FirstName = firstname;
		this.LastName = lastname;	
		this.Age = age;	
		this.EmployeeId = employeeId;
		this.EmployedDate = employedDate;	
		this.Salary=Salary;
		client = new Client(firstname,lastname,age,clientId,ClientDiscount);
	}
}
