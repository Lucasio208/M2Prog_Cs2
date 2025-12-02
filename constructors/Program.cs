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
        Quizvraag quizvraag = new Quizvraag("hier komt de vraag", "hier komt het antwoord");
    }
}
