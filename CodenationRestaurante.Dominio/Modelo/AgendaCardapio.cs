using CodenationRestaurante.Dominio.Repositorio;

namespace CodenationRestaurante.Dominio.Modelo
{
    public class AgendaCardapio : IEntity
    {
        public int IdCardapio { get; set; }
        public Cardapio Cardapio { get; set; }
        public int IdAgenda { get; set; }
        public Agenda Agenda { get; set; }
        public int Id { get; set; }
    }
}
