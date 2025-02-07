//using System;

//namespace Resumen01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Declarar variables
//            int numero1 = 0;
//            int numero2 = 0;
//            Console.WriteLine("Resumen de clase");
//            Console.WriteLine("Ingrese el valor de numero 1");
//            numero1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Ingrese el valor de numero 2");
//            numero2 = int.Parse(Console.ReadLine());

//            //Operaciones aritmeticas
//            int suma = numero1 + numero2;
//            int resta = numero1 - numero2;
//            int multiplicacion = numero1 * numero2;
//            int division = numero1 / numero2;
//            int residuo = numero1 % numero2;
//            double division2 = (double)numero1 / numero2;

//            //Imprimir resultados
//            Console.WriteLine("La suma de los numeros es: " + suma);
//            Console.WriteLine("La resta de los numeros es: " + resta);
//            Console.WriteLine("La multiplicacion de los numeros es: " + multiplicacion);
//            Console.WriteLine("La division de los numeros es: " + division);
//            Console.WriteLine("El residuo de los numeros es: " + residuo);

//            //Operadores comparacion
//            bool mayor = numero1 > numero2;
//            bool menor = numero1 < numero2;
//            bool igual = numero1 == numero2;
//            bool mayorIgual = numero1 >= numero2;
//            bool menorIgual = numero1 <= numero2;

//            //Imprimir resultados
//            Console.WriteLine("El numero 1 es mayor que el numero 2: " + mayor);
//            Console.WriteLine("El numero 1 es menor que el numero 2: " + menor);
//            Console.WriteLine("El numero 1 es igual que el numero 2: " + igual);
//            Console.WriteLine("El numero 1 es mayor o igual que el numero 2: " + mayorIgual);
//            Console.WriteLine("El numero 1 es menor o igual que el numero 2: " + menorIgual);

//            //Operadores logicos
//            bool and = mayor && menor;
//            bool or = mayor || menor;
//            bool not = !mayor;

//            //Imprimir resultados
//            Console.WriteLine("El resultado de la operacion and es: " + and);
//            Console.WriteLine("El resultado de la operacion or es: " + or);
//            Console.WriteLine("El resultado de la operacion not es: " + not);

//            //Operadores de asignacion
//            numero1 += 10;
//            numero1 -= 10;
//            numero1 *= 10;
//            numero1 /= 10;
//            numero1 %= 10;

//            //Imprimir resultados
//            Console.WriteLine("El valor de numero 3 es: " + numero1);



//        }
//    }
//}


//primer metodo

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Crear un arreglo para almacenar 10 números
//        int[] numeros = new int[10];

//        // Solicitar al usuario que ingrese 10 números
//        Console.WriteLine("Ingrese 10 números:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Número {i + 1}: ");
//            numeros[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        // Mostrar los números ingresados
//        Console.WriteLine("\nNúmeros ingresados:");
//        MostrarArreglo(numeros);

//        // Ordenar el arreglo
//        Array.Sort(numeros);

//        // Mostrar los números ordenados
//        Console.WriteLine("\nNúmeros ordenados:");
//        MostrarArreglo(numeros);
//    }

//    // Método para mostrar el contenido de un arreglo
//    static void MostrarArreglo(int[] arreglo)
//    {
//        foreach (int num in arreglo)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();
//    }
//}




//Segundo metodo
//Versión 1: Básica (sin métodos adicionales)

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numeros = new int[10];

//        Console.WriteLine("Ingrese 10 números:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Número {i + 1}: ");
//            numeros[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        Console.WriteLine("\nNúmeros ingresados:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write(numeros[i] + " ");
//        }

//        Array.Sort(numeros);

//        Console.WriteLine("\n\nNúmeros ordenados:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write(numeros[i] + " ");
//        }
//    }
//}


//Versión 2: Con métodos para modularizar

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numeros = new int[10];

//        IngresarNumeros(numeros);
//        Console.WriteLine("\nNúmeros ingresados:");
//        MostrarNumeros(numeros);

//        Array.Sort(numeros);

//        Console.WriteLine("\nNúmeros ordenados:");
//        MostrarNumeros(numeros);
//    }

//    static void IngresarNumeros(int[] arreglo)
//    {
//        Console.WriteLine("Ingrese 10 números:");
//        for (int i = 0; i < arreglo.Length; i++)
//        {
//            Console.Write($"Número {i + 1}: ");
//            arreglo[i] = Convert.ToInt32(Console.ReadLine());
//        }
//    }

//    static void MostrarNumeros(int[] arreglo)
//    {
//        foreach (int num in arreglo)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();
//    }
//}



//Versión 3: Con validación de entrada

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numeros = new int[10];

//        Console.WriteLine("Ingrese 10 números:");
//        for (int i = 0; i < 10; i++)
//        {
//            bool esValido = false;
//            while (!esValido)
//            {
//                Console.Write($"Número {i + 1}: ");
//                try
//                {
//                    numeros[i] = Convert.ToInt32(Console.ReadLine());
//                    esValido = true;
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Entrada inválida. Ingrese un número.");
//                }
//            }
//        }

//        Console.WriteLine("\nNúmeros ingresados:");
//        MostrarNumeros(numeros);

//        Array.Sort(numeros);

//        Console.WriteLine("\nNúmeros ordenados:");
//        MostrarNumeros(numeros);
//    }

//    static void MostrarNumeros(int[] arreglo)
//    {
//        foreach (int num in arreglo)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();
//    }
//}



//Versión 4: Ordenamiento manual (sin usar Array.Sort)

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numeros = new int[10];

//        Console.WriteLine("Ingrese 10 números:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Número {i + 1}: ");
//            numeros[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        Console.WriteLine("\nNúmeros ingresados:");
//        MostrarNumeros(numeros);

//        // Ordenamiento manual (Bubble Sort)
//        for (int i = 0; i < numeros.Length - 1; i++)
//        {
//            for (int j = 0; j < numeros.Length - 1 - i; j++)
//            {
//                if (numeros[j] > numeros[j + 1])
//                {
//                    int temp = numeros[j];
//                    numeros[j] = numeros[j + 1];
//                    numeros[j + 1] = temp;
//                }
//            }
//        }

//        Console.WriteLine("\nNúmeros ordenados:");
//        MostrarNumeros(numeros);
//    }

//    static void MostrarNumeros(int[] arreglo)
//    {
//        foreach (int num in arreglo)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        // Declarar un arreglo para almacenar 10 números
//        int[] numeros = new int[10];

//        // Pedir al usuario que ingrese 10 números
//        Console.WriteLine("Por favor, ingresa 10 números:");

//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write("Número {0}: ", i + 1);
//            numeros[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        // Ordenar el arreglo de números
//        Array.Sort(numeros);

//        // Mostrar los números ordenados
//        Console.WriteLine("\nLos números ordenados son:");

//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(numeros[i]);
//        }

//        // Esperar a que el usuario presione una tecla para salir
//        Console.WriteLine("\nPresiona cualquier tecla para salir...");
//        Console.ReadKey();
//    }
//}




//using System;

//class Program
//{
//    static void Main()
//    {
//        int opcion;
//        double num1, num2, resultado;

//        do
//        {
//            // Mostrar el menú de la calculadora
//            Console.WriteLine("Calculadora");
//            Console.WriteLine("1- Suma");
//            Console.WriteLine("2- Resta");
//            Console.WriteLine("3- Multiplicación");
//            Console.WriteLine("4- División");
//            Console.WriteLine("5- Elevar un número a la potencia");
//            Console.WriteLine("6- Salir");
//            Console.Write("Selecciona una opción: ");

//            // Leer la opción del usuario
//            opcion = Convert.ToInt32(Console.ReadLine());

//            if (opcion >= 1 && opcion <= 5)
//            {
//                // Pedir los números al usuario
//                Console.Write("Ingresa el primer número: ");
//                num1 = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Ingresa el segundo número: ");
//                num2 = Convert.ToDouble(Console.ReadLine());

//                // Realizar la operación seleccionada
//                switch (opcion)
//                {
//                    case 1: // Suma
//                        resultado = num1 + num2;
//                        Console.WriteLine($"El resultado de la suma es: {resultado}");
//                        break;

//                    case 2: // Resta
//                        resultado = num1 - num2;
//                        Console.WriteLine($"El resultado de la resta es: {resultado}");
//                        break;

//                    case 3: // Multiplicación
//                        resultado = num1 * num2;
//                        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
//                        break;

//                    case 4: // División
//                        if (num2 != 0)
//                        {
//                            resultado = num1 / num2;
//                            Console.WriteLine($"El resultado de la división es: {resultado}");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Error: No se puede dividir entre cero.");
//                        }
//                        break;

//                    case 5: // Potencia
//                        resultado = Math.Pow(num1, num2);
//                        Console.WriteLine($"El resultado de elevar {num1} a la potencia {num2} es: {resultado}");
//                        break;
//                }
//            }
//            else if (opcion != 6)
//            {
//                Console.WriteLine("Opción no válida. Intenta de nuevo.");
//            }

//            Console.WriteLine(); // Espacio para mejor legibilidad
//        } while (opcion != 6); // Repetir hasta que el usuario elija salir

//        Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
//    }
//}


//opcion valida probada para esta tarea 

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        int opcion;
//        List<double> numeros = new List<double>();

//        do
//        {
//            // Mostrar el menú de la calculadora
//            Console.WriteLine("Calculadora");
//            Console.WriteLine("1- Suma");
//            Console.WriteLine("2- Resta");
//            Console.WriteLine("3- Multiplicación");
//            Console.WriteLine("4- División");
//            Console.WriteLine("5- Elevar un número a la potencia");
//            Console.WriteLine("6- Salir");
//            Console.Write("Selecciona una opción: ");

//            // Leer la opción del usuario
//            opcion = Convert.ToInt32(Console.ReadLine());

//            if (opcion >= 1 && opcion <= 5)
//            {
//                // Pedir la cantidad de números
//                Console.Write("¿Cuántos números deseas ingresar? ");
//                int cantidad = Convert.ToInt32(Console.ReadLine());

//                // Limpiar la lista de números anteriores
//                numeros.Clear();

//                // Pedir los números al usuario
//                for (int i = 0; i < cantidad; i++)
//                {
//                    Console.Write($"Ingresa el número {i + 1}: ");
//                    numeros.Add(Convert.ToDouble(Console.ReadLine()));
//                }

//                // Realizar la operación seleccionada
//                switch (opcion)
//                {
//                    case 1: // Suma
//                        double suma = 0;
//                        foreach (double num in numeros)
//                        {
//                            suma += num;
//                        }
//                        Console.WriteLine($"El resultado de la suma es: {suma}");
//                        break;

//                    case 2: // Resta
//                        double resta = numeros[0];
//                        for (int i = 1; i < numeros.Count; i++)
//                        {
//                            resta -= numeros[i];
//                        }
//                        Console.WriteLine($"El resultado de la resta es: {resta}");
//                        break;

//                    case 3: // Multiplicación
//                        double multiplicacion = 1;
//                        foreach (double num in numeros)
//                        {
//                            multiplicacion *= num;
//                        }
//                        Console.WriteLine($"El resultado de la multiplicación es: {multiplicacion}");
//                        break;

//                    case 4: // División
//                        double division = numeros[0];
//                        bool error = false;
//                        for (int i = 1; i < numeros.Count; i++)
//                        {
//                            if (numeros[i] == 0)
//                            {
//                                Console.WriteLine("Error: No se puede dividir entre cero.");
//                                error = true;
//                                break;
//                            }
//                            division /= numeros[i];
//                        }
//                        if (!error)
//                        {
//                            Console.WriteLine($"El resultado de la división es: {division}");
//                        }
//                        break;

//                    case 5: // Potencia
//                        if (numeros.Count == 2)
//                        {
//                            double potencia = Math.Pow(numeros[0], numeros[1]);
//                            Console.WriteLine($"El resultado de elevar {numeros[0]} a la potencia {numeros[1]} es: {potencia}");
//                        }
//                        else
//                        {
//                            Console.WriteLine("La operación de potencia solo admite dos números.");
//                        }
//                        break;
//                }
//            }
//            else if (opcion != 6)
//            {
//                Console.WriteLine("Opción no válida. Intenta de nuevo.");
//            }

//            Console.WriteLine(); // Espacio para mejor legibilidad
//        } while (opcion != 6); // Repetir hasta que el usuario elija salir

//        Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
//    }
//}







//Calculadora con el codigo del conversor de unidades 

//using System;

//class Program
//{
//    static void Main()
//    {
//        int opcion = 0;

//        do
//        {
//            Console.Clear();
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("\nBienvenido a la Calculadora\n");
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine(" MENU PRINCIPAL\n");
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine(" 1. Suma\n" +
//                              " 2. Resta\n" +
//                              " 3. Multiplicación\n" +
//                              " 4. División\n" +
//                              " 5. Potencia\n" +
//                              " 6. Raíz cuadrada\n" +
//                              " 7. Salir\n\n");
//            Console.Write("Seleccione una opción: ");

//            if (int.TryParse(Console.ReadLine(), out opcion))
//            {
//                switch (opcion)
//                {
//                    case 1: // Suma
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("\n    1. Suma\n");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        Console.Write("Ingrese la cantidad de números que desea sumar: ");
//                        if (int.TryParse(Console.ReadLine(), out int cantidadSuma) && cantidadSuma > 0)
//                        {
//                            double suma = 0;
//                            for (int i = 0; i < cantidadSuma; i++)
//                            {
//                                Console.Write($"Ingrese el número {i + 1}: ");
//                                if (double.TryParse(Console.ReadLine(), out double numero))
//                                {
//                                    suma += numero;
//                                }
//                                else
//                                {
//                                    Console.ForegroundColor = ConsoleColor.DarkRed;
//                                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
//                                    i--; // Repetir la iteración
//                                }
//                            }
//                            Console.ForegroundColor = ConsoleColor.Green;
//                            Console.WriteLine($"\nEl resultado de la suma es: {suma}");
//                        }
//                        else
//                        {
//                            Console.ForegroundColor = ConsoleColor.DarkRed;
//                            Console.WriteLine("Cantidad no válida. Debe ser un número mayor que 0.");
//                        }
//                        break;

//                    case 2: // Resta
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("\n    2. Resta\n");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        Console.Write("Ingrese la cantidad de números que desea restar: ");
//                        if (int.TryParse(Console.ReadLine(), out int cantidadResta) && cantidadResta > 0)
//                        {
//                            Console.Write("Ingrese el primer número: ");
//                            if (double.TryParse(Console.ReadLine(), out double resta))
//                            {
//                                for (int i = 1; i < cantidadResta; i++)
//                                {
//                                    Console.Write($"Ingrese el número {i + 1}: ");
//                                    if (double.TryParse(Console.ReadLine(), out double numero))
//                                    {
//                                        resta -= numero;
//                                    }
//                                    else
//                                    {
//                                        Console.ForegroundColor = ConsoleColor.DarkRed;
//                                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
//                                        i--; // Repetir la iteración
//                                    }
//                                }
//                                Console.ForegroundColor = ConsoleColor.Green;
//                                Console.WriteLine($"\nEl resultado de la resta es: {resta}");
//                            }
//                            else
//                            {
//                                Console.ForegroundColor = ConsoleColor.DarkRed;
//                                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
//                            }
//                        }
//                        else
//                        {
//                            Console.ForegroundColor = ConsoleColor.DarkRed;
//                            Console.WriteLine("Cantidad no válida. Debe ser un número mayor que 0.");
//                        }
//                        break;

//                    case 3: // Multiplicación
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("\n    3. Multiplicación\n");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        Console.Write("Ingrese la cantidad de números que desea multiplicar: ");
//                        if (int.TryParse(Console.ReadLine(), out int cantidadMultiplicacion) && cantidadMultiplicacion > 0)
//                        {
//                            double multiplicacion = 1;
//                            for (int i = 0; i < cantidadMultiplicacion; i++)
//                            {
//                                Console.Write($"Ingrese el número {i + 1}: ");
//                                if (double.TryParse(Console.ReadLine(), out double numero))
//                                {
//                                    multiplicacion *= numero;
//                                }
//                                else
//                                {
//                                    Console.ForegroundColor = ConsoleColor.DarkRed;
//                                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
//                                    i--; // Repetir la iteración
//                                }
//                            }
//                            Console.ForegroundColor = ConsoleColor.Green;
//                            Console.WriteLine($"\nEl resultado de la multiplicación es: {multiplicacion}");
//                        }
//                        else
//                        {
//                            Console.ForegroundColor = ConsoleColor.DarkRed;
//                            Console.WriteLine("Cantidad no válida. Debe ser un número mayor que 0.");
//                        }
//                        break;

//                    case 4: // División
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("\n    4. División\n");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        Console.Write("Ingrese el dividendo: ");
//                        if (double.TryParse(Console.ReadLine(), out double dividendo))
//                        {
//                            Console.Write("Ingrese el divisor: ");
//                            if (double.TryParse(Console.ReadLine(), out double divisor) && divisor != 0)
//                            {
//                                Console.ForegroundColor = ConsoleColor.Green;
//                                Console.WriteLine($"\nEl resultado de la división es: {dividendo / divisor}");
//                            }
//                            else
//                            {
//                                Console.ForegroundColor = ConsoleColor.DarkRed;
//                                Console.WriteLine("Divisor no válido. Debe ser un número distinto de 0.");
//                            }
//                        }
//                        else
//                        {
//                            Console.ForegroundColor = ConsoleColor.DarkRed;
//                            Console.WriteLine("Dividendo no válido. Por favor, ingrese un número válido.");
//                        }
//                        break;

//                    case 5: // Potencia
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("\n    5. Potencia\n");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        Console.Write("Ingrese la base: ");
//                        if (double.TryParse(Console.ReadLine(), out double basePotencia))
//                        {
//                            Console.Write("Ingrese el exponente: ");
//                            if (double.TryParse(Console.ReadLine(), out double exponente))
//                            {
//                                Console.ForegroundColor = ConsoleColor.Green;
//                                Console.WriteLine($"\nEl resultado de {basePotencia} elevado a {exponente} es: {Math.Pow(basePotencia, exponente)}");
//                            }
//                            else
//                            {
//                                Console.ForegroundColor = ConsoleColor.DarkRed;
//                                Console.WriteLine("Exponente no válido. Por favor, ingrese un número válido.");
//                            }
//                        }
//                        else
//                        {
//                            Console.ForegroundColor = ConsoleColor.DarkRed;
//                            Console.WriteLine("Base no válida. Por favor, ingrese un número válido.");
//                        }
//                        break;

//                    case 6: // Raíz cuadrada
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("\n    6. Raíz cuadrada\n");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        Console.Write("Ingrese el número: ");
//                        if (double.TryParse(Console.ReadLine(), out double numeroRaiz) && numeroRaiz >= 0)
//                        {
//                            Console.ForegroundColor = ConsoleColor.Green;
//                            Console.WriteLine($"\nLa raíz cuadrada de {numeroRaiz} es: {Math.Sqrt(numeroRaiz)}");
//                        }
//                        else
//                        {
//                            Console.ForegroundColor = ConsoleColor.DarkRed;
//                            Console.WriteLine("Número no válido. Debe ser un número positivo.");
//                        }
//                        break;

//                    case 7: // Salir
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("Gracias por usar la Calculadora. ¡Hasta luego!...");
//                        break;

//                    default:
//                        Console.ForegroundColor = ConsoleColor.DarkRed;
//                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida del menú...");
//                        break;
//                }
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.DarkRed;
//                Console.WriteLine("Por favor, ingrese un número válido...");
//            }

//            if (opcion != 7)
//            {
//                Console.ForegroundColor = ConsoleColor.White;
//                Console.WriteLine("\nPresione cualquier tecla para continuar...");
//                Console.ReadKey();
//            }

//        } while (opcion != 7);
//    }
//}






//Ejercicios de la clase 2

// Programa 1


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese la base del rectángulo: ");
//        double baseRectangulo = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Ingrese la altura del rectángulo: ");
//        double altura = Convert.ToDouble(Console.ReadLine());

//        double area = baseRectangulo * altura;

//        Console.WriteLine($"El área del rectángulo es: {area}");
//    }
//}





// Programa 2 


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese su nombre: ");
//        string nombre = Console.ReadLine();

//        Console.Write("Ingrese su edad: ");
//        int edad = Convert.ToInt32(Console.ReadLine());

//        string resultado = $"Nombre: {nombre}, Edad: {edad}";


//        Console.WriteLine(resultado);
//    }
//}


// Programa 3

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese la temperatura en grados Celsius: ");
//        double celsius = Convert.ToDouble(Console.ReadLine());

//        double fahrenheit = (celsius * 9 / 5) + 32;

//        Console.WriteLine($"{celsius}°C equivale a {fahrenheit}°F");
//    }
//}



// Programa 4

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese su peso en kilogramos: ");
//        double peso = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Ingrese su altura en metros: ");
//        double altura = Convert.ToDouble(Console.ReadLine());

//        double imc = peso / (altura * 2);

//        Console.WriteLine($"Su índice de masa corporal (IMC) es: {imc:F2}");
//    }
//}





// Programa 5


//using System;

//class Program
//{
//    static void Main()
//    {
//        const double tipoCambio = 0.85; // 1 dólar = 0.85 euros

//        Console.Write("Ingrese la cantidad en dólares: ");
//        double dolares = Convert.ToDouble(Console.ReadLine());

//        double euros = dolares * tipoCambio;

//        Console.WriteLine($"{dolares} dólares equivalen a {euros:F2} euros");
//    }
//}



// Programa 6

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese la longitud del lado 1: ");
//        double lado1 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Ingrese la longitud del lado 2: ");
//        double lado2 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Ingrese la longitud del lado 3: ");
//        double lado3 = Convert.ToDouble(Console.ReadLine());

//        double perimetro = lado1 + lado2 + lado3;

//        Console.WriteLine($"El perímetro del triángulo es: {perimetro}");
//    }
//}



// Programa 7

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese su edad: ");
//        int edad = Convert.ToInt32(Console.ReadLine());

//        if (edad > 18)
//        {
//            Console.WriteLine("Usted es mayor de 18 años.");
//        }
//        else
//        {
//            Console.WriteLine("Usted no es mayor de 18 años.");
//        }
//    }
//}




// Programa 8

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese un número: ");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        if (numero > 0)
//        {
//            Console.WriteLine("El número es positivo.");
//        }
//        else if (numero < 0)
//        {
//            Console.WriteLine("El número es negativo.");
//        }
//        else
//        {
//            Console.WriteLine("El número es cero.");
//        }
//    }
//}



// Programa 9 

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese la temperatura: ");
//        double temperatura = Convert.ToDouble(Console.ReadLine());

//        if (temperatura <= 0)
//        {
//            Console.WriteLine("El agua está en estado sólido (hielo).");
//        }
//        else if (temperatura > 0 && temperatura < 100)
//        {
//            Console.WriteLine("El agua está en estado líquido.");
//        }
//        else
//        {
//            Console.WriteLine("El agua está en estado gaseoso (vapor).");
//        }
//    }
//}




//// Programa 10

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese la temperatura: ");
//        double temperatura = Convert.ToDouble(Console.ReadLine());

//        if (temperatura < 10)
//        {
//            Console.WriteLine("Se recomienda quedarse en casa.");
//        }
//        else if (temperatura >= 10 && temperatura < 20)
//        {
//            Console.WriteLine("Se recomienda salir a caminar con una chaqueta.");
//        }
//        else
//        {
//            Console.WriteLine("Se recomienda hacer actividades al aire libre.");
//        }
//    }
//}






// Programa 11

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese la temperatura: ");
//        double temperatura = Convert.ToDouble(Console.ReadLine());

//        // Tarea 1: Estado del agua
//        if (temperatura <= 0)
//        {
//            Console.WriteLine("El agua está en estado sólido (hielo).");
//        }
//        else if (temperatura > 0 && temperatura < 100)
//        {
//            Console.WriteLine("El agua está en estado líquido.");
//        }
//        else
//        {
//            Console.WriteLine("El agua está en estado gaseoso (vapor).");
//        }

//        // Tarea 2: Recomendación de actividad
//        if (temperatura < 10)
//        {
//            Console.WriteLine("Se recomienda quedarse en casa.");
//        }
//        else if (temperatura >= 10 && temperatura < 20)
//        {
//            Console.WriteLine("Se recomienda salir a caminar con una chaqueta.");
//        }
//        else
//        {
//            Console.WriteLine("Se recomienda hacer actividades al aire libre.");
//        }
//    }
//}



// Programa 12

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Solicitar los valores de A, B y C al usuario
//        Console.Write("Ingrese el valor de A: ");
//        int A = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Ingrese el valor de B: ");
//        int B = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Ingrese el valor de C: ");
//        int C = Convert.ToInt32(Console.ReadLine());

//        // Comparar los valores
//        if (A == B && B == C)
//        {
//            Console.WriteLine("Son iguales");
//        }
//        else
//        {
//            Console.WriteLine("Distintos");
//        }


//        // Programa 13

//        Console.WriteLine("INGRESE EL VALOR DE Ant");
//        int Ant = int.Parse(Console.ReadLine());

//        Console.WriteLine("INGRESE EL VALOR DE Cat");
//        char Cat = char.Parse(Console.ReadLine());

//        if (Cat == 'A' || ((Ant >= 10) && (Ant <= 20)))
//        {
//            Console.WriteLine("Socio VIP");
//        }
//        else
//        {
//            Console.WriteLine("NO SE CUMPLE");
//        }

//    }
//}


// Programa 14


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su fecha de nacimiento (formato: dd/MM/yyyy): ");
        string fechaTexto = Console.ReadLine();

        // Intentar convertir la entrada a una fecha válida
        if (DateTime.TryParseExact(fechaTexto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
        {
            // Obtener el día de la semana
            DayOfWeek diaSemana = fechaNacimiento.DayOfWeek;

            // Mostrar el resultado
            Console.WriteLine($"Usted nació un {TraducirDiaSemana(diaSemana)}.");
        }
        else
        {
            Console.WriteLine("Fecha inválida. Por favor, ingrese la fecha en el formato dd/MM/yyyy.");
        }
    }

    // Método para traducir el día de la semana al español
    static string TraducirDiaSemana(DayOfWeek dia)
    {
        switch (dia)
        {
            case DayOfWeek.Sunday: return "domingo";
            case DayOfWeek.Monday: return "lunes";
            case DayOfWeek.Tuesday: return "martes";
            case DayOfWeek.Wednesday: return "miércoles";
            case DayOfWeek.Thursday: return "jueves";
            case DayOfWeek.Friday: return "viernes";
            case DayOfWeek.Saturday: return "sábado";
            default: return "día desconocido";
        }
    }
}


// Programa 15    calendario

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Obtener la fecha actual
//        DateTime fechaActual = DateTime.Now;
//        int año = fechaActual.Year;
//        int mes = fechaActual.Month;

//        // Obtener el primer día del mes
//        DateTime primerDiaMes = new DateTime(año, mes, 1);

//        // Obtener el día de la semana del primer día del mes (0 = domingo, 1 = lunes, ..., 6 = sábado)
//        int diaSemanaPrimerDia = (int)primerDiaMes.DayOfWeek;

//        // Obtener el número de días en el mes
//        int diasEnMes = DateTime.DaysInMonth(año, mes);

//        // Mostrar el encabezado del calendario
//        Console.WriteLine($"{primerDiaMes.ToString("MMMM yyyy").ToUpper()}\n");
//        Console.WriteLine("lu ma mi ju vi sá do");

//        // Crear espacios en blanco para alinear el primer día
//        for (int i = 0; i < diaSemanaPrimerDia; i++)
//        {
//            Console.Write("   ");
//        }

//        // Mostrar los días del mes
//        for (int dia = 1; dia <= diasEnMes; dia++)
//        {
//            Console.Write($"{dia,2} "); // Mostrar el día con 2 dígitos

//            // Si es sábado, saltar a la siguiente línea
//            if ((dia + diaSemanaPrimerDia) % 7 == 0)
//            {
//                Console.WriteLine();
//            }
//        }

//        Console.WriteLine(); // Salto de línea final
//    }
//}





// programa 16 primer letra del nombre

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Solicitar al usuario que ingrese su nombre
//        Console.Write("Ingrese su nombre: ");
//        string nombre = Console.ReadLine();

//        // Verificar que el nombre no esté vacío
//        if (!string.IsNullOrEmpty(nombre))
//        {
//            // Obtener la primera letra del nombre
//            char inicial = nombre[0];

//            // Mostrar la inicial
//            Console.WriteLine($"La inicial de su nombre es: {inicial}");
//        }
//        else
//        {
//            Console.WriteLine("No ha ingresado un nombre válido.");
//        }
//    }
//}











