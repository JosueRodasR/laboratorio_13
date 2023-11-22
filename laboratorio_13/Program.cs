using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = PANTALLAS.PantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = PANTALLAS.RealizarEncuesta();
                        break;
                    case 2:
                        opcion = PANTALLAS.VerDatosRegistrados();
                        break;
                    case 3:
                        opcion = PANTALLAS.EliminarUnDato();
                        break;
                    case 0:
                    default:
                        opcion = PANTALLAS.PantallaPrincipal();
                        break;
                }
            } while (opcion != 4);
        }
    }
}
