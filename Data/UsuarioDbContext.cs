using DeberSem6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberSem6.Data
{
    internal class UsuarioDbContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            var conexion = "server=localhost;database=gestorusuario;pwd=;uid=root;";
            var version_mysql = new MySqlServerVersion(new Version("10.4.32"));
            optionsBuilder.UseMySql(conexion, version_mysql);
        }
    }
}
