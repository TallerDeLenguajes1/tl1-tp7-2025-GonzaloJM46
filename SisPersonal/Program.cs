using GestionEmpleados;

double montoTotal = 0;
int indiceMasCercaJub = 0;
int añosJubilarse;
int aux = 1000;
Empleado[] persona = new Empleado[3];
for (int i = 0; i < persona.Length; i++)
{
    persona[i] = new Empleado();
    Console.WriteLine("\nEscriba el nombre del empleado:");
    persona[i].Nombre = Console.ReadLine();
    Console.WriteLine("\nEscriba el apellido del empleado:");
    persona[i].Apellido = Console.ReadLine();
    Console.WriteLine("\nEscriba la fecha de nacimiento del empleado:");
    DateTime.TryParse(Console.ReadLine(), out DateTime fecNac);
    persona[i].FechaDeNacimiento = fecNac;
    Console.WriteLine("\nEscriba la fecha de ingreso del empleado:");
    DateTime.TryParse(Console.ReadLine(), out DateTime fecIngreso);
    persona[i].FechaIngreso = fecIngreso;
    Console.WriteLine("\nEscriba el sueldo basico del empleado:");
    double.TryParse(Console.ReadLine(), out double sueldo);
    persona[i].SueldoBasico = sueldo;
    Console.WriteLine("\nEscriba el estado civil del empleado:");
    char.TryParse(Console.ReadLine(), out char estadoC);
    persona[i].EstadoCivil = estadoC;
    Console.WriteLine("Ingrese el cargo (1-Auxiliar, 2-Administrativo, 3-Ingeniero, 4-Especialista, 5-Investigador):");
    int.TryParse(Console.ReadLine(), out int cargoDato);
    persona[i].Cargo = (Empleado.Cargos)cargoDato;
    montoTotal = montoTotal + persona[i].Salario();



    Console.WriteLine("\nEl empleado tiene una antiguedad de " + persona[i].Antiguedad() + " años en la empresa");
    Console.WriteLine("\nEl empleado tiene una edad de " + persona[i].Edad() + " años");
    añosJubilarse = persona[i].Jubilacion();
    int edadPers = persona[i].Edad();
    if (edadPers >= 65)
    {
        Console.WriteLine("\nEl empleado ya esta en edad de jubilarse");
    }
    else
    {
        Console.WriteLine("\nAl empleado le faltan" + añosJubilarse + " años para jubilarse");
    }
    Console.WriteLine("\nEl empleado tiene un sueldo de " + persona[i].Salario() + " pesos");


    if (añosJubilarse < aux)
    {
        aux = añosJubilarse;
        indiceMasCercaJub = i;
    }
}

Console.WriteLine("\nel total de lo que se paga en concepto de salarios es de " + montoTotal);

Console.WriteLine("\nlos datos de la persona mas cercana a jubilarse son:");
Console.WriteLine("\nNombre: " + persona[indiceMasCercaJub].Nombre);
Console.WriteLine("\nApellido: " + persona[indiceMasCercaJub].Apellido);

