using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroClientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string numWhatsapp;
            string nombreProcesado;

            Console.WriteLine("+++++++ Bienvenido a la Feria de Emprendimiento +++++++");
            Console.WriteLine("Por favor digite los siguientes datos: ");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Número de Whatsapp: ");
            numWhatsapp = Console.ReadLine();
            nombreProcesado = ProcesarRegistro(nombre);
            Console.WriteLine("\n--- Registro Exitoso ---");
            Console.WriteLine($"Nombre: {nombreProcesado}");
            Console.WriteLine($"Whatsapp: {numWhatsapp}");
        }
        public static string ProcesarRegistro(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                nombre = null;
            }
            try
            {
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                return ti.ToTitleCase(nombre.Trim().ToLower());
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("\n--- Error de Registro ---");
                Console.WriteLine("Nombre no proporcionado. No es posible normalizar los datos del cliente.\n");
                return "(vacío)";
            }
        }
    }
}