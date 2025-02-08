using System;

class Program
{
    static void Main()
    {
        // Declarar un arreglo para almacenar 10 números
        int[] numeros = new int[10];

        // Pedir al usuario que ingrese 10 números
        Console.WriteLine("Por favor, ingresa 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Ordenar el arreglo de números
        Array.Sort(numeros);

        // Mostrar los números ordenados
        Console.WriteLine("\nLos números ordenados son:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        // Esperar a que el usuario presione una tecla para salir
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}


using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBienvenido a la Calculadora de Smailyn Ceballo\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" MENU PRINCIPAL\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 1. Suma\n" +
                              " 2. Resta\n" +
                              " 3. Multiplicación\n" +
                              " 4. División\n" +
                              " 5. Potencia\n" +
                              " 6. Raíz cuadrada\n" +
                              " 7. Salir\n\n");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1: // Suma
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n    1. Suma\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ingrese la cantidad de números que desea sumar: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidadSuma) && cantidadSuma > 0)
                        {
                            double suma = 0;
                            for (int i = 0; i < cantidadSuma; i++)
                            {
                                Console.Write($"Ingrese el número {i + 1}: ");
                                if (double.TryParse(Console.ReadLine(), out double numero))
                                {
                                    suma += numero;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                                    i--; // Repetir la iteración
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nEl resultado de la suma es: {suma}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Cantidad no válida. Debe ser un número mayor que 0.");
                        }
                        break;

                    case 2: // Resta
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n    2. Resta\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ingrese la cantidad de números que desea restar: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidadResta) && cantidadResta > 0)
                        {
                            Console.Write("Ingrese el primer número: ");
                            if (double.TryParse(Console.ReadLine(), out double resta))
                            {
                                for (int i = 1; i < cantidadResta; i++)
                                {
                                    Console.Write($"Ingrese el número {i + 1}: ");
                                    if (double.TryParse(Console.ReadLine(), out double numero))
                                    {
                                        resta -= numero;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                                        i--; // Repetir la iteración
                                    }
                                }
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nEl resultado de la resta es: {resta}");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Cantidad no válida. Debe ser un número mayor que 0.");
                        }
                        break;

                    case 3: // Multiplicación
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n    3. Multiplicación\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ingrese la cantidad de números que desea multiplicar: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidadMultiplicacion) && cantidadMultiplicacion > 0)
                        {
                            double multiplicacion = 1;
                            for (int i = 0; i < cantidadMultiplicacion; i++)
                            {
                                Console.Write($"Ingrese el número {i + 1}: ");
                                if (double.TryParse(Console.ReadLine(), out double numero))
                                {
                                    multiplicacion *= numero;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                                    i--; // Repetir la iteración
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nEl resultado de la multiplicación es: {multiplicacion}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Cantidad no válida. Debe ser un número mayor que 0.");
                        }
                        break;

                    case 4: // División
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n    4. División\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ingrese el dividendo: ");
                        if (double.TryParse(Console.ReadLine(), out double dividendo))
                        {
                            Console.Write("Ingrese el divisor: ");
                            if (double.TryParse(Console.ReadLine(), out double divisor) && divisor != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nEl resultado de la división es: {dividendo / divisor}");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Divisor no válido. Debe ser un número distinto de 0.");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Dividendo no válido. Por favor, ingrese un número válido.");
                        }
                        break;

                    case 5: // Potencia
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n    5. Potencia\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ingrese la base: ");
                        if (double.TryParse(Console.ReadLine(), out double basePotencia))
                        {
                            Console.Write("Ingrese el exponente: ");
                            if (double.TryParse(Console.ReadLine(), out double exponente))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nEl resultado de {basePotencia} elevado a {exponente} es: {Math.Pow(basePotencia, exponente)}");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Exponente no válido. Por favor, ingrese un número válido.");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Base no válida. Por favor, ingrese un número válido.");
                        }
                        break;

                    case 6: // Raíz cuadrada
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n    6. Raíz cuadrada\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ingrese el número: ");
                        if (double.TryParse(Console.ReadLine(), out double numeroRaiz) && numeroRaiz >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nLa raíz cuadrada de {numeroRaiz} es: {Math.Sqrt(numeroRaiz)}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Número no válido. Debe ser un número positivo.");
                        }
                        break;

                    case 7: // Salir
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gracias por usar la Calculadora. ¡Hasta luego!...");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida del menú...");
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Por favor, ingrese un número válido...");
            }

            if (opcion != 7)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 7);
    }
}






