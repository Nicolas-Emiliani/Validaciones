using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN8
{
    class Alumno
    {
        string alumno;
        double legajo, nota1, nota2, nota3;
        public string pAlumno { set { alumno = value; } get { return alumno; } }
        public double pLegajo { set { legajo = value; } get { return legajo; } }
        public double pNota1 { set { nota1 = value; } get { return nota1; } }
        public double pNota2 { set { nota2 = value; } get { return nota2; } }
        public double pNota3 { set { nota3 = value; } get { return nota3; } }

        public double calcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
