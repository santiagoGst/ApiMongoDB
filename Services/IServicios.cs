using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMongoDB.Models;

namespace ApiMongoDB.Services
{
    public interface IServicios
    {
        bool InsertarProducto(Producto p);
        List<Producto> ObtenerProductos();
        bool ActualizarProducto(Producto p);
        bool EliminatProducto(string Id);
        Producto ObtenerProducto(string Id);
        bool ValidarUsuario(Usuario u);
        Usuario ValidarUsuario2(Usuario u);
        bool RegistrarUsuario(Usuario u);
    }
}