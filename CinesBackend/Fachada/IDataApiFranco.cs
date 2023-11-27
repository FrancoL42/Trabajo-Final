using CinesBackend.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.Fachada
{
    public interface IDataApiFranco
    {
        List<Salas> traerSalas();
        List<Peliculas> traerPeliculas();
        List<Generos> traerGeneros();
        List<Clasificacion> traerClasificaciones();
        List<Idiomas> traerIdiomas();
        List<Funciones> traerFunciones();
        List<Peliculas> traerPeliculasCliente();
        List<Clientes> traerCliente();
        bool insertarComprobante(Comprobante c);
        bool insertarPeliculas(Peliculas p);
        bool modificarPeliculas(Peliculas p);
        bool altaSalas(Salas s);
        bool bajaPeliculas(Peliculas p);
        bool altaFunciones(Funciones f);
        bool modificarSala(Salas s);
        bool bajaSala(Salas s);
        bool bajaCliente(Clientes c);
        bool modificarCliente(Clientes c);
    }
}
