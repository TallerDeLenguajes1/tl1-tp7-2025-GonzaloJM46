namespace GestionEmpleados;

public class Empleado
{
    string nombre;
    string apellido;
    DateTime fechaDeNacimiento;
    char estadoCivil;
    DateTime fechaIngreso;
    double sueldoBasico;
    Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public enum Cargos
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5
    }

    public int Antiguedad()
    {
        DateTime actual = DateTime.Now;
        return actual.Year - FechaIngreso.Year;
        //Console.WriteLine("\nLa antiguedad en la empresa es de: " + (actual.Year - FechaIngreso.Year) + "años");
    }

    public int Edad()
    {
        DateTime actual = DateTime.Now;
        return actual.Year - fechaDeNacimiento.Year;
    }

    public void Jubilacion()
    {
        int edadEmpleado = Edad();
        if (edadEmpleado >= 65)
        {
            Console.WriteLine("\nEl empleado ya esta en edad de jubilarse");
        }
        else
        {
            Console.WriteLine("\nAl empleado le faltan" + (65 - edadEmpleado) + " años para jubilarse");
        }
    }

    public double Salario()
    {
        int antiguedad = Antiguedad();
        double adicional = 0;
        if (antiguedad < 20)
        {
            adicional = sueldoBasico * 0.01 * antiguedad;
        }
        else
        {
            adicional = sueldoBasico * 0.25;
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional = adicional * 1.5;
        }
        if (estadoCivil == 'c')
        {
            adicional = adicional + 150000;
        }
        return sueldoBasico + adicional;
    }
} 
