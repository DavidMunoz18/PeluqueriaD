using PeluqueriaD.Servicios;

namespace PeluqueriaD
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 280923 - dmp
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo de entrada de la aplicación
        /// 280923 - dmp
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            mi.mostrarmensajeBienvenida();

                // variable que controla la entrada y salida del bucle
                ; bool cerrarMenu = false;

            //contener la opcción del usuario
            int numeroIntroducido;

           
            while(!cerrarMenu)
            {
                numeroIntroducido = mi.mostrarMenuySeleccion();

                switch(numeroIntroducido)
                {
                    case 0: Console.WriteLine("[INFO] Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] Se ejecuta caso 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] Se ejecuta caso 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] Se ejecuta caso 3");
                        break;



                        default:
                     Console.WriteLine("[INFO] La opccion seleccionada no coincide con ninguna.");
                        break;
                        
                        
                }
            }
        }
    }
}


    

