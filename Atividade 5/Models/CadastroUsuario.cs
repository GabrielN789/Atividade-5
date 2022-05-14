using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_5.Models
{
    public class CadastroUsuario
    {   [RegularExpression(@"^([a-zA-Z]{2,}\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\s?([a-zA-Z]{1,})?)", ErrorMessage = "Nome inválido" )]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MinLength(5, ErrorMessage = "Nome deve ser maior que 5 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        [RegularExpression(@"^\(?[1-9]{2}\)? ?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$", ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "E-mail inválido")]
        [Required(ErrorMessage = "O campo e-mail é obrigatório")]        
        public string Email { get; set; }
    }
}