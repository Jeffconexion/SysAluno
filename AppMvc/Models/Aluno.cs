using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMvc.Models
{
    public class Aluno
    {
        [Key]
        public int Id { set; get; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("Nome Completo")]
        [MaxLength(100, ErrorMessage = "O campo é obrigatório.")]
        public string NomeCompleto { set; get; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("E-mail")]
        [MaxLength(50)]
        public string Email { set; get; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string CPF { set; get; }

        public string Descricao { set; get; }

        public DateTime DataMatricula { set; get; }

        public bool Ativo { set; get; }


    }
}