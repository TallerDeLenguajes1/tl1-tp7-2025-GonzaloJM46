namespace EspacioCalculadora;

public class Calculadora
{
    double dato = 0;

    public double Resultado { get => dato; }
    public void Sumar(double termino) {
        Console.WriteLine("\nsuma: " + (termino + dato)); 
    }
    public void Restar(double termino) {
        Console.WriteLine("\nResta: " + (termino - dato));
    }
    public void Multiplicar(double termino) {
        Console.WriteLine("\nMultiplicacion: " + (termino * dato));
    }
    public void Dividir(double termino) {
        Console.WriteLine("\ndivision: " + (termino / dato));
    }
    public void Limpiar()
    {
        dato = 0;
    }

}