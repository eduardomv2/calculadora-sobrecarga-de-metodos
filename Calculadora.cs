using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Calculadora
{
    private double resultado;
    private int resultado1;
    public Calculadora()
    {
        resultado = 0;
    }

    public double Sumar(double num3, double num4)
    {
        resultado = num3 + num4;
        return resultado;
    }
    public int Sumar(int num1, int num2)
    {
        resultado1 = num1 + num2;
        return resultado1;
    }

    public double Restar(double num3, double num4)
    {
        resultado = num3 - num4;
        return resultado;
    }
    public int Restar(int num1, int num2)
    {
        resultado1 = num1 - num2;
        return resultado1;
    }

    public double Multiplicar(double num3, double num4)
    {
        resultado = num3 * num4;
        return resultado;
    }
    public int Multiplicar(int num1, int num2)
    {
        resultado1 = num1 * num2;
        return resultado1;
    }
    public double Dividir(double num3, double num4)
    {
        if (num4 != 0)
        {
            resultado = num3 / num4;
            return resultado;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }
    }
    public int Dividir(int num1, int num2)
    {
        if (num2 != 0)
        {
            resultado1 = num1 / num2;
            return resultado1;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }
    }
}