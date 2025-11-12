using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Empleados
{
    internal class EmpleadoTemporal : Empleado
    {
        protected int mesesContrato;

        public EmpleadoTemporal() { }

        public EmpleadoTemporal(int id, string nombre, string apellido, decimal sueldoBase, int mesesContrato)
            : base(id, nombre, apellido, sueldoBase)
        {
            this.mesesContrato = mesesContrato;
        }

        public int MesesContrato { get => mesesContrato; set => mesesContrato = value; }

        public override decimal CalcularSueldo()
        {
            decimal extra = 0m;
            if (mesesContrato < 6) extra = sueldoBase * 0.05m;
            return sueldoBase + extra;
        }

        public override void mostrar()
        {
            Console.WriteLine("empleado temporal id: " + id + " nombre: " + nombre + " apellido: " + apellido + " meses contrato: " + mesesContrato + " sueldo: " + CalcularSueldo());
        }
    }
}

