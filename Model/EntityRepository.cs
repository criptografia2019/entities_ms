using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EntidadesApi.Model
{

    public class EntityRepository : IEntityRepository
    {


        private readonly EntityContext _context;

        public EntityRepository(EntityContext context)
        {
            _context = context;

        }

        public IEnumerable<Entity> Get()
        {
            return _context.Entity.ToList();
        }


        public Entity GetEntity(int Id)
        {

            Entity entity = null;
            try
            {
                
                entity = _context.Entity.Where(ent => ent.idEntity == Id).FirstOrDefault();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public IEnumerable<Entity>  GetEntityByType(string type)
        {

            IEnumerable<Entity>  entities = null;
            try
            {
                entities = _context.Entity.Where(ent => ent.TypeEntity == type).ToList();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entities;
        }


        public IEnumerable<Entity> GetEntityByZone(string zone)
        {

            IEnumerable<Entity>  entities = null;
            try
            {
                entities = _context.Entity.Where(ent => ent.Zone == zone).ToList();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entities;
        }

        public void PostEntityScore(int id,Score score)
        {

            try
            {
                score.Entity_idEntity = id;
                _context.Score.Add(score);
                _context.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Delete(int id)
        {
            Entity entity = null;
            try
            {
                entity = GetEntity(id);
                if (entity == null)
                    _context.Entity.Remove(entity);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void CreateEntity(Entity item)
        {
            try
            {
                _context.Entity.Add(item);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Score GetScoreEntity(int idEntity)
        {
            Score score = null;
            try
            {
                score =   _context.Score.Where(sc => sc.Entity_idEntity == idEntity).FirstOrDefault();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return score;
        }


        public IEnumerable<Score> GetEntityByScore (int idEntity)
        {

            try
            {
                return _context.Score.Where(sc => sc.Entity_idEntity == idEntity).ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }

    public interface IEntityRepository
    {

        IEnumerable<Entity> Get();

        Score GetScoreEntity(int idEntity);

        Entity GetEntity(int Id);
        IEnumerable<Entity> GetEntityByType(string tipo);
        IEnumerable<Entity> GetEntityByZone(string zona);

        IEnumerable<Score> GetEntityByScore (int idEntity);

        void PostEntityScore(int id, Score score);

        void Delete(int id);

        void CreateEntity(Entity item);


    }

}