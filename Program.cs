using System;

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        int num1 = 0;
        int num2 = 0;
        double num3 = 0;
        double num4 = 0;
        Console.WriteLine("Calculadora");
        Console.WriteLine();

        Console.Write("Ingrese el primer número: ");
        num3 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num4 = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Seleccione la operación que desea realizar:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Suma de enteros");
        Console.WriteLine("6. Resta de enteros");
        Console.WriteLine("7. Multiplicación de enteros");
        Console.WriteLine("8. División de enteros");
        Console.WriteLine();
        int opcion = int.Parse(Console.ReadLine());

        if (opcion <= 4)
        {
            num1 = Convert.ToInt32(num3);
            num2 = Convert.ToInt32(num4);
            num3 = 0;
            num4 = 0;
        }

        double resultado = 0;
        switch (opcion)
        {
            case 1:
                resultado = calc.Sumar(num1, num2);
                break;

            case 2:
                resultado = calc.Restar(num1, num2);
                break;

            case 3:
                resultado = calc.Multiplicar(num1, num2);
                break;

            case 4:
                resultado = calc.Dividir(num1, num2);
                break;
            case 5:
                resultado = calc.Sumar(num3, num4);
                break;

            case 6:
                resultado = calc.Restar(num3, num4);
                break;

            case 7:
                resultado = calc.Multiplicar(num3, num4);
                break;

            case 8:
                resultado = calc.Dividir(num3, num4);
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("El resultado es: " + resultado);

        Console.ReadKey();
    }
}
