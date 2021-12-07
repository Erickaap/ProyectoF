using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoF
{
    public class BaseDatos
    {
        readonly string cadena = "Data Source=.; Initial Catalog=ProyectoFinal; Integrated Security=True";

        public bool ValidarUsuario(string Usuario, string Contraseña)
        {
            bool esUsuarioValido = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT 1 FROM USUARIOS WHERE USUARIO = @Usuario AND CONTRASEÑA = @Contraeña  = 1;");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = Usuario;
                        comando.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 50).Value = Contraseña;

                        esUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception)
            {
            }
            return esUsuarioValido;
        }
        public DataTable SeleccionarClientes()
        {

            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM CLIENTES");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }

                }
            }
            catch (Exception)
            {
            }
            return dt;
        }
        public bool EliminarClientes(int Id)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM CLIENTES");
                sql.Append(" WHERE ID = @Id ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {

                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                        comando.ExecuteNonQuery();
                        return true;
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Clientes(string Nombre, string Apellido, int dni, string Telefono)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO  CLIENTES");
                sql.Append(" VALUES (@Nombre, @Apellido, @DNI, @Telefono);");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = Nombre;
                        comando.Parameters.Add("@Apellido", SqlDbType.NVarChar, 50).Value = Apellido;
                        comando.Parameters.Add("@dni", SqlDbType.Int).Value = dni;
                        comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50).Value = Telefono;

                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable ListarUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT");
                sql.Append("FROM PRODUCTOS P");
                sql.Append("INNER JOIN CATEGORIAS C ON C.ID = P.IDCATEGORIAS");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return dt;

        }
        
    public bool Boleteria(int Asiento, string Destino, int Telefono, string Descripcion, int Placa, DateTime Fecha)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO CLIENTES");
                sql.Append("VALUES(@Asiento, @Destino, @NTelefono, @Descripcion, @Placa, @Fecha ); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {

                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Asiento", SqlDbType.Int).Value = Asiento;
                        comando.Parameters.Add("@Destino", SqlDbType.NVarChar, 50).Value = Destino;
                        comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = Telefono;
                        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50).Value = Descripcion;
                        comando.Parameters.Add("@Placa", SqlDbType.Int).Value = Placa;
                        comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Fecha;
                        comando.ExecuteNonQuery();
                        return true;
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
