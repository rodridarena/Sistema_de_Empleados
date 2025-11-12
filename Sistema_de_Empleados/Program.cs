namespace Sistema_de_Empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new EmpleadoPermanente(1, "moni", "argento", 500000m, 3));
            listaEmpleados.Add(new EmpleadoTemporal(2, "maría elena", "fusceneco", 420000m, 4));

            Console.WriteLine("empleados registrados");
            foreach (Empleado e in listaEmpleados)
            {
                e.mostrar();
                Console.WriteLine();
            }

            AgregarEmpleado(new EmpleadoTemporal(3, "dardo", "fusceneco", 380000m, 8));

            Console.WriteLine("empleados registrados despues de agregar");
            foreach (Empleado e in listaEmpleados)
            {
                e.mostrar();
                Console.WriteLine();
            }

            // modificar por id 
            ModificarEmpleado(2, 450000m);

            Console.WriteLine("empleados registrados despues de modificar");
            foreach (Empleado e in listaEmpleados)
            {
                e.mostrar();
                Console.WriteLine();
            }

            // eliminar por id
            EliminarEmpleado(1);

            Console.WriteLine("empleados registrados despues de eliminar");
            foreach (Empleado e in listaEmpleados)
            {
                e.mostrar();
                Console.WriteLine();
            }

            void AgregarEmpleado(Empleado emp)
            {
                listaEmpleados.Add(emp);
            }

            void ModificarEmpleado(int id, decimal nuevoSueldoBase)
            {
                foreach (Empleado e in listaEmpleados)
                {
                    if (e.Id == id)
                    {
                        e.SueldoBase = nuevoSueldoBase;
                    }
                }
            }

            void EliminarEmpleado(int id)
            {
                Empleado aEliminar = null;
                foreach (Empleado e in listaEmpleados)
                {
                    if (e.Id == id)
                    {
                        aEliminar = e;
                    }
                }

                if (aEliminar != null) listaEmpleados.Remove(aEliminar);
            }
        }
    }
}