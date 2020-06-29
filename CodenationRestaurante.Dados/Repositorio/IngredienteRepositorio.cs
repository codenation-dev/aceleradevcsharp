using CodenationRestaurante.Dominio.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class IngredienteRepositorio
    {
        public List<Ingrediente> RetornarTodos()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Ingrediente.ToList();
            }
        }

        public Ingrediente BuscarPorId(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Incluir(Ingrediente ingrediente)
        {
            using (var contexto = new Contexto())
            {
                contexto.Ingrediente.Add(ingrediente);
                contexto.SaveChanges();
            }
        }

        public void Alterar(Ingrediente ingrediente)
        {
            using (var contexto = new Contexto())
            {
                contexto.Ingrediente.Update(ingrediente);
                contexto.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
                contexto.Ingrediente.Remove(entity);
                contexto.SaveChanges();
            }
        }
    }
}
