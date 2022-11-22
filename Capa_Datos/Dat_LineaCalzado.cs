using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class Dat_LineaCalzado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Dat_LineaCalzado _instancia = new Dat_LineaCalzado();
        //privado para evitar la instanciación directa
        public static Dat_LineaCalzado Instancia
        {
            get
            {
                return Dat_LineaCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Lineas de Calzado
        public List<Ent_LineaCalzado> ListarLineaCalzado()
        {
            SqlCommand cmd = null;
            List<Ent_LineaCalzado> lista = new List<Ent_LineaCalzado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarLineaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ent_LineaCalzado Lin = new Ent_LineaCalzado();
                    Lin.linea_id = Convert.ToInt32(dr["linea_id"]);
                    Lin.nombre = dr["nombre"].ToString();
                    Lin.descripcion = dr["descripcion"].ToString();
                    lista.Add(Lin);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        #endregion metodos
    }
}
