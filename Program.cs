using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Holita dsasda");

        double numero = 20.5;

        // Esto convierte datos a un entero
        // y lo aproxima al entero más cercano
        int numeroEntero = Convert.ToInt32(numero);

        Console.WriteLine("Goli");
        Console.WriteLine(numeroEntero);

        // Convertir numero a texto
        string esUnString = numero.ToString();
        Console.WriteLine(esUnString);

        /*
        string name = Console.ReadLine();
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hola mi nombre es: " + name + " de veras");
        Console.WriteLine("Motivate Juan tu puedes con esto nada nunca te queda grande");
        Console.WriteLine("Tengo " + Edad + " años");
        */
        string age = "Ingresa tu edad: ";
        Console.WriteLine(age);
        age = Console.ReadLine();
        int ageInt = Convert.ToInt32(age);
        string edad = "Tienes " + ageInt + " años";
        Console.WriteLine(edad);
        if (ageInt > 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("No eres mayor de edad.");
        }
    }
}