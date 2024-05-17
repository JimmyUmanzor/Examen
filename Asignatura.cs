using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }

        private string nombreAsignatura;
        private string horario;
        private string nombreDocente;

        public string NombreAsignatura
        {
            get { return nombreAsignatura; }
            set { nombreAsignatura = value; }
        }

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public string NombreDocente
        {
            get { return nombreDocente; }
            set { nombreDocente = value; }
        }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal < 60)
            {
                return "Reprobado";
            }
            else if (notaFinal < 80)
            {
                return "Bueno";
            }
            else if (notaFinal < 90)
            {
                return "Muy Bueno";
            }
            else
            {
                return "Sobresaliente";
            }
        }

        public void Imprimir()
        {
            double notaFinal1 = CalcularNotaFinal();
            double notaFinal2 = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine("**********************************************************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Número de Cuenta     : {NumeroCuenta}");
            Console.WriteLine($"Correo electrónico   : {Email}");
            Console.WriteLine($"Nombre de la Clase   : {NombreAsignatura}");
            Console.WriteLine($"Horario              : {Horario}");
            Console.WriteLine($"Nombre del docente   : {NombreDocente}");
            Console.WriteLine($"Nota Final           : {notaFinal1} - {MensajeNotaFinal(notaFinal1)}");
            Console.WriteLine($"Nota Final           : {notaFinal2} - {MensajeNotaFinal(notaFinal2)}");
            Console.WriteLine("**********************************************************************");
            Console.ReadLine();

        }

    }

}
