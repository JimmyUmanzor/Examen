using System;
using Examen;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.WriteLine("Ingrese el nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese el número de cuenta del alumno: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese el correo electrónico del alumno: ");
            asignatura.Email = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la clase: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.WriteLine("Ingrese el horario de la clase: ");
            asignatura.Horario = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del docente de la clase: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.WriteLine("\n");

            asignatura.N1 = IngresarNota("Ingrese la nota del primer parcial  (Entre 0 y 30): ", 30);
            asignatura.N2 = IngresarNota("Ingrese la nota del segundo parcial (Entre 0 y 30): ", 30);
            asignatura.N3 = IngresarNota("Ingrese la nota del tercer parcial  (Entre 0 y 40): ", 40);

            Console.WriteLine("\n");

            asignatura.Imprimir();
        }
        catch (Exception d)
        {
            Console.WriteLine(d);
        }
    }

    static int IngresarNota(string mensaje, int maxNota)
    {
        int nota;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= maxNota)
            {
                break;
            }
            else
            {
                Console.WriteLine($"Nota inválida, debe ser un número entero entre 0 y {maxNota}.");
            }
        }
        return nota;
    }
}

