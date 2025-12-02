class Quiz
{
    internal Quizvraag[] vragen;
    internal QuizvraagAntwoorden[] ingevuldeAntwoorden;

    internal Quiz(int aantalVragen, int ingevuldeAntwoorden)
    {
        vragen = new Quizvraag[aantalVragen];
        ingevuld = new QuizvraagAntwoorden[ingevuldeAntwoorden];
    }

    internal VoegVraagToeOpIndex(Quizvraag vraag, int index)
    {
        vraag[index] = vraag;
        Quizvraag vraag = vragen[index];
    }
    internal VoegVraagToeOpIndex(string vraag,string antwoord, int index)
    {
        string vraag = vragen[index];
        string antwoord = vragen[index];
    }
}