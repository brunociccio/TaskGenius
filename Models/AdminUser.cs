using System;
using System.Collections.Generic;

namespace TaskGenius.Models
{
    public class AdminUser : User
    {
        public string Role { get; set; }
        public List<string> Permissions { get; set; }

        // Propriedade protected para verificar se o usuário é admin ou não
        protected bool IsAdmin { get; set; }

        // Construtor
        public AdminUser(int id, string username, string password, string fullName)
            : base(id, username, password, fullName)
        {
            // Inicialização específica do administrador
            Role = "admin";
            Permissions = new List<string> { "manage_users", "manage_tasks", "view_reports" };
            IsAdmin = true;
        }
    }
}

