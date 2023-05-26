using System;
class Program
{
	static void Main()
	{
		Console.WriteLine("Ohjelma heittää kahta noppaa viidesti ja laskee kaikkien heittojen yhteissumman." + "\n");
		Random rnd = new Random(); //alustetaan random-muuttuja
		int summa = 0; //muuttuja jokaisen kierroksen summalle
		int kaikkienSumma = 0; //muuttuja kokonaissummalle
		for(int i = 0; i < 5; i++)
		{
			int tulos1 = rnd.Next(1, 6); //ensimmäisen nopan tulos
			int tulos2 = rnd.Next(1, 6); //toisen nopan tulos
			summa = tulos1 + tulos2;
			kaikkienSumma += summa; //lisätään jokaisen kierroksen summa loppusummaan
			Console.WriteLine($"{i + 1}. heiton nopat: {tulos1} ja {tulos2}. Noppien summa on {summa}." + "\n");
		}
		Console.WriteLine("Heittojen yhteissumma on " + kaikkienSumma); //tulostetaan heittojen yhteissumma
	}
}