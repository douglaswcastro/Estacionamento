using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAD_Parking___Back.Model
{  
    [Table("tarifa")]
    public class Tarifa
    {
        [Key]
        public Guid TarifaId { get; set; }
        public string TipoTarifa { get; set; }
        public string TipoVeiculo { get; set; }
    }    
}