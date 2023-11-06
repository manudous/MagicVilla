﻿
using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        //create migration add-migration InitialCreate
        //update database update-database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }


        // insertar datos a la base de datos por primera vez
        // nueva migracion para insertar los datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la Villa...",
                    ImageUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 50,
                    Tarifa = 200,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Premium Vista a la Piscina",
                    Detalle = "Detalle de la Villa...",
                    ImageUrl = "",
                    Ocupantes = 4,
                    MetrosCuadrados = 50,
                    Tarifa = 150,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
            );                              
        }
    }
}
