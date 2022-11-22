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
    public class Dat_CategoriaCalzado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Dat_CategoriaCalzado _instancia = new Dat_CategoriaCalzado();
        //privado para evitar la instanciación directa
        public static Dat_CategoriaCalzado Instancia
        {
            get
            {
                return Dat_CategoriaCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Categoria de Calzado
        public List<Ent_CategoriaCalzado> ListarCategoriaCalzado()
        {
            SqlCommand cmd = null;
            List<Ent_CategoriaCalzado> lista = new List<Ent_CategoriaCalzado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCategoriaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ent_CategoriaCalzado cat = new Ent_CategoriaCalzado();
                    cat.categoria_id = Convert.ToInt32(dr["categoria_id"]);
                    cat.nombre = dr["nombre"].ToString();
                    cat.descripcion = dr["descripcion"].ToString();
                    lista.Add(cat);
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
