using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Entidades.Entidades;

namespace Biblioteca.Datos.Repositorios
{
    public class AutoresRepositorios
    {
        private readonly ConexionBD conexionBd;


        public AutoresRepositorios()
        {
            conexionBd = new ConexionBD();
        }

        public List<Autor> GetLista()
        {
            var lista = new List<Autor>();
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT AutorId, Apellido, Nombre, Nacionalidad, " +
                                        "RowVersion FROM Autores";
                    var comando = new SqlCommand(cadenaComando, cn);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var autor = ConstruirAutor(reader);
                            lista.Add(autor);
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

        private Autor ConstruirAutor(SqlDataReader reader)
        {
            return new Autor()
            {
                AutorId = reader.GetInt32(0),
                Apellido = reader.GetString(1),
                Nombre =reader[2]!=DBNull.Value? reader.GetString(2):string.Empty,
                Nacionalidad = reader[3] != DBNull.Value ? reader.GetString(3) : string.Empty,
                RowVersion = (byte[])reader[4]
            };
        }

        public int Agregar(Autor autor)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "INSERT into Autores (Apellido, Nombre, Nacionalidad) VALUES (@ape, @nom, @nac)";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@ape", autor.Apellido);
                    comando.Parameters.AddWithValue("@nom", autor.Nombre);
                    comando.Parameters.AddWithValue("@nac", autor.Nacionalidad);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT @@IDENTITY";
                        comando = new SqlCommand(cadenaComando, cn);
                        autor.AutorId = (int)(decimal)comando.ExecuteScalar();
                        cadenaComando = "SELECT RowVersion FROM Autores WHERE AutorId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", autor.AutorId);
                        autor.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("IX_Apellido"))
                {
                    throw new Exception("Autor Repetido");
                }
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Autor autor)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "DELETE FROM Autores WHERE AutorId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", autor.AutorId);
                    comando.Parameters.AddWithValue("@r", autor.RowVersion);
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

        public int Editar(Autor autor)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "UPDATE Autores SET Apellido=@ape, Nombre=@nom," +
                                        " Nacionalidad=@nac WHERE AutorId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@ape", autor.Apellido);
                    comando.Parameters.AddWithValue("@nom", autor.Nombre);
                    comando.Parameters.AddWithValue("@nac", autor.Nacionalidad);
                    comando.Parameters.AddWithValue("@id", autor.AutorId);
                    comando.Parameters.AddWithValue("@r", autor.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Autores WHERE AutorId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", autor.AutorId);
                        autor.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("IX_Apellido"))
                {
                    throw new Exception("Autor ya existente");
                }
                throw new Exception(e.Message);
            }
        }
    }
}
