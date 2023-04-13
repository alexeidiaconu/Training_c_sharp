using System;

public class Contest
{

    public List<Participant> participants;

    public Contest()
	{
        this.participants = new List<Participant>();
	}

    public void addParticipant(Participant p)
    { 
        this.participants.Add(p);
    }

    public void addParticipant(Participant p, int poz)
    {
        this.participants.Add(this.participants[poz]);
        this.participants[poz] = p;
    }
    public void removeParticipant(int poz) 
    {
        this.participants.Remove(participants[poz]);
    }
    public int getParticipant(byte id) 
    { 
        for(int i = 0;i < this.participants.Count; i++) 
        {
            if (this.participants[i].Id == id)
            {
                return i;
            }
            
        }
        return -1;
    }

    public void modifyScore(int id, int newScore) 
    {
        this.participants[id].Score = newScore;
    }

    public void printParticipant(Participant p)
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Id: " + p.Id);
        Console.WriteLine("Name: " + p.Name);
        Console.WriteLine("Score: " + p.Score);
        Console.WriteLine("------------------------------------------");

    }

    public void sortParticipant()
    {
        Participant key;
        int j;

        for (int i = 1; i < this.participants.Count; i++)
        { 
            key = this.participants[i];
            j = i-1;

            while (j >= 0 && this.participants[j].Score > key.Score)
            {
                this.participants[j+1] = this.participants[j];
                j--;
            }
            this.participants[j + 1] = key;



        }
    }

    public void printParticipantWithScoreLess(int score)
    {
        Console.WriteLine("----Participants with score Less than " + score + " are:----");
        foreach (Participant p in this.participants) 
        {
            if (p.Score < score)
            { 
                this.printParticipant(p);
            }
        }
        Console.WriteLine("         ");
    }

    public void printParticipantWithScoreBigger(int score)
    {
        Console.WriteLine("----Participants with score Bigger than " + score + " are:----");
        foreach (Participant p in this.participants)
        {
            if (p.Score > score)
            {
                this.printParticipant(p);
            }
        }

        Console.WriteLine("         ");
    }



}
