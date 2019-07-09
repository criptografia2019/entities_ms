using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntidadesApi.Model;

namespace EntidadesApi.Controllers
{
    [Route("api/[controller]")]
    public class EntitiesController : Controller
    {


        private readonly IEntityRepository  _repository;

        public EntitiesController(IEntityRepository repository)
        {
            _repository = repository;

        }
    
        [HttpGet] 
        public IEnumerable<Entity> Get()
        {

            return _repository.Get();

        }


        [HttpGet ("{id}", Name="GetEntity")] 
        public Entity GetEntity(int Id){
            
            return _repository.GetEntity(Id);
        }

        [Route ("Type/{type}")]
        [HttpGet]
        public IEnumerable<Entity> GetEntityByType(string type)
        {       

            return _repository.GetEntityByType(type);
        }

        [Route ("Zone/{zone}")]
        [HttpGet]
        public IEnumerable<Entity> GetEntityByZone(string zone)
        {

            return _repository.GetEntityByZone(zone);
        }


        [Route ("Postscore/{id}")]
        [HttpPost]
        public CreatedAtRouteResult PostEntityScore(int id, [FromBody] Score score)
        {

             _repository.PostEntityScore(id,  score);
            return CreatedAtRoute("GetScores", new { id = score.Entity_idEntity }, score);

        }


        // POST api/values
        [HttpPost]
        public CreatedAtRouteResult CreateEntity([FromBody] Entity item)
        {
                
            _repository.CreateEntity(item);

            return CreatedAtRoute("GetEntity", new { id = item.idEntity }, item);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [Route ("Delete/{id}")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }


        [Route ("score/{id}", Name = "GetScores")]
        [HttpGet]
        public Score GetScoreEntity(int idEntity)
        {
            return _repository.GetScoreEntity(idEntity);

        }


        [Route ("EntitiesByScore/{idEntity}")]
        [HttpGet]
        public IEnumerable<Score> GetEntityByScore (int idEntity)
        {
    
            return _repository.GetEntityByScore(idEntity);
        }
    }
}
