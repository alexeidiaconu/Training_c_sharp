using System;

public class Participant		
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Score { get; set; }

	public Participant()
	{
	}

    public Participant(int id, string name, int score)
    {
		this.Id = id;
		this.Name = name;
		if (score > 0 && score < 11)
		{
			this.Score = score;
		}
		else this.Score = 1;
    }

}
