using CodenationRestaurante.Dominio.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class PratoRepositorio
    {
        public List<Prato> RetornarTodos()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Prato.ToList();
            }
        }

        public Prato BuscarPorId(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.Prato.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Incluir(Prato prato)
        {
            using (var contexto = new Contexto())
            {
                contexto.Prato.Add(prato);
                contexto.SaveChanges();
            }
        }

        public void Alterar(Prato prato)
        {
            using (var contexto = new Contexto())
            {
                contexto.Prato.Update(prato);
                contexto.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.Prato.FirstOrDefault(x => x.Id == id);
                contexto.Prato.Remove(entity);
                contexto.SaveChanges();
            }
        }
    }
}
