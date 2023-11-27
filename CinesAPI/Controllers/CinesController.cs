using Microsoft.AspNetCore.Mvc;
using CinesBackend.Fachada;
using CinesBackend.Clases;

namespace CinesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinesController : ControllerBase
    {
        public IDataApiFranco dataApiFranco;
        public CinesController()
        {
            dataApiFranco = new DataApiFranco();
        }
        [HttpGet("/traerClientes")]
        public IActionResult traerClientes()
        {
            try
            {
                return Ok(dataApiFranco.traerCliente());
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpGet("/TraerPeliculasCliente")]
        public IActionResult traerPeliculasCliente()
        {
            try
            {
                return Ok(dataApiFranco.traerPeliculasCliente());
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpGet("/TraerSalas")]
        public IActionResult traerSalas()
        {
           
            try
            {
                return Ok(dataApiFranco.traerSalas());
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpGet("/TraerClasificaciones")]
        public IActionResult traerClasificaciones()
        {
            try
            {
                return Ok(dataApiFranco.traerClasificaciones());
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpGet("/TraerIdiomas")]
        public IActionResult traerIdiomas()
        {
            try
            {
                return Ok(dataApiFranco.traerIdiomas());
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpGet("/TraerGeneros")]
        public IActionResult traerGeneros()
        {
            try
            {
                return Ok(dataApiFranco.traerGeneros());
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpGet("/TraerPeliculas")]
        public IActionResult traerPeliculas()
        {
            try
            {
                return Ok(dataApiFranco.traerPeliculas());
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpGet("/TraerFunciones")]
        public IActionResult traerFunciones()
        {
            try
            {
                return Ok(dataApiFranco.traerFunciones());
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde"); 
            }
        }
       
        [HttpPost("/insertarPelicula")]
        public IActionResult insertarPeliculas(Peliculas p)
        {
            try
            {
                return Ok(dataApiFranco.insertarPeliculas(p));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpPost("/AltaComprobante")]
        public IActionResult altaComprobante(Comprobante c)
        {
            try
            {
                return Ok(dataApiFranco.insertarComprobante(c));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpPost("/AltaSala")]
        public IActionResult altaSalas(Salas s)
        {
            try
            {
                return Ok(dataApiFranco.altaSalas(s));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpPost("/AltaFunciones")]
        public IActionResult altaFunciones(Funciones f)
        {
            try
            {
                return Ok(dataApiFranco.altaFunciones(f));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }

        [HttpPut("/ModificarPelicula")]
        public IActionResult modificarPelicula(Peliculas p)
        {
            try
            {
                return Ok(dataApiFranco.modificarPeliculas(p));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpPut("/BajaPelicula")]
        public IActionResult bajaPelicula(Peliculas p)
        {
            try
            {
                return Ok(dataApiFranco.bajaPeliculas(p));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpPut("/ModificarSala")]
        public IActionResult modificarSala(Salas s)
        {
            try
            {
                return Ok(dataApiFranco.modificarSala(s));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpPut("/modificarCliente")]
        public IActionResult modificarCliente(Clientes c)
        {
            try
            {
                return Ok(dataApiFranco.modificarCliente(c));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpPut("/BajaSala")]
        public IActionResult bajaSala(Salas s)
        {
            try
            {
                return Ok(dataApiFranco.bajaSala(s));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
        [HttpPut("/bajaCliente")]
        public IActionResult bajaCliente(Clientes c)
        {
            try
            {
                return Ok(dataApiFranco.bajaCliente(c));
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno, Intente mas Tarde");
            }
        }
    }
}