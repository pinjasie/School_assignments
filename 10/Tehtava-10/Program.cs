using System;

namespace Summaus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä 10.1
            /*  int sum = 0;
              while (sum < 200)
              {
                  Console.Write("Summa on nyt " + sum + ". Syöte: ");
                  int input = int.Parse(Console.ReadLine());
                  sum += input;
              }
              Console.WriteLine("Saavutettiin 200. Summa oli " + sum + "."); */
            // ---------------------------------------------------------
                Console.WriteLine("Arvaa luku 1-12 väliltä (lopetus L-merkillä)");
                Random rnd = new Random(); //alustetaan satunnaisluku
                int luku = rnd.Next(1, 13); //muuttuja luku valitsee arvon satunnaisesti väliltä 1-13
                int i = 0;
                int arvaus = 0;

                do //while-silmukka do-osiolla
                {
                    Console.Write(i + 1 + ". arvaus: "); //i + 1 lisää juoksevaan numeroon aina yhden lisää
                    string syote = Console.ReadLine(); //luetaan syöte käyttäjältä

                    if (syote.ToUpper() == "L") //jos käyttäjän syöte on L, ohjelman toisto loppuu ja haukkujen jälkeen kerrotaan oikea luku
                    {
                        Console.WriteLine("Lopetetaan...");
                        Console.WriteLine("Halusit lopettaa, luuseri!" + "\n" + "Oikea vastaus oli " + luku);
                        return;
                    }

                    if (int.TryParse(syote, out arvaus)) //toinen ehtolause, jossa on sisäkkäin lisää ehtoja
                    {
                        i++;
                        if (arvaus == luku) //jos käyttäjä arvaa syötteen oikein, tulostuu onnittelut ja silmukasta poistutaan
                        {
                            Console.WriteLine("Onneksi olkoon, arvasit oikein!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Väärä arvaus. Yritä uudelleen."); //jos käyttäjä arvaa väärin, silmukka toistuu uudelleen
                        }
                    }
                    else //jos käyttäjä antaa virheellisen syötteen (jotain mikä ei ole väliltä 1-12 tai L), tulostuu ilmoitus virheellisestä syötteestä
                    {
                        Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku 1-12 tai 'L' lopettaaksesi.");
                    }
                }
                while (i < 12); //do toistuu niin kauan kun annettu ehto on tosi. Jos 12 arvausta tulee täyteen, ohjelman suoritus loppuu
            }
        }
 }
