using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN7
{
    class Alumnos
    {
        string alumno;
        double legajo,nota1, nota2,nota3;
        public Alumnos()
        {
            alumno = "";
            legajo = 0;
            nota1 = 0.00;
            nota2 = 0.00;
            nota3 = 0.00;
        }
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
