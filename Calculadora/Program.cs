using EspacioCalculadora;
Calculadora calc = new Calculadora();
int operacion;
Console.WriteLine("\nCalculadora:");
Console.WriteLine("\nEscriba un numero: ");
double.TryParse(Console.ReadLine(), out double valor);
do
{
    Console.WriteLine("\nEscriba una operacion: 1. Suma, 2. Resta, 3. Multiplicacion, 4. Division, 5. Limpiar, 6. Salir");
    bool excepcion = int.TryParse(Console.ReadLine(), out operacion);
    if (!excepcion || operacion < 1 || operacion > 6)
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
    

} while (operacion != 6);

Console.WriteLine("\nel dato con el que ha estado operando su valor es: " + calc.Resultado);