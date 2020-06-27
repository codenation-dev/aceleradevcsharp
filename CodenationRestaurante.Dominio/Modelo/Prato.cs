using System;
using System.Collections.Generic;
using System.Text;

namespace CodenationRestaurante.Dominio.Modelo
{
    public class Prato
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int IdTipoPrato { get; set; }
        public TipoPrato TipoPrato { get; set; }
        public List<PratosIngredientes> PratosIngredientes { get; set; }
    }
}
