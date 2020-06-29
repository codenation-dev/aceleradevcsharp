﻿using CodenationRestaurante.Dominio.Repositorio;
using System.Collections.Generic;

namespace CodenationRestaurante.Dominio.Modelo
{
    public class Prato : IEntity
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
