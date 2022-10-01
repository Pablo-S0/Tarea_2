using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] salarios = { 1500, 6000, 8000, 9000 };
            String[] empleados = { "Federico", "Amanda", "Manolo", "Cristina" };
            
            int i = 0;

            foreach (var empleado in empleados)
            {
                aguinaldo(salarios[i], empleado);
                i++;
            }

            int aux = 0;
            String mensaje = " ";

            foreach (var empleado in empleados)
            {
                if (empleado.Length>aux)
                {
                    aux = empleado.Length;
                    mensaje = empleado;
                }

                if (empleado.Length == aux && empleado != mensaje)
                {
                    aux = empleado.Length;
                    mensaje += $" {empleado}";
                }
            }

            Console.WriteLine(mensaje);
            Console.ReadLine();
        }


        public static void aguinaldo (float salarioA, string nombresA)
        {
            float aguinaldo = salarioA * 12;

            Console.WriteLine($"Nombre: {nombresA}, Salario Base: {salarioA}, Aguinaldo: {aguinaldo}");
            Console.ReadLine();

        }
    }
}
