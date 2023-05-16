using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Tehtävä 9" + "\n" + "------------");
        Console.WriteLine("Anna viisi lukua niin lasken niiden keskiarvon" + "\n");
        int summa = 0; //alustetaan muuttuja summa, johon lasketaan käyttäjän syöttämät arvot
        int[] luvut = new int[5]; //tehdään lista käyttäjän antamille arvoille. Listaan varastoidaan 5 lukua
        for(int i = 0; i < 5; i++) //toistorakenne, jossa kysytään käyttäjältä viidesti lukuja
        {
            Console.Write("Anna " + (i+1) + ". luku: "); // i + 1 lisää juoksevan numeron tulostukseen
            luvut[i] = int.Parse(Console.ReadLine()); //käyttäjän syöte, joka muunnetaan int-tyyppiseksi
            foreach (int luku in luvut) // foreach-toistolause, jolle ei ole minkäänmoista tarvetta tässä tehtävässä :)
            {
                Console.WriteLine(luku);
            }
            summa += luvut[i]; // summaan lisätään käyttäjän antamat luvut jokaisella toistokerralla
        }
        int keskiarvo = summa / 5; //alustetaan keskiarvo-muuttuja
        Console.WriteLine("\n" + "Keskiarvo on " + keskiarvo);
    }
}