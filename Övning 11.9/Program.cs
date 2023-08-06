namespace Övning_11._9
{
    class MyTemperature
    {

        private static double CTF(double celsius) //intern metod för att räkna ut celsius till fahrenheit
        {
            double result = celsius * 9 / 7 + 32;
            return result;
        }

        private static double FTC(double fahrenheit) //intern metod för att räkna ut fahrenheit till celsius
        {
            double result = (fahrenheit - 32) * 5 / 9;
            return result;
        }

        public static bool IsBoiling(int temperature) 
        {
            if (temperature < 100)
            {
                return false;
            }
            return true;
        }

        public static bool IsBoiling(float temperature)
        {
            if (temperature < 100)
            {
                return false;
            }
            return true;
        }

        public static int CelsiusToFahrenheit(int celsius) //Metod för att räkna ut C till F överladdning 1 
        {
            int fahrenheit = (int)CTF(celsius);
            return fahrenheit;
        }

        public static float CelsiusToFahrenheit(float celsius) //Metod för att räkna ut C till F överladdning 2
        {
            float fahrenheit = (float)CTF(celsius);
            return fahrenheit;
        }

        public static int FarenheitToCelsius(int fahrenheit) //Metod för att räkna ut F till C överladdning 1 
        {
            int celsuis = (int)FTC(fahrenheit);
            return celsuis;
        }

        public static float FarenheitToCelsius(float fahrenheit) //Metod för att räkna ut F till C överladdning 2
        {
            float celsuis = (float)FTC(fahrenheit);
            return celsuis;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius = 10; 
            Console.WriteLine(MyTemperature.CelsiusToFahrenheit(celsius)); //Skriver ut resultatet av metoden CelsiusToFahrenheit från klassen Mytemperature

            int fahrenheit = 44;
            Console.WriteLine(MyTemperature.FarenheitToCelsius(fahrenheit)); //Skriver ut resultatet av metoden FahrenheitToCelsius från klassen Mytemperature
        }
    }
}