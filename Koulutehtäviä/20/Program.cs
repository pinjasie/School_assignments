using System;

class Program
{
	static void Main()
	{
		Console.Write("Anna jokin merkki: ");
		string syote = Console.ReadLine();
		Console.WriteLine("\n" + syote);
		Console.WriteLine();

		if (string.IsNullOrWhiteSpace(syote)) //jos käyttäjä syöttää tyhjän merkin, tämä lause tulostuu
		{
			Console.WriteLine("Annoit tyhjän merkin.");
		}
		else
		{
			char merkki = syote[0]; //tutkitaan syötteen ensimmäinen merkki ehtolauseen avulla

			if (char.IsDigit(merkki)) //jos merkki on numer
			{
				Console.WriteLine(merkki + " on numero.");
			}
			else if (char.IsUpper(merkki)) //jos merkki on iso kirjain
			{
				Console.WriteLine(merkki + " on iso kirjain.");
			}
			else if (char.IsLower(merkki)) //jos merkki on pieni kirjain
			{
				Console.WriteLine(merkki + " on pieni kirjain.");
			}
			else
			{
				Console.WriteLine(merkki + " on erikoismerkki."); //jos merkki on jokin erikoismerkki
			}
		}
	}
}
