using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tehtävä 14" + "\n" + "-----------------" + "\n");
        Console.Write("Anna kokonaisluku: ");
        string syote = Console.ReadLine(); //tehdään muuttuja käyttäjän syötteelle
        bool success = int.TryParse(syote, out int number); //tehdään boolean-muuttuja, joka muuttaa syötteen numeroksi sen ollessa mahdollista
        if(success) //ehtolause, jonka mukaan määrittyy kumpi tulostus saadaan
        {
            Console.WriteLine("Converted " + "'" + syote + "'" + " to " + number + " JEE!"); //jos syöte on käännettävissä, tämä lause tulostuu
        }
        else {
            Console.WriteLine("Attempted conversion of " + "'" + syote + "'" + " failed. SORRY!"); //jos syötettä ei voi kääntää, tulostuu tämä
             }
    }
}