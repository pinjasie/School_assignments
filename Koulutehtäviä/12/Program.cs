using System;
class Aliohjelma
{
	static void Main()
	{
		Console.WriteLine("Tehtävä 12" + "\n" + "---------------------" + "\n");
		Console.Write("Anna luku, jonka neliön haluat tietää: "); //kysytään käyttäjältä luku laskutoimitukseen
		int luku = int.Parse(Console.ReadLine()); //käyttäjän syöte
		int nelio = laskeNelio(luku); //aliohjelman alustus
		Console.WriteLine("\n" + "Luvun " + luku + " neliö on " + nelio); //näytölle tulostuu käyttäjän antama luku, sekä luvusta saatu neliö
	}
	static int laskeNelio(int luku) //aliohjelma
	{
		int nelio = luku * luku; //neliön laskutoimitus tehdään aliohjelmassa
		return nelio; //palauttaa neliön arvon lausekkeeseen, jossa sitä kutsutaan
	}
}