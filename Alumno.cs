using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Alumno
    {
        private string nombreAlumno;
        private string numeroCuenta;
        private string email;

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public string NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }

}
