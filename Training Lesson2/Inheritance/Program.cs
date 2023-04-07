public class Inheritance
{
    public static void Main(string[] args)
    {
        Person person = new Person("Morari","Vasile",40);
        Console.WriteLine("The person name is " + person.FirstName + " " + person.LastName);

        int empId = 1;
        int empSalary = 10000;

        Employee newEmployee = new Employee(person.FirstName, person.LastName, person.Age, DateTime.Now, empId, empSalary);
        Console.WriteLine("The Employee name is " + newEmployee.FirstName + " " + newEmployee.LastName);

        Client newClient = new Client("Carcea", "Alexandru", 38, 1,10);
        Console.WriteLine("The Client name is " + newClient.FirstName + " " + newClient.LastName);
        int empClId = 2;
        int empClSalary = 12000;
        int discount = 3;


        EmployeeClient empClient = new EmployeeClient(newEmployee.FirstName, newEmployee.LastName, newEmployee.Age, DateTime.Now,newEmployee.Salary, empClId, empClSalary, discount);
        Console.WriteLine("The EmployeClient name is " + empClient.FirstName + " " + empClient.LastName);

    }
}