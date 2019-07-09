using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;


namespace EntidadesApi.Model{

    public class EntidadContext : DbContext
    {




        public EntidadContext(DbContextOptions<EntidadContext> options):base(options){

        }
   
        public DbSet<Entidad> Entidad {get;set;}


    }






}