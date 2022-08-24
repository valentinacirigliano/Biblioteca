using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos.Repositorios;
using Biblioteca.Entidades.Entidades;

namespace Biblioteca.Servicios.Servicios
{
    public class AutoresServicios
    {
        private readonly AutoresRepositorios repositorio;
        public AutoresServicios()
        {
            repositorio = new AutoresRepositorios();
        }

        public List<Autor> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Agregar(Autor autor)
        {
            try
            {
                return repositorio.Agregar(autor);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int Borrar(Autor autor)
        {
            try
            {
                return repositorio.Borrar(autor);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(Autor autor)
        {
            try
            {
                return repositorio.Editar(autor);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
