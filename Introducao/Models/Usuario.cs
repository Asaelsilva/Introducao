using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introducao.Models
{
    public class Usuario
    {
        public int Name { get; set; }
        public string Observacoes { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
    }
}