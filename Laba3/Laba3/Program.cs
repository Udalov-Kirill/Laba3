namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            int vibor;
            double chislo_A = 0, chislo_B = 0;
            do
            {
                Console.WriteLine("Сделайте выбор");
                Console.WriteLine("--------------------");
                Console.WriteLine("1 - Ввести число А");
                Console.WriteLine("2 - Ввести число В");
                Console.WriteLine("3 - Сложение(А + В)");
                Console.WriteLine("4 - Разность(А - В)");
                Console.WriteLine("5 - Произведение(А * В)");
                Console.WriteLine("6 - Частное(А / В)");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("--------------------");
                Console.WriteLine("Ваш выбор: ");
                vibor = Convert.ToInt32(Console.ReadLine());

                if (vibor == 1)
                    chislo_A = Input_A();
                if (vibor == 2)
                    chislo_B = Input_B();
                if (vibor == 3)
                    Add(chislo_A, chislo_B);
                if (vibor == 4)
                    Sub(chislo_A, chislo_B);
                if (vibor == 5)
                    Mul(chislo_A, chislo_B);
                if (vibor == 6)
                    Div(chislo_A, chislo_B);
                if (vibor == 0)
                    Console.WriteLine("Завершение работы");

            } while (vibor != 0);
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
        static double Input_B()
        {
            Console.WriteLine("число В = ");
            double number_B = Convert.ToDouble(Console.ReadLine());

            return number_B;
        }
    }
}