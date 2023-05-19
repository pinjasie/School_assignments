//C# Metropolia-kurssin ohjelmointitehtävä kivi-paperi-sakset
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Torakka-jalka-ydinase. Valitse 1-4." + "\n" +
            "1) Torakka 2) Jalka 3) Ydinase 4) Poistu");
        Random rnd = new Random(); //luodaan random-muuttuja, jota tietokone käyttää
        int computer = rnd.Next(1, 4); //kerrotaan tietokoneelle, että se valitsee satunnaisluvun 1-4 väliltä
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
            case 4:
                Console.WriteLine("");
                break;
        }
        if (valinta > computer) //ehtolausekkeet, jonka perusteella määräytyy kommentti
        {
            Console.WriteLine("Tietokone valitsi " + computer + ". Voitit!");
        }
            if (valinta < computer)
            {
                Console.WriteLine("Tietokone valitsi " + computer + ". Hävisit!");
            }
            if (valinta == computer)
            {
                Console.WriteLine("Tietokone valitsi " + computer + ". Tasapeli!");
            }
            if (valinta == 4)
            {
            Console.WriteLine("");
            }
    }
}