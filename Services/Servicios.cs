using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMongoDB.Models;
using MongoDB.Driver;

namespace ApiMongoDB.Services
{
    public class Servicios : IServicios
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<Producto> productos;
        IMongoCollection<Usuario> user;
        public Servicios()
        {
            cliente = new MongoClient("mongodb+srv://Agust:A.gus2701@agustcluster.v0jia6t.mongodb.net/Inventario");
            db = cliente.GetDatabase("Inventario");
            productos = db.GetCollection<Producto>("Productos");
            user = db.GetCollection<Usuario>("Usuarios");
        }

        public bool ActualizarProducto(Producto p)
        {
            bool resultado = false;
            try
            {
                productos.ReplaceOne(ant => ant.Id == p.Id, p);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public bool EliminatProducto(string Id)
        {
            bool resultado = false;
            try
            {
                productos.DeleteOne(ant => ant.Id == Id);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public bool InsertarProducto(Producto p)
        {
            bool resultado = false;
            try
            {
                productos.InsertOne(p);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> listaProdcutos = productos.Find(f => true).ToList();
            return listaProdcutos;
        }

        public Producto ObtenerProducto(string Id)
        {
            Producto pTemp = productos.Find(x => x.Id == Id).FirstOrDefault();
            return pTemp;
        }

        public bool ValidarUsuario(Usuario u)
        {
            String no = "agus";
            String pw = "123";
            bool resultado = false;
            try
            {
                Usuario uTemp = user.Find(x => x.NombreUsuario == no && x.Pwd == pw).FirstOrDefault();
                if(uTemp != null){
                    resultado = true;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public Usuario ValidarUsuario2(Usuario u)
        {
            Usuario usuario = user.Find(x => x.NombreUsuario == u.NombreUsuario && x.Pwd == u.Pwd).FirstOrDefault();
            return usuario;
        }

        public bool RegistrarUsuario(Usuario u)
        {
            bool resultado = false;
            try
            {
                user.InsertOne(u);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}