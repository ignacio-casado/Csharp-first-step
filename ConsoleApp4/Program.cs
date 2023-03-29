using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escriba 4 numero que quiera sumar");
        string num1 = Console.ReadLine();   
        string num2 = Console.ReadLine();   
        string num3 = Console.ReadLine();
        string num4 = Console.ReadLine();

        int result = Suma(num1, num2, num3, num4);
        Console.WriteLine(result);
    }
    private static int Suma(string a, string b, string c, string d)
    {
        int value1 = 0;
        int value2 = 0;
        int value3 = 0;
        int value4 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);
        bool IsNumber3 = int.TryParse(c, out value3);
        bool IsNumber4 = int.TryParse(c, out value4);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber3 == false)
        {
            Console.WriteLine("El valor C no es un numero");
        }
        if (IsNumber4 == false)
        {
            Console.WriteLine("El valor D no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true && IsNumber3 == true && IsNumber4 == true)
        {
            return value1 + value2 + value3 + value4;
        }
        else
        {
            return 0;
        }
    }

}
