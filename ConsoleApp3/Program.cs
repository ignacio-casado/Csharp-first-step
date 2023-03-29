using System;

class Program
{
    static void Main()
    {
        string btnSuma = "+";
        string btnResta = "-";
        string btnMulti = "*";
        string btnDiv = "/";

        Console.WriteLine("Bienvenidos a la calculadora");
        Console.WriteLine("Para sumar presione +");
        Console.WriteLine("Para restar presione -");
        Console.WriteLine("Para multiplicar presione *");
        Console.WriteLine("Para dividir presione /");

        string response = Console.ReadLine();  

        if(response == btnSuma)
        {
            //SUMA
            Console.WriteLine("Seleccione un valor A");
            string res = Console.ReadLine();
            Console.WriteLine("Seleccione un valor B");
            string res2 = Console.ReadLine();
            int result = Suma(res, res2);
            Console.WriteLine($"El resultado de la suma entre {res} y {res2} es {result}");
        }
        if (response == btnResta)
        {
            //Resta
            Console.WriteLine("Seleccione un valor A");
            string res = Console.ReadLine();
            Console.WriteLine("Seleccione un valor B");
            string res2 = Console.ReadLine();
            int result = Resta(res, res2);
            Console.WriteLine($"El resultado de la resta entre {res} y {res2} es {result}");
        }
        if (response == btnMulti)
        {
            //Multiplicacion
            Console.WriteLine("Seleccione un valor A");
            string res = Console.ReadLine();
            Console.WriteLine("Seleccione un valor B");
            string res2 = Console.ReadLine();
            int result = Multiplicacion(res, res2);
            Console.WriteLine($"El resultado de la multiplicacion entre {res} y {res2} es {result}");
        }
        if (response == btnDiv)
        {
            //Division
            Console.WriteLine("Seleccione un valor A");
            string res = Console.ReadLine();
            Console.WriteLine("Seleccione un valor B");
            string res2 = Console.ReadLine();
            int result = Division(res, res2);
            Console.WriteLine($"El resultado de la division entre {res} y {res2} es {result}");
        }




    }
    private static int Suma(string a, string b)
    {
        int value1 = 0;
        int value2 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);

        if(IsNumber == false) 
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if(IsNumber == true && IsNumber2 == true) 
        {
            return value1 + value2;
        }
        else
        {
            return 0;
        }
    }

    private static int Resta(string a, string b)
    {
        int value1 = 0;
        int value2 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true)
        {
            return value1 - value2;
        }
        else
        {
            return 0;
        }
    }
    private static int Multiplicacion(string a, string b)
    {
        int value1 = 0;
        int value2 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true)
        {
            return value1 * value2;
        }
        else
        {
            return 0;
        }
    }
    private static int Division(string a, string b)
    {
        int value1 = 0;
        int value2 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true)
        {
            if(value2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            return value1 / value2;
        }
        else
        {
            return 0;
        }
    }
}