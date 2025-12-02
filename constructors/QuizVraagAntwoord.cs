class QuizVraagAntwoord
{
    internal QuizVraag vraag;
    internal bool goed;

    internal QuizVraagAntwoord(QuizVraag vraag)
    {
        vraag = vraag;    //er is geen kriebellijn?
        goed = false;
    }
}