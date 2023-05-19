//C# Metropolia-kurssin ohjelmointitehtävä kivi-paperi-sakset
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Torakka-jalka-ydinase. Valitse 1-4." + "\n" +
            "1) Torakka 2) Jalka 3) Ydinase 4) Poistu");
        Random rnd = new Random(); //luodaan random-muuttuja, jota tietokone käyttää
        int computer = rnd.Next(1, 4); //kerrotaan tietokoneelle, että se valitsee satunnaisluvun 1-3 väliltä
        int valinta = int.Parse(Console.ReadLine());
        switch (valinta) //tehdään switch-case käyttäjän valinnalle
        {
            case 1:
                Console.Write("Torakka! ");
                break;
            case 2:
                Console.Write("Jalka! ");
                break;
            case 3:
                Console.Write("Ydinase! ");
                break;
            default:
                Console.WriteLine("");
                return;
        }
        switch (computer) // switch-case tietokoneen valinnalle
        {
            case 1:
                Console.WriteLine("Tietokone valitsi: Torakka!");
                break;
            case 2:
                Console.WriteLine("Tietokone valitsi: Jalka!");
                break;
            case 3:
                Console.WriteLine("Tietokone valitsi: Ydinase!");
                break;
        }
        if (valinta > computer) //ehtolausekkeet, jonka perusteella määräytyy kommentti
        {
            Console.WriteLine("Voitit!");
        }
           else if (valinta < computer)
            {
                Console.WriteLine("Hävisit!");
            }
            else
            {
                Console.WriteLine("Tasapeli!");
            }
    }
}