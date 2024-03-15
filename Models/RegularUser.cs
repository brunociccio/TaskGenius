using System;

namespace TaskGenius.Models
{
    public class RegularUser : User
    {
        public string SubscriptionLevel { get; set; }
        public int TotalTasksCompleted { get; set; }

        // Construtor
        public RegularUser(int id, string username, string password, string fullName)
            : base(id, username, password, fullName)
        {
            // Inicialização específica do usuário regular
            SubscriptionLevel = "básico";
            TotalTasksCompleted = 0; // Inicialmente, o usuário não completou nenhuma tarefa
        }
    }
}
