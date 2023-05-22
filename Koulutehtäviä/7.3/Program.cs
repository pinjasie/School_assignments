using System;
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Tehtävä 7.3" + "\n" + "-----------------------" + "\n");
		Console.Write("Anna lukupyramidin kerrosten määrä: ");
		int riveja = int.Parse(Console.ReadLine()); //käyttäjän syöte, jonka perusteella kerrosten määrä määräytyy
		int i, j; //muuttujien alustus
		for (i = 1; i <= riveja; i++) //for-loop, joka tulostaa kerrokset
		{
			for (j = 1; j <= i; j++) //sisempi for-loop, joka tulostaa rivit
			{
				Console.Write(j); //tulostetaan pyramidi sisemmän loopin avulla
			}
			Console.Write("\n\r");
		}
	}
}