using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Logica
{
    public class Log_LineaCalzado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Log_LineaCalzado _instancia = new Log_LineaCalzado();
        //privado para evitar la instanciación directa
        public static Log_LineaCalzado Instancia
        {
            get
            {
                return Log_LineaCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<Ent_LineaCalzado> ListarLineaCalzado()
        {
            return Dat_LineaCalzado.Instancia.ListarLineaCalzado();
        }
        #endregion metodos
    }
}
