using CodenationRestaurante.Dominio.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class PratosIngredientesRepositorio
    {
        public List<PratosIngredientes> RetornarTodos()
        {
            using (var contexto = new Contexto())
            {
                return contexto.PratosIngredientes.ToList();
            }
        }

        public PratosIngredientes BuscarPorId(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.PratosIngredientes.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Incluir(PratosIngredientes pratosIngredientes)
        {
            using (var contexto = new Contexto())
            {
                contexto.PratosIngredientes.Add(pratosIngredientes);
                contexto.SaveChanges();
            }
        }

        public void Alterar(PratosIngredientes pratosIngredientes)
        {
            using (var contexto = new Contexto())
            {
                contexto.PratosIngredientes.Update(pratosIngredientes);
                contexto.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.PratosIngredientes.FirstOrDefault(x => x.Id == id);
                contexto.PratosIngredientes.Remove(entity);
                contexto.SaveChanges();
            }
        }
    }
}
