using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Entidades.Entidades;

namespace Biblioteca.Datos.Repositorios
{
    public class EditorialesRepositorio
    {
        private readonly ConexionBD conexionBd;


        public EditorialesRepositorio()
        {
            conexionBd = new ConexionBD();
        }

        public List<Editorial> GetLista()
        {
            var lista = new List<Editorial>();
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT EditorialId, NombreEditorial, RowVersion " +
                                        "FROM Editoriales ORDER BY NombreEditorial";
                    var comando = new SqlCommand(cadenaComando, cn);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var editorial = ConstruirEditorial(reader);
                            lista.Add(editorial);
                        }
                    }
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Editorial ConstruirEditorial(SqlDataReader reader)
        {
            return new Editorial()
            {
                EditorialId = reader.GetInt32(0),
                NombreEditorial = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

        public int Agregar(Editorial editorial)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "INSERT into Editoriales (NombreEditorial) VALUES" +
                                        " (@nom)";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nom", editorial.NombreEditorial);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT @@IDENTITY";
                        comando = new SqlCommand(cadenaComando, cn);
                        editorial.EditorialId = (int)(decimal)comando.ExecuteScalar();
                        cadenaComando = "SELECT RowVersion FROM Editoriales WHERE EditorialId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                        editorial.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("IX_NombreEditorial"))
                {
                    throw new Exception("Editorial Repetida");
                }
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Editorial editorial)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "DELETE FROM Editoriales WHERE EditorialId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                    comando.Parameters.AddWithValue("@r", editorial.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("REFERENCE"))
                {
                    throw new Exception("No se puede borrar este registro");
                }
                throw new Exception(e.Message);
            }
        }

        public int Editar(Editorial editorial)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "UPDATE Editoriales SET NombreEditorial=@nom " +
                                        "WHERE EditorialId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nom", editorial.NombreEditorial);
                    comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                    comando.Parameters.AddWithValue("@r", editorial.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Editoriales WHERE EditorialId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                        editorial.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("IX_NombreEditorial"))
                {
                    throw new Exception("Editorial ya existente");
                }
                throw new Exception(e.Message);
            }
        }
    }
}
