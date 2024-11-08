
using Microsoft.EntityFrameworkCore;
using ProyectoMVC.Models;

namespace ProyectoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Login> Login { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
///**
// * 
// * 
// * 
// * 
// * create database MVC
//use MVC

//CREATE TABLE Login (
//    Id INT PRIMARY KEY IDENTITY(1,1),
//    Usuario NVARCHAR(50) NOT NULL,
//    Clave NVARCHAR(50) NOT NULL
//);

//INSERT INTO Login (Usuario, Clave) VALUES ('usuario1', 'clave1');
//INSERT INTO Login (Usuario, Clave) VALUES ('usuario2', 'clave2');
//INSERT INTO Login (Usuario, Clave) VALUES ('admin', 'admin123');
//select * from login


//CREATE TABLE Productos
//(
//    Id INT PRIMARY KEY IDENTITY(1,1),
//    Nombre NVARCHAR(100) NOT NULL,
//    Precio DECIMAL(18, 2) NOT NULL,
//    Cantidad INT NOT NULL
//);
//***//