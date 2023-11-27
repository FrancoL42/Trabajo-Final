using CinesBackend.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.AccesoDatosFranco.Dao
{
    public interface IDaoFranco
    {
        List<Salas> traerSalas();
        List<Funciones> traerFunciones(string pelicula, string fecha);
        List<Funciones> traerFuncionesSinParam();
        List<Generos> traerGeneros();
        List<Clasificacion> traerClasificaciones();
        List<Idiomas> traerIdiomas();
        List<Peliculas> traerPeliculas();
        List<ButacasxSalas> traerButacasxSalas(int id);
        List<Peliculas> traerPeliculasCliente();
        bool crearComprobante(Comprobante c);//ABM CLIENTES
        bool bajaCliente(Clientes c);
        bool modificarCliente(Clientes c);
        List<Clientes> obtenerClientes();
        bool insertarPeliculas(Peliculas p);//ABM PELICULAS
        bool modificarPeliculas(Peliculas p);
        bool bajaPelicula(Peliculas p);
        bool AltaSalas(Salas s); //ABM SALAS
        bool modificarSala(Salas s);
        bool bajaSala(Salas s);
        bool AltaFunciones(Funciones f);//ABM FUNCIONES
        bool IniciarSesion(string usuario, string contrasenia, out int idEmpleado, out int idCargo);//LOGIN
        
    }
}
