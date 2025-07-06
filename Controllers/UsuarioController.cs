using DeberSem6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DeberSem6.Controllers
{
    internal class UsuarioController
    {
        private readonly Data.UsuarioDbContext _usuarioDbContext;
        public UsuarioController()
        {
            _usuarioDbContext = new Data.UsuarioDbContext();
        }

        public List<UsuarioModel> todos()
        {
            return _usuarioDbContext.Usuarios.ToList();
        }
        public UsuarioModel uno (int Id)
        {
            return _usuarioDbContext.Usuarios.Find(Id);
        }
        public string insertar(UsuarioModel usuarioModel)
        {
            try
            {
                _usuarioDbContext.Usuarios.Add(usuarioModel);
                _usuarioDbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

       public string actualizar(UsuarioModel usuarioModel)
        {
            var usuario = _usuarioDbContext.Usuarios.Find(usuarioModel.Id);
            if (usuario != null) 
                {
                usuario.Nombres = usuarioModel.Nombres;
                usuario.Apellidos = usuarioModel.Apellidos;
                usuario.Edad = usuarioModel.Edad;
                usuario.Genero = usuarioModel.Genero;
                usuario.Correo = usuarioModel.Correo;
                usuario.Direccion = usuarioModel.Direccion;
                usuario.CodigoPostal = usuarioModel.CodigoPostal;
                _usuarioDbContext.SaveChanges();
                return "ok";
                }
            else
            {
                return "error";
            }
        }
        public string eliminar(int Id)
        {
            var usuario = _usuarioDbContext.Usuarios.Find(Id);
            if (usuario != null)
            {
                _usuarioDbContext.Remove(usuario);
                _usuarioDbContext.SaveChanges();
                return "ok";
            }
            else
            {
                return "error";
            }
        }

        public bool ExisteCorreo(string correo, int? idIgnorar = null)
        {
            // Busca si existe un usuario con ese correo, ignorando el id actual si se está editando
            return _usuarioDbContext.Usuarios
                .Any(u => u.Correo.ToLower() == correo.ToLower() && (!idIgnorar.HasValue || u.Id != idIgnorar.Value));
        }

        public bool ExisteNombre(string nombre, int? idIgnorar = null)
        {
            // Busca si existe un usuario con ese nombre, ignorando el id actual si se está editando
            return _usuarioDbContext.Usuarios
                .Any(u => u.Nombres.ToLower() == nombre.ToLower() && (!idIgnorar.HasValue || u.Id != idIgnorar.Value));
        }
    }
}
