using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Prueba.Authorization.Roles;
using Prueba.Authorization.Users;
using Prueba.MultiTenancy;
using Prueba.Models;

namespace Prueba.EntityFrameworkCore
{
    public class PruebaDbContext : AbpZeroDbContext<Tenant, Role, User, PruebaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Empleado> Empleado { get; set; }

        public DbSet<Vehiculo> Vehiculo { get; set; }

        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }

        public DbSet<Celda> Celda { get; set; }

        public DbSet<Ingreso> Ingreso { get; set; }


        public PruebaDbContext(DbContextOptions<PruebaDbContext> options)
            : base(options)
        {
        }
    }
}
