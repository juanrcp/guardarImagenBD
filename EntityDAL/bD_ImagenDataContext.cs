using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityDAL
{
    public class bD_ImagenDataContext: DbContext
    {
        //CONSTRUCTOR del contexto
        public bD_ImagenDataContext(DbContextOptions<bD_ImagenDataContext> options) : base(options)
        {
        }

        public bD_ImagenDataContext()
        {
        }

        //Modelo y establecemos que los ID sean autoincrementables.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        //DBSET

        //Declaramos el DbSet de la tabla Imagenes que nos permitira realizar el CRUD con la BD
        public DbSet<Imagen> Imagenes { get; set; }
    }
}
