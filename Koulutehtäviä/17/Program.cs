using System;
public class Program
{
	enum Valinnat //vakioluettelo
	{
		LisaaNimi = 1,
		LisaaIka = 2,
		NaytaNimi = 3,
		NaytaIka = 4,
		Poistu = 5
	}

	static string nimi; //tallentaa käyttäjän nimen
	static int ika; //tallentaa käyttäjän iän

	static void Main()
	{
		bool jatka = true; //totuusarvo, jonka avulla käyttäjä voi valita haluaako hän jatkaa ohjelman suoritusta vai ei

		while (jatka)
		{
			TulostaValikko(); //aliohjelman kutsu, tulostaa valikon

			string syote = Console.ReadLine(); //muuttuja käyttäjän syötteelle

			// muunnetaan käyttäjän syöte enum-arvoksi
			Valinnat valinta;
			if (Enum.TryParse(syote, out valinta))
			{
				// switch-case valinnan käsittelyyn
				switch (valinta)
				{
					case Valinnat.LisaaNimi:
						Console.Write("Syötä nimesi: ");
						nimi = Console.ReadLine();
						break;
					case Valinnat.LisaaIka:
						Console.Write("Syötä ikäsi: ");
						ika = int.Parse(Console.ReadLine());
						break;
					case Valinnat.NaytaNimi:
						Console.WriteLine("Nimesi on: " + nimi);
						break;
					case Valinnat.NaytaIka:
						Console.WriteLine("Ikäsi on: " + ika);
						break;
					case Valinnat.Poistu:
						Console.WriteLine("Poistutaan...");
						jatka = false; // lopettaa while-silmukan
						break;
				}
			}
			else
			{
				Console.WriteLine("Virheellinen valinta."); //jos käyttäjä syöttää jotain muuta kuin arvon 1-5, tämä tulostuu
			}
		}
	}

	static void TulostaValikko() //valikon aliohjelma
	{
		Console.WriteLine("Tervetuloa ohjelmaan. Siirry valikossa valitsemalla numero.");
		Console.WriteLine("1. Lisää nimi");
		Console.WriteLine("2. Lisää ikä");
		Console.WriteLine("3. Näytä nimi");
		Console.WriteLine("4. Näytä ikä");
		Console.WriteLine("5. Poistu");
	}
}
