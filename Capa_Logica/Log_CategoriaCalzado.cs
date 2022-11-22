using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Logica
{
    public class Log_CategoriaCalzado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Log_CategoriaCalzado _instancia = new Log_CategoriaCalzado();
        //privado para evitar la instanciación directa
        public static Log_CategoriaCalzado Instancia
        {
            get
            {
                return Log_CategoriaCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<Ent_CategoriaCalzado> ListarCategoriaCalzado()
        {
            return Dat_CategoriaCalzado.Instancia.ListarCategoriaCalzado();
        }
        #endregion metodos

    }
}
