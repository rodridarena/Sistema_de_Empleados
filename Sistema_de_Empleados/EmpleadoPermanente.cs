using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Empleados
{
    internal class EmpleadoPermanente : Empleado
    {
        protected int aniosAntiguedad;

        public EmpleadoPermanente() { }

        public EmpleadoPermanente(int id, string nombre, string apellido, decimal sueldoBase, int aniosAntiguedad)
            : base(id, nombre, apellido, sueldoBase)
        {
            this.aniosAntiguedad = aniosAntiguedad;
        }

        public int AniosAntiguedad { get => aniosAntiguedad; set => aniosAntiguedad = value; }

        public override decimal CalcularSueldo()
        {
            decimal extra = sueldoBase * (0.02m * aniosAntiguedad);
            return sueldoBase + extra;
        }

        public override void mostrar()
        {
            Console.WriteLine("empleado permanente id: " + id + " nombre: " + nombre + " apellido: " + apellido + " antiguedad: " + aniosAntiguedad + " sueldo: " + CalcularSueldo());
        }
    }
}