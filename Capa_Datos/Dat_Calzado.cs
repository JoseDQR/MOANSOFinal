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
    public class Dat_Calzado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Dat_Calzado _instancia = new Dat_Calzado();
        //privado para evitar la instanciación directa
        public static Dat_Calzado Instancia
        {
            get
            {
                return Dat_Calzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<Ent_Calzado> ListarCalzado()
        {
            SqlCommand cmd = null;
            List<Ent_Calzado> lista = new List<Ent_Calzado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ent_Calzado cal = new Ent_Calzado();
                    cal.calzado_id = Convert.ToInt32(dr["calzado_id"]);
                    cal.linea_id = Convert.ToInt32(dr["linea_id"]);
                    cal.categoria_id = Convert.ToInt32(dr["categoria_id"]);
                    cal.stock = Convert.ToInt32(dr["stock"]);
                    lista.Add(cal);
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

        /////////////////////////Insertar calzado
        public Boolean InsertarCalzado(Ent_Calzado cal)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lin", cal.linea_id);
                cmd.Parameters.AddWithValue("@cat", cal.categoria_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //////////////////////////////////Edita Linea de calzado
        public Boolean EditarCalzado(Ent_Calzado cal)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCalzado", cal.calzado_id);
                cmd.Parameters.AddWithValue("@lin", cal.linea_id);
                cmd.Parameters.AddWithValue("@cat", cal.categoria_id);
                cmd.Parameters.AddWithValue("@@sto", cal.stock);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        /////////////////////////Eliminar Linea de calzado
        public Boolean EliminarCalzado(Ent_Calzado cal)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCalzado", cal.calzado_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
        #endregion metodos
    }
}
