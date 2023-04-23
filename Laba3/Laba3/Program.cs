namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Add(double number1, double number2)
        {
            double sum = 0;
            sum = number1 + number2;
            Console.WriteLine("Сумма чисел = " + sum);
        }
        static void Sub(double number1, double number2)
        {
            double sub = 0;
            sub = number1 - number2;
            Console.WriteLine("Разность чисел = " + sub);

        }
        static void Mul(double number1, double number2)
        {
            double mul = 0;
            mul = number1 * number2;
            Console.WriteLine("Произведение чисел = " + mul);

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
        static double Input_A()
        {

            Console.WriteLine("число А = ");
            double number_A = Convert.ToDouble(Console.ReadLine());

            return number_A;
        }
    }
}