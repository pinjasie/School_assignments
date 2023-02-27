using System;
class Program
{
	static void Main(string[] args)
	{
		/*Console.WriteLine("Tehtävä 10.1");
		Console.WriteLine("------------");
		Console.WriteLine("Anna kokonaislukuja, niin lasken summan reaaliajassa");
		int sum = 0;
		while (sum <= 100)
		{
		Console.Write("Summa on nyt " + sum + ". Syöte: ");
		int input = int.Parse(Console.ReadLine());
		sum += input;
		}
		Console.WriteLine("Raja saavutettu!");*/
		/*Console.WriteLine("Tehtävä 16.1");
		Console.WriteLine("------------");
		while (true) //rakennetaan switch case while-silmukan sisään. Niin kauan kun while-silmukan sisällä oleva arvo on tosi, case suoritetaan
		{
			Console.Write("Anna numero väliltä 1-7, niin kerron mikä viikonpäivä on kyseessä: ");
			int numero = int.Parse(Console.ReadLine());
			switch (numero) //tehdään switch case, jossa jokainen viikonpäivä on oma case
			{
				case 1:
					Console.WriteLine("Maanantai" + "\n");
					break; //break-komento siirtää seuraavaan suoritettavaan osioon
				case 2:
					Console.WriteLine("Tiistai" + "\n");
					break;
				case 3:
					Console.WriteLine("Keskiviikko" + "\n");
					break;
				case 4:
					Console.WriteLine("Torstai" + "\n");
					break;
				case 5:
					Console.WriteLine("Perjantai" + "\n");
					break;
				case 6:
					Console.WriteLine("Lauantai" + "\n");
					break;
				case 7:
					Console.WriteLine("Sunnuntai" + "\n");
					break;
				default:
					Console.WriteLine("Antamasi numero ei ole validi :(" + "\r"); //jos käyttäjä antaa arvon, joka ei ole välillä 1-7, tulostuu tämä lause
					break;
			}

			Console.Write("Haluatko jatkaa (k/e)? "); //kysytään käyttäjältä haluaako hän jatkaa ohjelman suorittamista
			string valinta = Console.ReadLine();
			Console.WriteLine();
			if (valinta != "k") //jos valinta on jotain muuta kuin "k", ohjelman suoritus päättyy break-komennolla
			{
				break;
			}*/
		while (true) //ryöstetään edellisen tehtävän rakenne, muokataan casen palikat oikeisiin arvoihin
		{
			Console.Write("Anna anna arvosana väliltä 4-10: ");
			int arvosana = int.Parse(Console.ReadLine());
			Console.WriteLine();
			switch (arvosana) //tehdään switch case, jossa jokainen arvosana on oma case
			{
				case 4:
					Console.WriteLine("4 on hylätty arvosana.");
					Console.WriteLine();
					break; //break-komento siirtää seuraavaan suoritettavaan osioon
				case 5:
					Console.WriteLine("5 on huono arvosana." + "\n");
					Console.WriteLine();
					break;
				case 6:
					Console.WriteLine("6 on välttävä arvosana." + "\n");
					Console.WriteLine();
					break;
				case 7:
					Console.WriteLine("7 on tyydyttävä arvosana." + "\n");
					Console.WriteLine();
					break;
				case 8:
					Console.WriteLine("8 on hyvä arvosana." + "\n");
					Console.WriteLine();
					break;
				case 9:
					Console.WriteLine("9 on kiitettävä arvosana." + "\n");
					Console.WriteLine();
					break;
				case 10:
					Console.WriteLine("10 on erinomainen arvosana." + "\n");
					Console.WriteLine();
					break;
				default:
					Console.WriteLine("Antamasi numero ei ole validi :(" + "\n"); //jos käyttäjä syöttää puppua, tulee tämä kommentti
					break;
			}

			Console.Write("Haluatko jatkaa (k/e)? "); //kysytään käyttäjältä haluaako hän jatkaa ohjelman suorittamista
			string valinta = Console.ReadLine();
			Console.WriteLine();
			if (valinta != "k") //jos valinta on jotain muuta kuin "k", ohjelman suoritus päättyy break-komennolla
			{
				break;
			}
		}
	}
}

