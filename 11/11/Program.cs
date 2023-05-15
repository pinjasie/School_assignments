using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Tehtävä 11" + "\n" + "----------------------");
        Console.WriteLine("Luettele viisi lukua");
        List<int> lista = new List<int>(); //alustetaan lista, johon käyttäjän syöttämät arvot tallentuvat
        for (int i = 0; i < 5; i++) //tehdään for-loop syötteen kysymiseksi viidesti
        {
            Console.Write("Anna " + (i + 1) + ". luku: ");
            int luvut = int.Parse(Console.ReadLine()); //käyttäjän syöte tyyppimuunnetaan string -> int
            lista.Add(luvut); //jokaisella kierroksella lisätään käyttäjän antama luku alustettuun listaan
        }
        for (int i = 0; i < lista.Count; i++) //uusi for-loop listan tulostukseen
        {
            Console.WriteLine(lista[i]); //lista tulostuu allekkaisessa järjestyksessä näytölle
        }
    }
}