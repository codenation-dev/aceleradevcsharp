using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class PratosIngredientesRepositorio : RepositorioBase<PratosIngredientes>, IPratosIngredientesRepositorio
    {
        public PratosIngredientesRepositorio(Contexto contexto) 
            : base(contexto)
        {

        }

        public List<PratosIngredientes> SelecionarCompleto()
        {
            return _contexto
                .PratosIngredientes
                .Include(x => x.Ingrediente)
                .Include(x => x.Prato)
                .ToList();
        }
    }
}
