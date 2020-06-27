using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodenationRestaurante.Dados;
using CodenationRestaurante.Dominio.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Prato> Get()
        {
            using (var contexto = new Contexto())
            {                
                return contexto.Prato.ToList();
            }
        }
                
        [HttpGet("{id}")]
        public Prato Get(int id)
        {
            using (var contexto = new Contexto())
            {                
                return contexto.Prato.FirstOrDefault(x => x.Id == id);
            }
        }
                
        [HttpPost]
        public IEnumerable<Prato> Post([FromBody] Prato prato)
        {
            using (var contexto = new Contexto())
            {
                contexto.Prato.Add(prato);
                contexto.SaveChanges();

                return contexto.Prato.ToList();
            }
        }

        [HttpPut]
        public IEnumerable<Prato> Put([FromBody] Prato prato)
        {            
            using (var contexto = new Contexto())
            {
                contexto.Prato.Update(prato);
                contexto.SaveChanges();

                return contexto.Prato.ToList();
            }
        }
               
        [HttpDelete("{id}")]
        public IEnumerable<Prato> Delete(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.Prato.FirstOrDefault(x => x.Id == id);
                contexto.Prato.Remove(entity);
                contexto.SaveChanges();

                return contexto.Prato.ToList();
            }
        }
    }
}
