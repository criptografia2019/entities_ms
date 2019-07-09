using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace EntidadesApi.Model{

    public class EntityContext : DbContext
    {




        public EntityContext(DbContextOptions<EntityContext> options):base(options){

        }
   
        public DbSet<Entity> Entity {get;set;}

        public DbSet<Score> Score {get;set;}
    }






}