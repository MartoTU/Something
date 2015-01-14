using System; // използване на namespace(библиотека)


namespace SumNumbers
{
    class Program // клас- моделиране на неща с подобни признаци (каквото и да е има на клас)
    {
        static void Main()
        {    // мястото където стартираме нашата програма        

            int m;
            string baseTextValue=Console.ReadLine();
            m = int.Parse(baseTextValue);

            int n;
            string powerTextValue=Console.ReadLine();
            n = int.Parse(powerTextValue) ;

            ;
            Console.WriteLine(Math.Pow(m, n));

        }
    }
}
