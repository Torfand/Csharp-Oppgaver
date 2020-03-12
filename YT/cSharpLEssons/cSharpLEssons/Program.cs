using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace cSharpLEssons
{
    class Program
    {
        static void Main(string[] args)
        {

            BetterCalc();
            //Madlibs(); 
            //BasicAddCalc();
            //GetuIN();
            //WwithNumbers();
            //WwithStrings();
            //datatypes();
            //vartest();

        }

        private static void BetterCalc()
        {
            
        }

        private static void Madlibs()
        {
            string Bekrivelse, Bekrivelse2, Bekrivelse3, Bekrivelse4, Bekrivelse5;

            Console.WriteLine("Skriv inn en besrivelse");
            Bekrivelse = Console.ReadLine();
            Console.WriteLine("Skriv inn en flertall");
            Bekrivelse2 = Console.ReadLine();
            Console.WriteLine("Skriv inn en flertall");
            Bekrivelse3 = Console.ReadLine();
            Console.WriteLine("Skriv inn en flertall");
            Bekrivelse4 = Console.ReadLine();
            Console.WriteLine("Skriv inn en flertall");
            Bekrivelse5 = Console.ReadLine();
            Console.WriteLine("Etter en {0} sommer, ", Bekrivelse);
            Console.WriteLine("Kommer den {0} høsten. ", Bekrivelse2);
            Console.WriteLine("Det ser ikke helt lyst ut.");
            Console.WriteLine("Den {0} IS-Gruppen blir stadig drøyere, ", Bekrivelse3);
            Console.Write("mens selv våre {0} ", Bekrivelse4);
            Console.Write("svenske børdre er skremt av den {0} Putin", Bekrivelse5);
        }

        private static void BasicAddCalc()
        {

            Console.Write("Skriv inn ett nummer : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv inn ett nummer til : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("{0} + {1} = " , num1, num2);
            Console.Write(num1 + num2);
            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 6);
        }

        private static void GetuIN()
        {

            string name = Console.ReadLine();
            Console.WriteLine("Hei " + name );
             
        }

        private static void WwithNumbers()
        {
            //int num = 6;
            //double dec = 2.1;
            //num++;
            Console.WriteLine(Math.Round(4.6));
        }

        private static void WwithStrings()
        {
            string phrase = "Hei på Deg";
            Console.WriteLine(phrase.Substring(7, 2));
        }

        private static void datatypes()
        {
            //string phrase = "TEXT";
            //char grade = 'A';
            //int = 20;
            //double dec = 13.37;
            //bool isWierd = false; 
            ////Float , Double , Decimal 
            //Console.WriteLine();




            //Console.ReadLine();
        }

        private static void vartest()
        {
            string name = "Karl";
            int age = 20;



            Console.WriteLine("There once was a man named " + name);
            Console.WriteLine("he was {0}  years old", age);
            name = "Lars";
            Console.WriteLine("he really liked the name " + name);
            Console.WriteLine("but didnt like being  " + age); ;
        }
    }
}
