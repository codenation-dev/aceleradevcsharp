using CodenationRestaurante.Dominio.Repositorio;
using System;
using System.Collections.Generic;

namespace CodenationRestaurante.Dominio.Modelo
{
    public class Agenda : IEntity
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public List<AgendaCardapio> AgendaCardapio { get; set; }
    }
}
