using System;

public class Client : Person
{
	public int ClientId { get; set; }
	public int ClientDiscount { get; set; }

    public Client(string firstname, string lastname, int age, int clientId, int ClientDiscount):base(firstname, lastname, age)
    {
        this.ClientId = clientId;
        this.ClientDiscount = ClientDiscount;
   

    }
}
