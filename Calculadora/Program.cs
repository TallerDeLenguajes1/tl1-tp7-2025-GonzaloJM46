using EspacioCalculadora;
Calculadora calc = new Calculadora();
Console.WriteLine("\nCalculadora:");
Console.WriteLine("\nEscriba una operacion: 1. Suma, 2. Resta, 3. Multiplicacion, 4. Division, 5. Limpiar, 6. Salir");
bool excepcion = int.TryParse(Console.ReadLine(), out int operacion);
Console.WriteLine("\nEscriba un numero: ");
double.TryParse(Console.ReadLine(), out double valor);
do
{
    if (!excepcion)
    {
        Console.WriteLine("Error, no ingresó una operacion valida");
    }
    else
    {

        switch (operacion)
        {
            case 1:
                calc.Sumar(valor);
                break;
            case 2:
                calc.Restar(valor);
                break;
            case 3:
                calc.Multiplicar(valor);
                break;
            case 4:
                calc.Dividir(valor);
                break;
            case 5:
                calc.Limpiar();
                break;
        }
    }
    Console.WriteLine("\nEscriba una operacion: 1. Suma, 2. Resta, 3. Multiplicacion, 4. Division, 5. Limpiar, 6. Salir");
    excepcion = int.TryParse(Console.ReadLine(), out operacion);
    
} while (operacion != 6);