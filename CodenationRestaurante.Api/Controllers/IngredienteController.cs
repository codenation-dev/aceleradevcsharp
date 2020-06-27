using System;
using System.Collections.Generic;
using System.Linq;
using CodenationRestaurante.Dados;
using CodenationRestaurante.Dominio.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        //List<Ingrediente> lst;        

        public IngredienteController()
        {            
            //lst = new List<Ingrediente>();
            //lst.Add(new Ingrediente() { Id = 1, Descricao = "Chocolate em barra de 1kg", Nome = "Chocolate", Validade = new DateTime(2020, 12, 20) });
            //lst.Add(new Ingrediente() { Id = 2, Descricao = "Alho triturado em pote sem sal", Nome = "Alho", Validade = new DateTime(2020, 12, 20) });
            //lst.Add(new Ingrediente() { Id = 3, Descricao = "Arroz branco de 5kg", Nome = "Arroz branco", Validade = new DateTime(2020, 12, 20) });
            //lst.Add(new Ingrediente() { Id = 4, Descricao = "Feijao carioca de 1kg", Nome = "Feijao", Validade = new DateTime(2020, 12, 20) });
            //lst.Add(new Ingrediente() { Id = 5, Descricao = "Farinha de mandioca", Nome = "Farinha de mandioca", Validade = new DateTime(2020, 12, 20) });
        }

        // GET: api/<Ingrediente>
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            using (var contexto = new Contexto())
            {
                //return lst;
                return contexto.Ingrediente.ToList();
            }              
        }

        // GET api/<Ingrediente>/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            using (var contexto = new Contexto())
            {
                //return lst.FirstOrDefault(x => x.Id == id);
                return contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
            }
        }

        // POST api/<Ingrediente>
        [HttpPost]
        public IEnumerable<Ingrediente> Post([FromBody] Ingrediente ingrediente)
        {
            //lst.Add(ingrediente);
            //return lst;

            using (var contexto = new Contexto())
            {                
                contexto.Ingrediente.Add(ingrediente);
                contexto.SaveChanges();

                return contexto.Ingrediente.ToList();
            }
        }

        // PUT api/<Ingrediente>/5
        [HttpPut]
        public IEnumerable<Ingrediente> Put([FromBody] Ingrediente ingrediente)
        {
            //int index = lst.FindIndex(x => x.Id == id);
            //if(index > -1)
            //{
            //    lst[index].Descricao = ingrediente.Descricao;
            //    lst[index].Nome = ingrediente.Nome;
            //    lst[index].Validade = ingrediente.Validade;
            //}

            //return lst;

            using (var contexto = new Contexto())
            {
                contexto.Ingrediente.Update(ingrediente);
                contexto.SaveChanges();

                return contexto.Ingrediente.ToList();
            }
        }

        // DELETE api/<Ingrediente>/5
        [HttpDelete("{id}")]
        public IEnumerable<Ingrediente> Delete(int id)
        {
            //var ingrediente = lst.FirstOrDefault(x => x.Id == id);
            //if(ingrediente != null) lst.Remove(ingrediente);
            //return lst;

            using (var contexto = new Contexto())
            {
                var entity = contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
                contexto.Ingrediente.Remove(entity);
                contexto.SaveChanges();

                return contexto.Ingrediente.ToList();
            }
        }
    }
}
