using System;
class Program
{
	static void Main(string[] args)
	{
		Console.Write("Anna jokin sana, niin ohjelma kertoo onko sanassa pientä a-kirjainta ja monesko se on: ");
		string syote = Console.ReadLine(); //muuttuja käyttäjän syötteelle
		string kirjain = "a";
		char[] arr = syote.ToCharArray(); //alustetaan char-lista
		Console.WriteLine("\n" + syote + "\n");
		bool loytyy = syote.Contains(kirjain); //alustetaan boolean-muuttuja
		if(loytyy) //ehtolause: jos sanasta löytyy pieni a-kirjain, rakenne toistuu
		{
			Console.WriteLine("Sanasta löytyy pieni a-kirjain" + "\n");
			 int paikka = syote.IndexOf(kirjain); //muuttuja kirjaimen järjestysnumerolle
			if(paikka >= 0)
			{
				Console.WriteLine("Ensimmäinen pieni {0}-kirjain on {1}. kirjain annetussa sanassa.", kirjain, paikka + 1); //tulostetaan lause, jossa kerrotaan kirjaimen paikka.
																															//Paikan arvoon lisätään +1, jotta 0 ei ole ensimmäinen luku
			}
		}
		else
		{
			Console.WriteLine("Antamastasi sanasta ei löydy pientä a-kirjainta."); //jos sanasta ei löydy a-kirjainta, tämä lause tulostuu
		}
	}
}