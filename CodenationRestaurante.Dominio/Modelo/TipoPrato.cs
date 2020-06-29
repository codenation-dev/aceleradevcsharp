using CodenationRestaurante.Dominio.Repositorio;
using System.Collections.Generic;

namespace CodenationRestaurante.Dominio.Modelo
{
    public class TipoPrato : IEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Prato> Pratos { get; set; }
    }
}
