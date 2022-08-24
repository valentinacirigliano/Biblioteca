using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos.Repositorios;
using Biblioteca.Entidades.Entidades;

namespace Biblioteca.Servicios.Servicios
{
    public class EditorialesServicios
    {
        private readonly EditorialesRepositorio repositorio;
        public EditorialesServicios()
        {
            repositorio = new EditorialesRepositorio();
        }

        public List<Editorial> GetLista()
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

        public int Agregar(Editorial editorial)
        {
            try
            {
                return repositorio.Agregar(editorial);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int Borrar(Editorial editorial)
        {
            try
            {
                return repositorio.Borrar(editorial);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(Editorial editorial)
        {
            try
            {
                return repositorio.Editar(editorial);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
