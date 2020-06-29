using CodenationRestaurante.Dominio.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class TipoPratoRepositorio
    {
        public List<TipoPrato> RetornarTodos()
        {
            using (var contexto = new Contexto())
            {
                return contexto.TipoPrato.ToList();
            }
        }

        public TipoPrato BuscarPorId(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.TipoPrato.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Incluir(TipoPrato tipoPrato)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPrato.Add(tipoPrato);
                contexto.SaveChanges();
            }
        }

        public void Alterar(TipoPrato tipoPrato)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPrato.Update(tipoPrato);
                contexto.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.TipoPrato.FirstOrDefault(x => x.Id == id);
                contexto.TipoPrato.Remove(entity);
                contexto.SaveChanges();
            }
        }
    }
}
