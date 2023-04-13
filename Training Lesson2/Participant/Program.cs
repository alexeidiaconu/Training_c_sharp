public class Program
{
    public static void Main(string[] args)
    {
        Contest contest = new Contest();
        var score = new Random();
        int id = 0;
        contest.addParticipant(new Participant(++id,"Morari Vasile",score.Next(1,10)));
        contest.addParticipant(new Participant(++id, "Carcea Alex", score.Next(1, 10)));
        contest.addParticipant(new Participant(++id, "Olaru Calin", score.Next(1, 10)));
        contest.addParticipant(new Participant(++id, "Grumeza Vasile", score.Next(1, 10)));
        contest.addParticipant(new Participant(++id, "Chihai Dima", score.Next(1, 10)));
        contest.addParticipant(new Participant(++id, "Macovei Dumitru", score.Next(1, 10)));
        contest.addParticipant(new Participant(++id, "Cerchez Mihai", score.Next(1, 10)));
        contest.addParticipant(new Participant(++id, "Tihai Roman", score.Next(1, 10)));
        contest.addParticipant(new Participant(++id, "Vasilache Sergiu", score.Next(1, 10)));


        foreach (Participant p in contest.participants)
        {
            contest.printParticipant(p);
        }

        contest.sortParticipant();

        Console.WriteLine("--------Participants sorted by Score:");

        foreach (Participant p in contest.participants)
        {
            contest.printParticipant(p);
        }

        contest.printParticipantWithScoreLess(score.Next(1, 10));

        contest.printParticipantWithScoreBigger(score.Next(1, 10));




        //Console.WriteLine(contest.ToString());

    }
}