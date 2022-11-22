using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Logica
{
    public class Log_Calzado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Log_Calzado _instancia = new Log_Calzado();
        //privado para evitar la instanciación directa
        public static Log_Calzado Instancia
        {
            get
            {
                return Log_Calzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<Ent_Calzado> ListarCalzado()
        {
            return Dat_Calzado.Instancia.ListarCalzado();
        }

        ///inserta
        public void InsertarCalzado(Ent_Calzado cal)
        {
            Dat_Calzado.Instancia.InsertarCalzado(cal);
        }

        //edita
        public void EditarCalzado(Ent_Calzado cal)
        {
            Dat_Calzado.Instancia.EditarCalzado(cal);
        }

        //elimina
        public void EliminaCalzado(Ent_Calzado cal)
        {
            Dat_Calzado.Instancia.EliminarCalzado(cal);
        }
        #endregion metodos
    }
}
