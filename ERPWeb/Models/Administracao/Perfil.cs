using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERPWeb.Models.Administracao
{
    [Table("Perfis")]
    public class Perfil
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource),
                    ErrorMessageResourceName = "PerfilDescricaoObrigatoria")]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
        
    }
}