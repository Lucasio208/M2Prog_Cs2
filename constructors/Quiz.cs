class Quiz
{
    internal Quizvraag[] vragen;
    internal QuizvraagAntwoorden[] ingevuldeAntwoorden;

    internal Quiz(int aantalVragen, int ingevuldeAntwoorden)
    {
        vragen = new Quizvraag[aantalVragen];
        ingevuld = new QuizvraagAntwoorden[ingevuldeAntwoorden];
    }
}