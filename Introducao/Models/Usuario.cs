using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é Obrigatorio")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Minimo 5 e maximo 50 caracteres")]
        public string Observacoes { get; set; }
        [Range(18, 80, ErrorMessage = "Idade Min 18 e Max 80 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um email valido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente palavras de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O Login é Obrigatorio")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Login Já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A Senha é Obrigatorio")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas são diferentes!")]
        public string ConfirmarSenha { get; set; }
    }
}