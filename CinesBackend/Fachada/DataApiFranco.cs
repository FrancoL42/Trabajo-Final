using CinesBackend.AccesoDatosFranco.Dao;
using CinesBackend.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.Fachada
{
    public class DataApiFranco : IDataApiFranco
    {
        IDaoFranco dao;
        public DataApiFranco()
        {
            dao = new DaoFranco();
        }

        public bool insertarComprobante(Comprobante c)
        {
            return dao.crearComprobante(c);
        }

        public List<Peliculas> traerPeliculas()
        {
            return dao.traerPeliculas();
        }

        public List<Salas> traerSalas()
        {
            return dao.traerSalas();
        }
        public bool insertarPeliculas(Peliculas p)
        {
            return dao.insertarPeliculas(p);
        }

        public List<Generos> traerGeneros()
        {
            return dao.traerGeneros();
        }

        public List<Clasificacion> traerClasificaciones()
        {
            return dao.traerClasificaciones();
        }

        public List<Idiomas> traerIdiomas()
        {
            return dao.traerIdiomas();
        }

        public bool modificarPeliculas(Peliculas p)
        {
            return dao.modificarPeliculas(p);
        }

        public bool bajaPeliculas(Peliculas p)
        {
            return dao.bajaPelicula(p);
        }

        public bool altaSalas(Salas s)
        {
           return dao.AltaSalas(s);
        }

        public List<Funciones> traerFunciones()
        {
            return dao.traerFuncionesSinParam();
        }

        public bool altaFunciones(Funciones f)
        {
           return dao.AltaFunciones(f);
        }

        public List<Peliculas> traerPeliculasCliente()
        {
           return dao.traerPeliculasCliente();
        }

        public bool modificarSala(Salas s)
        {
            return dao.modificarSala(s);
        }

        public bool bajaSala(Salas s)
        {
            return dao.bajaSala(s);
        }

        public List<Clientes> traerCliente()
        {
            return dao.obtenerClientes();
        }

        public bool bajaCliente(Clientes c)
        {
            return dao.bajaCliente(c);
        }

        public bool modificarCliente(Clientes c)
        {
            return dao.modificarCliente(c);
        }
    }
}
