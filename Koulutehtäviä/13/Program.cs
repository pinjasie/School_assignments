using System;
class Program
{
	static void Main()
	{
		Console.WriteLine("Tehtävä 13" + "\n" + "---------------");
		int summa = lukujenSumma(); //aliohjelman alustus
		Console.WriteLine("\n" + "Lukujen summa on " + summa); //aliohjelman kutsu
	}
	static int lukujenSumma() //itse aliohjelma
	{
	Console.WriteLine("Anna kolme lukua, niin lasken niiden summan");
		int summa = 0; //alustetaan muuttuja summa, johon käyttäjän syöte lisätään
		for(int i = 0; i < 3; i++) //kysytään loopilla käyttäjältä syöte kolmesti
		{
			Console.Write("Anna " + (i + 1) + ". luku: ");
			int luku = int.Parse(Console.ReadLine());
			summa += luku; //käyttäjän syöte lisätään summaan jokaisella kierroksella
		}
		return summa;
	}
}