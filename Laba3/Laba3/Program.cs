namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Div(double number1, double number2)
        {
            double div = 0;
            if (number2 != 0)
            {
                div = number1 / number2;
                Console.WriteLine("Частное чисел = " + div);
            }
            else
                Console.WriteLine("Поменяйте значение числа В");
        }
    }
}