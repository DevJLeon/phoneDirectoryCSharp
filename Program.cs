﻿using System;

class Program {
    static void Main() {
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    writeSpace();
                    Saludar();
                    break;
                case 2:
                    writeSpace();
                    CalcularCuadrado();
                    break;
                case 3:
                    writeSpace();
                    CalcularCirculo();
                    break;
                case 4:
                    writeSpace();
                    deleteContact();
                case 5:
                    writeSpace();
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    writeSpace();
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 4);
    }

    static void MostrarMenu() {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Add contact");
        Console.WriteLine("2. Display all contacts");
        Console.WriteLine("3. Mark as favourite");
        Console.WriteLine("4. Delete contact");
        Console.WriteLine("5. Salir");
    }

    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Saludar() {
        Console.WriteLine("¡Hola! ¡Bienvenido!");
    }

    static void CalcularCuadrado() {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int cuadrado = numero * numero;
        Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
    }

    static void CalcularCirculo() {
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radio * radio;
        Console.WriteLine($"El área del círculo es: {area}");
    }

    static void writeSpace(){
        Console.WriteLine("");
    }
}