using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMongoDB.Models;
using ApiMongoDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiMongoDB.Controllers
{
    [ApiController]
    [Route("Productos")]
    public class ProductosController : ControllerBase
    {
        private IServicios servicios;
        public ProductosController(IServicios servicios)
        {
            this.servicios = servicios;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(servicios.ObtenerProductos());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Producto p){
            bool respuesta = servicios.InsertarProducto(p);
            return Ok(respuesta);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Producto p){
            bool respuesta = servicios.ActualizarProducto(p);
            return Ok(respuesta);
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery]string id){
            bool respuesta = servicios.EliminatProducto(id);
            return Ok(respuesta);
        }

        [HttpGet("Individual")]
        public IActionResult ObtenerProductoPorId([FromQuery]string id){
            return Ok(servicios.ObtenerProducto(id));
        }
    }
}