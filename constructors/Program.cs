namespace constructors;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.run();
    }

    private void Run()
    {
        Quizvraag quizvraag = new Quizvraag("welke fruit is rood", "een appel");
        quiz quiz = new Quiz(10);
        quiz .VoegVraagToe(0, quizVraag);   
    }
}
