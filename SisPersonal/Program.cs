using GestionEmpleados;


Empleado persona = new Empleado();
Console.WriteLine("\nEscriba el nombre del empleado:");
persona.Nombre = Console.ReadLine();
Console.WriteLine("\nEscriba el apellido del empleado:");
persona.Apellido = Console.ReadLine();
Console.WriteLine("\nEscriba la fecha de nacimiento del empleado:");
DateTime.TryParse(Console.ReadLine(), out DateTime fecNac);
persona.FechaDeNacimiento = fecNac;
Console.WriteLine("\nEscriba la fecha de ingreso del empleado:");
DateTime.TryParse(Console.ReadLine(), out DateTime fecIngreso);
persona.FechaIngreso = fecIngreso;
Console.WriteLine("\nEscriba el sueldo basico del empleado:");
double.TryParse(Console.ReadLine(), out double sueldo);
persona.SueldoBasico = sueldo;
Console.WriteLine("\nEscriba el estado civil del empleado:");
char.TryParse(Console.ReadLine(), out char estadoC);
persona.EstadoCivil = estadoC;
Console.WriteLine("Ingrese el cargo (1-Auxiliar, 2-Administrativo, 3-Ingeniero, 4-Especialista, 5-Investigador):");
int.TryParse(Console.ReadLine(), out int cargoDato);
persona.Cargo = (Empleado.Cargos)cargoDato;

Console.WriteLine("\nEl empleado tiene una antiguedad de " + persona.Antiguedad() + " años en la empresa");
Console.WriteLine("\nEl empleado tiene una edad de " + persona.Edad() + " años");
persona.Jubilacion();
Console.WriteLine("\nEl empleado tiene un sueldo de " + persona.Salario() + " pesos");