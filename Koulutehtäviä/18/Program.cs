using System;
class Program
{
	static void Main(string[] args)
	{
		Console.Write("Anna jokin sana tai lause, niin ohjelma tekee sille temppuja: ");
		string syote = Console.ReadLine(); //muuttuja käyttäjän syötteelle
		char[] arr = syote.ToCharArray(); //alustetaan char-lista
		Console.WriteLine("\n" + syote + "\n"); //tulostetaan käyttäjän syöte kertaalleen normaalina
		for(int i  = 0; i < arr.Length; i++) //for-loop, jonka avulla tulostetaan syöte muunnettuna
		{
			char letter = arr[i];
			Console.Write(letter + " "); //tulostetaan syöte väljästi kirjain kerrallaan
		}
		Console.WriteLine("\n"); //vähän ilmaa väliin
		for(int j = arr.Length - 1; j >= 0; j--) //toinen for-loop, jonka avulla saadaan teksti tulostumaan takaperin
		{
			char letter = arr[j];
			Console.Write(letter + " "); //tulostetaan teksti takaperin väljästi
		}
	}
}