using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling //from https://www.completecsharptutorial.com/basic/try-catch-finally.php
{
    class Program
    {
        static void Main(string[] args)
        {
        label:
            // Try block: The code which may raise exception at runtime
            try
            {
                int num1, num2;
                decimal result;

                Console.WriteLine("Jakolaskuohjelma: syötä jaettava ja jakaja, niin saat tuloksen.");
                Console.Write("Anna jaettava luku: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anna jakaja: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Tulos: " + result.ToString());
                Console.ReadLine();
            }

            //Multiple Catch block to handle exception

            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Jakaja ei voi olla 0.");
                Console.WriteLine("Lisätietoa virheestä: \n\n" + dex.ToString() + "\n\n");
                goto label;
            }

            catch (FormatException fex)
            {
                Console.WriteLine("Virheellinen syöte.");
                Console.WriteLine("Lisätietoa virheestä: \n\n" + fex.ToString() + "\n\n");
                goto label;
            }

            //Parent Exception: Catch all type of exception

            catch (Exception ex)
            {
                Console.WriteLine("Syötä luku." + ex.ToString() + "\n\n");
                goto label;
            }

            //Finally block: it always executes

            finally
            {
                Console.WriteLine("Paina Enter, jos haluat jatkaa. Paina Ctrl + c, jos haluat lopettaa.");
                Console.ReadLine();
            }
        }
    }
}