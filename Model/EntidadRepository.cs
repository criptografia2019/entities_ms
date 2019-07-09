using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace EntidadesApi.Model
{

    public class EntidadRepository : IEntidadRepository
    {


        private readonly EntidadContext _context;

        public EntidadRepository( EntidadContext context){
             _context = context;

         }

        public IEnumerable<Entidad> Get()
        {
            return _context.Entidad.ToList();
        }


        public Entidad GetEntidad(int Id)
        {

            Entidad entidad = null;
            try
            {
                entidad = _context.Entidad.Where(ent => ent.IdEntidad == Id).FirstOrDefault();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entidad;
        }


        public void Delete(int id)
        {
            Entidad entidad = null;
            try
            {
                entidad = GetEntidad(id);
                if(entidad==null)
                    _context.Entidad.Remove(entidad);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }


    public interface IEntidadRepository
    {

        IEnumerable<Entidad> Get();
        Entidad GetEntidad(int Id);
        void Delete(int id);
    

}



}