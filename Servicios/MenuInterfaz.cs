using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaD.Servicios
{
    /// <summary>
    /// Interfaz que da la funcionalidad menú
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el mensaje de bienvenida
        /// 280923 - dmp
        /// </summary>
        public void mostrarmensajeBienvenida();
        /// <summary>
        /// Metodo que muestra el menu y recoge la opccion escogida
        /// 280923 - dmp
        /// </summary>
        /// <returns></returns>

        public int mostrarMenuySeleccion();
    }
}
