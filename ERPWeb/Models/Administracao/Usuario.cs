using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERPWeb.Models.Administracao
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource),
                    ErrorMessageResourceName = "UsuarioNomeObrigatorio", 
                    AllowEmptyStrings = false)]
        [StringLength(300)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource),
                    ErrorMessageResourceName = "UsuarioLoginObrigatorio",
                    AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Login { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource),
                    ErrorMessageResourceName = "UsuarioSenhaObrigatoria",
                    AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string Senha { get; set; }

        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        [Display(Name = "E-mail")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [ForeignKey("Perfis")]
        [Display(Name = "Perfil")]
        public int PerfilID { get; set; }

        public virtual Perfil Perfis { get; set; }
    }
}