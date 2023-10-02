using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaD.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarmensajeBienvenida()
        {
            string mensaje = "PeluqueriaD";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuySeleccion()
        {
            int numeroIntroducido; 
            Console.WriteLine("#############################");
            Console.WriteLine("0. Salir de la aplicacion ");
            Console.WriteLine("1. Pedir cita");
            Console.WriteLine("2. Cancelar cita");
            Console.WriteLine("3. Escribir una reseña");
            Console.WriteLine("#############################");

            numeroIntroducido = Console.ReadKey(true).KeyChar - ('0');

            return numeroIntroducido;
        }
    }
}
