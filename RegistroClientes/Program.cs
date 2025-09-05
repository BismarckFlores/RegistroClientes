using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroClientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static string ProcesarRegistro(string nombre)
        {
            try
            {
                string nombreNormalizado = nombre.Trim().ToUpper();
                return nombreNormalizado;
            }
            catch (NullReferenceException)
            {
                return "(vacío)";
            }
        }
    }
}
