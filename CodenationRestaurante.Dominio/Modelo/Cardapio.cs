using System;
using System.Collections.Generic;
using System.Text;

namespace CodenationRestaurante.Dominio.Modelo
{
    public class Cardapio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<AgendaCardapio> AgendaCardapio { get; set; }
        public List<Prato> Prato { get; set; }
    }
}
