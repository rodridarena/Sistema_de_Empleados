using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Empleados
{
    internal class Empleado
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected decimal sueldoBase;

        public Empleado() { }

        public Empleado(int id, string nombre, string apellido, decimal sueldoBase)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBase = sueldoBase;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public decimal SueldoBase { get => sueldoBase; set => sueldoBase = value; }

        public virtual decimal CalcularSueldo()
        {
            return sueldoBase;
        }

        public virtual void mostrar()
        {
            Console.WriteLine("empleado id: " + id + " nombre: " + nombre + " apellido: " + apellido + " sueldo: " + CalcularSueldo());
        }
    }
}