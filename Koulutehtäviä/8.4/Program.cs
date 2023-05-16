using System;
class Assignment
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Tehtävä 8.4");
		Console.WriteLine("----------" + "\n");
		Console.WriteLine("HEROt ovat seuraavat:");
		Console.WriteLine("(1) Ana" + "\n" + "(2) Bastion" + "\n" + "(3) Brigitte" + "\n" + "(4) D.Va (Mecha)"); // esitellään valittavat hahmot tulosteena, jokainen omalla rivillä
		string[] HERO = { "Ana", "Bastion", "Brigitte", "D.Va (Mecha)" }; // alustetaan 4 listaa hahmojen tietoja varten
		string[] ROLE = { "Support", "Defence", "Support", "Tank" };
		string[] HEALTH = { "200", "200", "200", "400" }; // nämä voi kirjoittaa myös int-muuttujana
		string[] ARMOR = { "0", "100", "50", "200" }; // kuten tämänkin
		Console.Write("\n" + "Valitse minkä HEROn tiedot haluat nähdä: "); // pyydetään käyttäjää valitsemaan hahmo, jonka tiedot näytetään
		int valinta = int.Parse((Console.ReadLine())); // tyyppimuunnetaan käyttäjän syöte int-tyyppiseksi
		Console.WriteLine(); //tyhjä rivi luomaan vähän väljyyttä
		if (valinta == 1) //toistetaan pieni valintarakenne, tuloste käyttäjän valinnan mukaan
		{
			Console.WriteLine($"{HERO[0]} {ROLE[0]} {HEALTH[0]} {ARMOR[0]}"); // Ana
		}

		if (valinta == 2)
			{
				Console.WriteLine($"{HERO[1]} {ROLE[1]} {HEALTH[1]} {ARMOR[1]}"); //Bastion
			}
		if (valinta == 3)
			{
				Console.WriteLine($"{HERO[2]} {ROLE[2]} {HEALTH[2]} {ARMOR[2]}"); //Brigitte
			}
		if (valinta == 4)
			{
				Console.WriteLine($"{HERO[3]} {ROLE[3]} {HEALTH[3]} {ARMOR[3]}"); //D.Va
			}
		else if (valinta < 1 || valinta > 4) //lisäsin loppuun vielä ehtorakenteen, joka toistuu jos käyttäjä syöttää jotain muuta kuin luvun väliltä 1-4
		{
			Console.WriteLine("Syötä numero välillä 1-4.");
		}
	}
}