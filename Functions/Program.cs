namespace Functions;

internal class Program //de function heet program //en het is de code die we eronder hebben getypt
{                      //de return type is void omdat we niks teruggeven
   
   static void Main(string[] args)
   {
        Program program = new Program(); // we hebben variable program gemaakt //program is een program      
        program.Run();      
   }
 
    internal void Run()
    {

        Console.WriteLine("Dit is nu de start van mij programma");
        Console.WriteLine("We gaan nu een vraag stellen");
        Vraag1();
        Console.WriteLine("We gaan nu nog een vraag stellen");
        Vraag2();
        Console.WriteLine("we stellen nu de derde vraag");
        Vraag3();
        Console.WriteLine("we stellen nu de vierde vraag");
        Vraag4();
        Console.WriteLine("we stellen nu de vijfde vraag");
        Vraag5();
        Console.WriteLine("we stellen nu de laatste vraag");
        Vraag6();
    }
   
    internal void Vraag1()
    {
        Console.WriteLine("how long do you think you'd survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("2 entire hours");

    }
   
    internal void Vraag2()
    {
        Console.WriteLine("waar zou je heen gaan in een zombie apocalypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("weg van de stad en meer de bossen in");

    }

     internal void Vraag3()
    {
        Console.WriteLine("wat zou je meenemen in een zombie apocalypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("een tas met kleren en vooral water ook eten zou handig zijn");

    }

    internal void Vraag4()
    {
        Console.WriteLine("zou je je hond meenemen?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("nee die zou teveel eten eten en ook teveel geluid maken");

    }
      internal void Vraag5()
    {
        Console.WriteLine("zou je wel je vader meenemen?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("ja die is handig om bij je te hebben en ik hou natuurlijk van hem");

    }
     internal void Vraag6()
    {
        Console.WriteLine("denk je dat een zombie apocalypse ooit zal gebeuren?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("nee dat denk ik niet");

    }
}


